/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 29/09/2021
Hora: 01:45:43 AM
*/

package pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.EspecialidadDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Especialidad;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Facultad;


public class EspecialidadMySQL implements EspecialidadDAO{
    
    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    CallableStatement cs;
    PreparedStatement ps; //    
    @Override
    public int insertar(Especialidad especialidad) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            

            cs = con.prepareCall("{call INSERTAR_ESPECIALIDAD(?,?,?,?)}");
            
            //tenemos un atributo de salida y 8 de entrada
            /*
            DELIMITER $
            CREATE PROCEDURE INSERTAR_ESPECIALIDAD(
                    OUT _id_especialidad INT,
                    IN _id_facultad INT,
                    IN _nombreEspecialidad varchar(45),
                    IN _descripcionEspecialidad varchar(45)
            )
            BEGIN
            INSERT INTO especialidad(fid_facultad,nombreEspecialidad,descripcionEspecialidad ) 
                VALUES(_id_facultad,_nombreEspecialidad,_descripcionEspecialidad);
                SET _id_especialidad = @@last_insert_id;
            END$
            */
            
            //preparamos el callable statement
            cs.registerOutParameter("_id_especialidad", java.sql.Types.INTEGER);            
            cs.setInt("_id_facultad", especialidad.getFacultad().getId_facultad());
            cs.setString("_nombreEspecialidad", especialidad.getNombreEspecialidad());
            cs.setString("_descripcionEspecialidad", especialidad.getDescripcionEspecialidad());
            
            cs.executeUpdate();
            
            //ahora, hemos obtenido el id autogenerado
            especialidad.setId_especialidad(cs.getInt("_id_especialidad"));
            resultado = 1;
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return resultado; 
    }

    @Override
    public int modificar(Especialidad especialidad) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int id_especialidad) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Especialidad> listarTodos() {

        //Devuelve un objeto de tipo area
        ArrayList<Especialidad> especialidades = new ArrayList<>();
        try{
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            ps = con.prepareStatement("select * from especialidad e inner join facultad f on\n" +
                    "f.id_facultad = e.fid_facultad;");

            rs = ps.executeQuery();      
            //devolverá toda la tabla
            //necesitamos colocarnos en linea por linea
            while(rs.next()){
                Especialidad e = new Especialidad(); //debe existir el constructo vacio de Area
                e.setId_especialidad(rs.getInt("id_especialidad")); //se coloca el nombre de la columna
                e.setNombreEspecialidad(rs.getString("nombreEspecialidad")); //se coloca el nombre de la columna
                e.setDescripcionEspecialidad(rs.getString("descripcionEspecialidad")); //se coloca el nombre de la columna
                
                Facultad f = new Facultad(); //debe existir el constructo vacio de Area
                f.setId_facultad(rs.getInt("id_facultad")); //se coloca el nombre de la columna
                f.setNombreFacultad(rs.getString("nombreFacultad")); //se coloca el nombre de la columna
                f.setDescripcionFacultad(rs.getString("descripcionFacultad")); //se coloca el nombre de la columna
                
                e.setFacultad(f);                
                especialidades.add(e);
                
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return especialidades;



        
    }
    
    

}
