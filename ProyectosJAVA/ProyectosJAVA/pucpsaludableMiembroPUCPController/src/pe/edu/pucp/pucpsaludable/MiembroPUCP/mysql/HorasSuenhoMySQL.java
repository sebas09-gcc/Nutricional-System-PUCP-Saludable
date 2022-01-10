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
import java.sql.Timestamp;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.HorasSuenhoDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.HorasSuenho;

/**
 *
 * @author sebaf
 */
public class HorasSuenhoMySQL implements HorasSuenhoDAO{

    
    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    
    @Override
    public int insertar(HorasSuenho horasDeSuenho) {
        int resultado = 0;
        try{
            Timestamp tsf = new Timestamp(horasDeSuenho.getFecha().getTime());
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_HORAS_SUENHO(?,?,?,?)}");
            cs.registerOutParameter("_id_horas_sueno", java.sql.Types.INTEGER);
            cs.setInt("_fid_alumno", horasDeSuenho.getFid_alumno());
            cs.setTimestamp("_fecha",tsf);
            cs.setDouble("_horas",horasDeSuenho.getHoras());
            //cs.setInt("_horas",horasDeSuenho.getHoras());
            cs.executeUpdate();
            //ahora, hemos obtenido el id autogenerado
            horasDeSuenho.setId_horasSueno(cs.getInt("_id_horas_sueno"));
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
    public ArrayList<HorasSuenho> listarHorasSuenhoPorAlumno(int id_alumno) {
        //Devuelve un objeto de tipo area
        ArrayList<HorasSuenho> listhoras = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_HORAS_SUENO_POR_ID_ALUMNO(?)}");
            cs.setInt("_fid_alumno",id_alumno);
            cs.executeUpdate();
            
            rs = cs.executeQuery();
            
            while(rs.next()){
                HorasSuenho hs = new HorasSuenho(); //debe existir el constructo vacio de Area
                
                hs.setId_horasSueno(rs.getInt("id_horas_sueno")); //se coloca el nombre de la columna
                hs.setFecha(rs.getTimestamp("fecha")); //se coloca el nombre de la columna
                hs.setHoras(rs.getDouble("horas")); //se coloca el nombre de la columna
                hs.setFid_alumno(id_alumno);
                
                listhoras.add(hs);
                
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return listhoras;
    }

    @Override
    public int eliminar(int id_horasSuenho) {
        int resultado = 0;
        try{
            //registramos el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call ELIMINAR_HORAS_SUENO(?)}");            
            cs.setInt("_id_horas_sueno", id_horasSuenho);
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
    public int modificar(HorasSuenho horasDeSuenho) {
        int resultado = 0;
        try{
            Timestamp tsf = new Timestamp(horasDeSuenho.getFecha().getTime());
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_HORAS_SUENO(?,?,?,?)}");
            cs.setInt("_id_horas_sueno", horasDeSuenho.getId_horasSueno());
            cs.setInt("_fid_alumno", horasDeSuenho.getFid_alumno());
            cs.setTimestamp("_fecha",tsf);
            cs.setDouble("_horas",horasDeSuenho.getHoras());
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
