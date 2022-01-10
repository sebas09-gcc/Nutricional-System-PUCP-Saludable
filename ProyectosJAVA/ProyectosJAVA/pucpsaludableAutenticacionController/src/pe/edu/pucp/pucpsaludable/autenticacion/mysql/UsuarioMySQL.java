/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.autenticacion.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.autenticacion.config.DBManager;
import pe.edu.pucp.pucpsaludable.autenticacion.dao.UsuarioDAO;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Usuario;
import pe.edu.pucp.pucpsaludable.especialista.model.Nutricionista;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alumno;

/**
 *
 * @author angel
 */
public class UsuarioMySQL implements UsuarioDAO
{
    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    @Override
    public int verificarRegistro(String codigoPUCP)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call VERIFICAR_USUARIOREGISTRADO(?,?)}");
            //preparamos el callable statement
            cs.registerOutParameter("_id_usuario", java.sql.Types.INTEGER);
            cs.setString("_codigoPUCP", codigoPUCP);
            cs.executeUpdate();
            return cs.getInt("_id_usuario");
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return 0; 
    }

    @Override
    public int cambiarContrasena(int userid, String contrasena)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call CAMBIAR_CONTRASENA(?,?,?)}");
            //preparamos el callable statement
            cs.registerOutParameter("_estado", java.sql.Types.INTEGER);
            cs.setInt("_id_usuario", userid);
            cs.setString("_contrasena", contrasena);
            cs.executeUpdate();
            return cs.getInt("_estado");
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return 0; 
    }

    @Override
    public ArrayList<Usuario> listarUsuariosPorEstado(String nombre, int estado)
    {
        int resultado = 0;
        ArrayList<Usuario> usuarios = new ArrayList<>();
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_USUARIOS_POR_ESTADO(?, ?)}");
            cs.setString("_nombre",nombre);
            cs.setInt("_estado",estado);
            //cargamos la instruccion a la conexion
            rs = cs.executeQuery();
            while(rs.next())
            {
                Usuario user = new Alumno();
                if (rs.getInt("fid_rol") == 2)
                {
                    // Nutricionista
                    user = new Nutricionista();
                }
                user.setId_usuario(rs.getInt("id_usuario"));
                user.setCodigoPUCP(rs.getString("codigoPUCP"));
                user.setContrasena(rs.getString("contrasena"));
                user.setNombres(rs.getString("nombres"));
                user.setApellidos(rs.getString("apellidos"));
                user.setEmailPUCP(rs.getString("emailPUCP"));
                user.setEmailPersonal(rs.getString("emailPersonal"));
                user.setTelefonoMovil(rs.getString("telefonoMovil"));
                user.setFechaNacimiento(rs.getDate("fechaNacimiento"));
                user.setFotoSrc(rs.getBytes("fotoSrc"));
                user.setEstado(rs.getInt("estado"));
                usuarios.add(user);
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
        return usuarios;
    }

    @Override
    public int cambiarEstadoUsuario(int id, int estado)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call "+
                    "MODIFICAR_ESTADO_USUARIO(?, ?)}");
            cs.setInt("_id_usuario", id);
            cs.setInt("_estado", estado);
            cs.executeUpdate();
            resultado = 1;
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;       
    }
}
