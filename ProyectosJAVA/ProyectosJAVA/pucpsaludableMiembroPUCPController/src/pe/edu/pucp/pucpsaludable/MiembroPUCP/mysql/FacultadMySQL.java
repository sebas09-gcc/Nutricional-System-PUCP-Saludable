/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 29/09/2021
Hora: 01:45:51 AM
*/

package pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.FacultadDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Facultad;


public class FacultadMySQL implements FacultadDAO{

    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    
    @Override
    public int insertar(Facultad facultad) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            

            cs = con.prepareCall("{call INSERTAR_FACULTAD(?,?,?)}");
            
            //tenemos un atributo de salida y 8 de entrada
            /*
            DELIMITER $
            CREATE PROCEDURE INSERTAR_FACULTAD(
                    OUT _id_facultad INT,
                    IN _nombreFacultad varchar(45),
                    IN _descripcionFacultad varchar(45)
            )
            BEGIN
            INSERT INTO facultad(nombreFacultad,descripcionFacultad) 
                VALUES(_nombreFacultad,_descripcionFacultad);
                SET _id_facultad = @@last_insert_id;
            END$
            */
            
            //preparamos el callable statement
            cs.registerOutParameter("_id_facultad", java.sql.Types.INTEGER);            
            cs.setString("_nombreFacultad", facultad.getNombreFacultad());
            cs.setString("_descripcionFacultad", facultad.getDescripcionFacultad());
            
            cs.executeUpdate();
            
            //ahora, hemos obtenido el id autogenerado
            facultad.setId_facultad(cs.getInt("_id_facultad"));
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
    public int modificar(Facultad facultad) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int id_facultad) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Facultad> listarTodos() {
        
        //Devuelve un objeto de tipo area
        ArrayList<Facultad> facultades = new ArrayList<>();
        try{
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            ps = con.prepareStatement("SELECT * FROM facultad;");

            rs = ps.executeQuery();      
            //devolverá toda la tabla
            //necesitamos colocarnos en linea por linea
            while(rs.next()){
                Facultad f = new Facultad(); //debe existir el constructo vacio de Area
                f.setId_facultad(rs.getInt("id_facultad")); //se coloca el nombre de la columna
                f.setNombreFacultad(rs.getString("nombreFacultad")); //se coloca el nombre de la columna
                f.setDescripcionFacultad(rs.getString("descripcionFacultad")); //se coloca el nombre de la columna
                
                facultades.add(f);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{ps.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return facultades;
    }
    
}
