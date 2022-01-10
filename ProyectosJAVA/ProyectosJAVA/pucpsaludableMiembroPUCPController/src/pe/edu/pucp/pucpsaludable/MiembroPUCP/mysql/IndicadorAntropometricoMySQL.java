    /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.IndicadorAntropometricoDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.IndicadorAntropometrico;

/**
 *
 * @author sebaf
 */
public class IndicadorAntropometricoMySQL implements IndicadorAntropometricoDAO {

    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    
    @Override
    public int insertar(IndicadorAntropometrico indicadorAntropometrico) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_INDICADOR_ANTROPOMETRICO(?,?,?,?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_indicador_antropometrico", java.sql.Types.INTEGER);
            cs.setInt("_fid_alumno", indicadorAntropometrico.getFid_alumno());
            cs.setDate("_fecha_registro",new java.sql.Date(indicadorAntropometrico.getFechaRegistro().getTime()));
            cs.setDouble("_circunferencia_abdominal",indicadorAntropometrico.getCircunferenciaAbdominal());
            cs.setDouble("_circunferencia_brazo",indicadorAntropometrico.getCircunferenciaBrazo());
            cs.setDouble("_circunferencia_cadera",indicadorAntropometrico.getCircunferenciaCadera());
            cs.setDouble("_circunferencia_cintura",indicadorAntropometrico.getCircunferenciaCintura());
            cs.setDouble("_estatura",indicadorAntropometrico.getEstatura());
            cs.setDouble("_peso_habitual",indicadorAntropometrico.getPesoHabitual());
            cs.executeUpdate();
            //ahora, hemos obtenido el id autogenerado
            indicadorAntropometrico.setId_indicadorAntropometrico(cs.getInt("_id_indicador_antropometrico"));
            resultado = 1;
        
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public ArrayList<IndicadorAntropometrico> listarIndicadorAntropometricoPorAlumno(int id_alumno) {
        //Devuelve un objeto de tipo area
        ArrayList<IndicadorAntropometrico> indicadoresAntropometricos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_INDICADOR_ANTROPOMETRICO_POR_ID_ALUMNO(?)}");
            cs.setInt("_fid_alumno", id_alumno);
            cs.executeUpdate();
            rs = cs.executeQuery();
            while(rs.next()){
                IndicadorAntropometrico ia = new IndicadorAntropometrico(); //debe existir el constructo vacio de Area
                ia.setId_indicadorAntropometrico(rs.getInt("id_indicador_antropometrico")); //se coloca el nombre de la columna
                ia.setFid_alumno(id_alumno);
//ia.setIdAlumno();
                ia.setFechaRegistro(rs.getDate("fecha_registro")); //se coloca el nombre de la columna
                ia.setCircunferenciaAbdominal(rs.getDouble("circunferencia_abdominal")); //se coloca el nombre de la columna
                ia.setCircunferenciaBrazo(rs.getDouble("circunferencia_brazo")); //se coloca el nombre de la columna
                ia.setCircunferenciaCadera(rs.getDouble("circunferencia_cadera")); //se coloca el nombre de la columna
                ia.setCircunferenciaCintura(rs.getDouble("circunferencia_cintura")); //se coloca el nombre de la columna
                ia.setPesoHabitual(rs.getDouble("peso_habitual")); //se coloca el nombre de la columna
                ia.setEstatura(rs.getDouble("estatura")); //se coloca el nombre de la columna
                indicadoresAntropometricos.add(ia);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return indicadoresAntropometricos;
    }

    @Override
    public int eliminar(int id_indicadorAntropometrico) {
         int resultado = 0;
        try{
            //registramos el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_INDICADOR_ANTROPOMETRICO(?)}");            
            cs.setInt("_id_indicador_antropometrico", id_indicadorAntropometrico);
            resultado = cs.executeUpdate();
            
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
    public int modificar(IndicadorAntropometrico indicadorAntropometrico) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_INDICADOR_ANTROPOMETRICO(?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_indicador_antropometrico", indicadorAntropometrico.getId_indicadorAntropometrico());
            cs.setInt("_fid_alumno", indicadorAntropometrico.getFid_alumno());
            cs.setDate("_fecha_registro",new java.sql.Date(indicadorAntropometrico.getFechaRegistro().getTime()));
            cs.setDouble("_circunferencia_abdominal",indicadorAntropometrico.getCircunferenciaAbdominal());
            cs.setDouble("_circunferencia_brazo",indicadorAntropometrico.getCircunferenciaBrazo());
            cs.setDouble("_circunferencia_cadera",indicadorAntropometrico.getCircunferenciaCadera());
            cs.setDouble("_circunferencia_cintura",indicadorAntropometrico.getCircunferenciaCintura());
            cs.setDouble("_estatura",indicadorAntropometrico.getEstatura());
            cs.setDouble("_peso_habitual",indicadorAntropometrico.getPesoHabitual());
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
