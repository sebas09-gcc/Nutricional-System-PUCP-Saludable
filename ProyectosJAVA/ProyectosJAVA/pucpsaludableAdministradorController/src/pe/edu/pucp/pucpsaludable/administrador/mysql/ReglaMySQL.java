/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.administrador.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.administrador.dao.ReglaDAO;
import pe.edu.pucp.pucpsaludable.administrador.model.Regla;
import pe.edu.pucp.pucpsaludable.administrador.config.DBManager;

/**
 *
 * @author angel
 */
public class ReglaMySQL implements ReglaDAO
{
    Connection con;
    Statement st;
    ResultSet rs;
    PreparedStatement ps;
    CallableStatement cs;
    @Override
    public int insertar(Regla regla)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_REGLA(?,?,?,?)}");
            cs.registerOutParameter("_id_regla", java.sql.Types.INTEGER);
            cs.setString("_nombre", regla.getNombre());
            cs.setInt("_clave", regla.getClave());
            cs.setInt("_tipo", regla.getTipo());
            cs.executeUpdate();
            
            regla.setId_regla(cs.getInt("_id_regla"));
            regla.setEstado(true);
            resultado = 1;
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try
            {
                cs.close();
            }
            catch(Exception ex)
            {
                System.out.println(ex.getMessage());
            }
            ;
            try
            {
                con.close();
            }
            catch(Exception ex)
            {
                System.out.println(ex.getMessage());
            }
            ;
        }
        return resultado;
    }
    @Override
    public int modificar(Regla regla)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_REGLA(?,?,?,?)}");
            cs.setInt("_id_regla", regla.getId_regla());
            cs.setString("_nombre", regla.getNombre());
            cs.setInt("_clave", regla.getClave());
            cs.setInt("_tipo", regla.getTipo());
            cs.executeUpdate();
            resultado = 1;
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try
            {
                cs.close();
            }
            catch(Exception ex)
            {
                System.out.println(ex.getMessage());
            }
            ;
            try
            {
                con.close();
            }
            catch(Exception ex)
            {
                System.out.println(ex.getMessage());
            }
            ;
        }
        return resultado;
    }
    @Override
    public int eliminar(int id_regla)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call "+
                    "ELIMINAR_REGLA(?)}");
            cs.setInt("_id_regla", id_regla);
            resultado = cs.executeUpdate();
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try
            {
                cs.close();
            }
            catch(Exception ex)
            {
                System.out.println(ex.getMessage());
            }
            ;
            try
            {
                con.close();
            }
            catch(Exception ex)
            {
                System.out.println(ex.getMessage());
            }
            ;
        }
        return resultado;
    }
    @Override
    public ArrayList<Regla> listarTodos()
    {
        int resultado = 0;
        ArrayList<Regla> lreglas = new ArrayList<Regla>();
         try
         {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_REGLA()}");
            rs = cs.executeQuery();
            while(rs.next())
            {
                Regla regla = new Regla();
                regla.setId_regla(rs.getInt("id_regla"));
                regla.setNombre(rs.getString("nombre"));
                regla.setClave(rs.getInt("clave"));
                regla.setTipo(rs.getInt("tipo"));
                regla.setEstado(true);
                lreglas.add(regla);
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
        return lreglas;
    }
}
