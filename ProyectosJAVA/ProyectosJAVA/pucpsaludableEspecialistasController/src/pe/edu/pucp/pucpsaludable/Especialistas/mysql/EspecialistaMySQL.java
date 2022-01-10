/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.Especialistas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.Especialistas.config.DBManager;
import pe.edu.pucp.pucpsaludable.Especialistas.dao.EspecialistaDAO;

/**
 *
 * @author Nico
 */
public class EspecialistaMySQL implements EspecialistaDAO{
    Connection con;
    Statement st;
    ResultSet rs;
    PreparedStatement ps;
    CallableStatement cs;

    @Override
    public int agregarVideoAEspecialista(int id, String URL) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call AGREGAR_VIDEO_A_ESPECIALISTA(?,?)}");
            cs.setInt("_id_especialista", id);
            cs.setString("_URLVideoInformativo", URL);
            
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{ps.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return resultado;
    }
    
    @Override
    public ArrayList<String> listarVideos() {
        ArrayList<String> videos = new ArrayList<>();
         try
         {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call DA_VIDEOS()}");
            rs = cs.executeQuery();
            while(rs.next())
            {
                videos.add(rs.getString("URLVideoInformativo"));
            }
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
         {
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return videos;
    }
    
    
    @Override
    public ArrayList<String> videoEspecialistaPorID(int id) {
        ArrayList<String> videos = new ArrayList<>();
         try
         {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call VIDEO_POR_ID(?)}");
            cs.setInt("_id_especialista", id);
            rs = cs.executeQuery();
            while(rs.next())
            {
                videos.add(rs.getString("URLVideoInformativo"));
            }
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
         {
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return videos;
    }
    
    ///////////////////////////////////////////
    
    @Override
    public int agregarMensajeAEspecialista(int id, String titulo, String mensaje) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call AGREGAR_TEXTO_A_ESPECIALISTA(?,?,?)}");
            cs.setInt("_id_especialista", id);
            cs.setString("_tituloMensaje", titulo+"#");
            cs.setString("_mensajeMensaje", mensaje);
            
            cs.executeUpdate();
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{ps.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return resultado;
    }
    
    @Override
    public ArrayList<String> listarMensajes() {
        ArrayList<String> videos = new ArrayList<>();
         try
         {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call DA_MENSAJES()}");
            rs = cs.executeQuery();
            while(rs.next())
            {
                videos.add(rs.getString("tituloMensaje")+rs.getString("mensajeMensaje"));
            }
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
         {
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return videos;
    }
    
    
    @Override
    public ArrayList<String> mensajeEspecialistaPorID(int id) {
        ArrayList<String> videos = new ArrayList<>();
         try
         {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call MENSAJE_POR_ID(?)}");
            cs.setInt("_id_especialista", id);
            rs = cs.executeQuery();
            while(rs.next())
            {
                videos.add(rs.getString("tituloMensaje")+rs.getString("mensajeMensaje"));
            }
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
         {
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return videos;
    }
    
    
}
