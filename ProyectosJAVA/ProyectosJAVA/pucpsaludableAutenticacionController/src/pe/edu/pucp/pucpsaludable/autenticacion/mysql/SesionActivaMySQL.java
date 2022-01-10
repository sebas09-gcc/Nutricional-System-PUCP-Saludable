/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.autenticacion.mysql;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.autenticacion.dao.SesionActivaDAO;
import pe.edu.pucp.pucpsaludable.autenticacion.model.SesionActiva;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.Timestamp;
import pe.edu.pucp.pucpsaludable.autenticacion.config.DBManager;

/*
 * @author angel
 */
public class SesionActivaMySQL implements SesionActivaDAO
{
    Connection con;
    Statement st;
    ResultSet rs;
    PreparedStatement ps;
    CallableStatement cs;

    @Override
    public String [] verificar(int idSesionActiva)
    {
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call VERIFICAR_SESIONACTIVA(?,?,?)}");
            cs.registerOutParameter("_id_usuario", java.sql.Types.INTEGER);
            cs.registerOutParameter("_rol", java.sql.Types.VARCHAR);
            cs.setInt("_id_sesionactiva", idSesionActiva);
            cs.executeUpdate();
            String [] ret = new String[2];
            ret[0] = String.valueOf(cs.getInt("_id_usuario"));
            ret[1] = cs.getString("_rol");
            return ret;
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try {cs.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
            try {con.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
        }
        return null;
    }


    @Override
    public String [] iniciarSesion(String usuario, String contrasena, String descripcion)
    {
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INICIAR_SESION(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_sesionactiva", java.sql.Types.INTEGER);
            cs.registerOutParameter("_id_usuario", java.sql.Types.INTEGER);
            cs.registerOutParameter("_rol", java.sql.Types.VARCHAR);
            cs.setString("_usuario", usuario);
            cs.setString("_contrasena", contrasena);
            cs.setString("_descripcion", descripcion);
            cs.executeUpdate();
            String [] ret = new String[3];
            ret[0] = String.valueOf(cs.getInt("_id_sesionactiva"));
            ret[1] = String.valueOf(cs.getInt("_id_usuario"));
            ret[2] = cs.getString("_rol");
            return ret;
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try {cs.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
            try {con.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
        }
        return null;
    }

    @Override
    public int insertar(SesionActiva sesionActiva)
    {
        int resultado = 0;
        try
        {
            Timestamp tsfhini = new java.sql.Timestamp(sesionActiva.getFechaInicio().getTime());
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_SESIONACTIVA(?,?,?,?)}");
            cs.registerOutParameter("_id_sesionActiva", java.sql.Types.INTEGER);
            cs.setInt("_fid_usuario", sesionActiva.getIdUsuario());
            cs.setString("_descripcion", sesionActiva.getDescripcion());
            cs.setTimestamp("_fechaHoraInicio", tsfhini);
            cs.executeUpdate();
            sesionActiva.setId(cs.getInt("_id_sesionActiva"));
            sesionActiva.setValida(true);
            resultado = 1;
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try {cs.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
            try {con.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
        }
        return resultado;
    }
    @Override
    public int modificar(SesionActiva sesionActiva)
    {
        int resultado = 0;
        try
        {
            Timestamp tsfhini = new java.sql.Timestamp(sesionActiva.getFechaInicio().getTime());
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_SESIONACTIVA(?,?,?,?)}");
            cs.setInt("_id_sesionActiva", sesionActiva.getId());
            cs.setInt("_fid_usuario", sesionActiva.getIdUsuario());
            cs.setString("_descripcion", sesionActiva.getDescripcion());
            cs.setTimestamp("_fechaHoraInicio", tsfhini);
            cs.executeUpdate();
            resultado = 1;
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try {cs.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
            try {con.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
        }
        return resultado;
    }
    @Override
    public int eliminar(int id_sesionActiva)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call "+
                    "ELIMINAR_SESIONACTIVA(?)}");
            cs.setInt("_id_sesionActiva", id_sesionActiva);
            resultado = cs.executeUpdate();
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try {cs.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
            try {con.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
        }
        return resultado;
    }
    @Override
    public ArrayList<SesionActiva> listarPorID(int id_usuario)
    {
        int resultado = 0;
        ArrayList<SesionActiva> lsactiva = new ArrayList<SesionActiva>();
         try
         {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_SESIONACTIVA(?)}");
            cs.setInt("_id_usuario", id_usuario);
            rs = cs.executeQuery();
            while(rs.next())
            {
                SesionActiva sactiva = new SesionActiva();
                sactiva.setId(rs.getInt("id_sesionActiva"));
                sactiva.setIdUsuario(id_usuario);
                sactiva.setDescripcion(rs.getString("descripcion"));
                sactiva.setFechaInicio(rs.getTimestamp("fechaHoraInicio"));
                sactiva.setValida(true);
                lsactiva.add(sactiva);
            }
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try {cs.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
            try {con.close();} catch(Exception ex) {System.out.println(ex.getMessage());};
        }   
        return lsactiva;
    }

    @Override
    public void cerrarTodas(int id_usuario)
    {
        ArrayList<SesionActiva> ls = listarPorID(id_usuario);
        for (SesionActiva sa: ls)
        {
            eliminar(sa.getId());
        }
    }
}
