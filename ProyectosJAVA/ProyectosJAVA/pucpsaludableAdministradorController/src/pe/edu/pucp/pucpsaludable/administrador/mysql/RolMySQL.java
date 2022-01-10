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
import pe.edu.pucp.pucpsaludable.administrador.dao.RolDAO;
import pe.edu.pucp.pucpsaludable.administrador.model.Rol;
import pe.edu.pucp.pucpsaludable.administrador.config.DBManager;
import pe.edu.pucp.pucpsaludable.administrador.model.Regla;

/**
 *
 * @author angel
 */
public class RolMySQL implements RolDAO
{
    Connection con;
    Statement st;
    ResultSet rs, rs2;
    CallableStatement cs, cs2;

    @Override
    public int insertar(Rol rol)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_ROL(?,?)}");
            cs.registerOutParameter("_id_rol", java.sql.Types.INTEGER);
            cs.setString("_nombre", rol.getNombre());
            cs.executeUpdate();
            rol.setId_rol(cs.getInt("_id_rol"));
            // Establecer reglas
            for(Regla regla : rol.getReglas())
            {
                cs2 = con.prepareCall("{call INSERTAR_ROL_HAS_REGLA(?,?)}");
                cs2.setInt("_fid_rol", rol.getId_rol());
                cs2.setInt("_fid_regla", regla.getId_regla());
                cs2.executeUpdate();
            }
            rol.setEstado(true);
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
    public int modificar(Rol rol)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_ROL(?,?)}");
            cs.setInt("_id_rol", rol.getId_rol());
            cs.setString("_nombre", rol.getNombre());
            cs.executeUpdate();
            // Modificar reglas
            for(Regla regla : rol.getReglas())
            {
                cs2 = con.prepareCall("{call MODIFICAR_ROL_HAS_REGLA(?,?)}");
                cs2.setInt("_fid_rol", rol.getId_rol());
                cs2.setInt("_fid_regla", regla.getId_regla());
                cs2.executeUpdate();
            }

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
    public int eliminar(int id_rol)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call "+
                    "ELIMINAR_ROL(?)}");
            cs.setInt("_id_rol", id_rol);
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
    public ArrayList<Rol> listarTodos()
    {
        int resultado = 0;
        ArrayList<Rol> lrols = new ArrayList<Rol>();
         try
         {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_ROL()}");
            rs = cs.executeQuery();
            while(rs.next())
            {
                Rol rol = new Rol();
                rol.setId_rol(rs.getInt("id_rol"));
                rol.setNombre(rs.getString("nombre"));
                rol.setEstado(true);

                cs2 = con.prepareCall("{call LISTAR_ROL_HAS_REGLA(?)}");
                cs2.setInt("_fid_rol", rol.getId_rol());
                rs2 = cs2.executeQuery();
                ArrayList<Regla> lreglas = new ArrayList<Regla>();
                while(rs2.next())
                {
                    Regla regla = new Regla();
                    regla.setId_regla(rs2.getInt("id_regla"));
                    regla.setNombre(rs2.getString("nombre"));
                    regla.setClave(rs2.getInt("clave"));
                    regla.setTipo(rs2.getInt("tipo"));
                    regla.setEstado(true);
                    lreglas.add(regla);
                }
                rol.setReglas(lreglas);
                lrols.add(rol);
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
        return lrols;
    }
}
