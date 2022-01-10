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
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.autenticacion.config.DBManager;
import pe.edu.pucp.pucpsaludable.autenticacion.dao.TokenDAO;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Token;

/**
 *
 * @author angel
 */
public class TokenMySQL implements TokenDAO
{
    Connection con;
    Statement st;
    ResultSet rs;
    PreparedStatement ps;
    CallableStatement cs;
    @Override
    public int insertar(Token token)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_TOKEN(?,?,?)}");
            cs.registerOutParameter("_id_token", java.sql.Types.INTEGER);
            cs.setString("_codigo", token.getCodigo());
            cs.setDate("_fechaHora", 
                    new java.sql.Date(token.getFechaHora().getTime()));
            cs.executeUpdate();
            
            token.setId(cs.getInt("_id_token"));
            token.setValido(true);
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
    public int modificar(Token token)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_TOKEN(?,?,?)}");
            cs.setInt("_id_token", token.getId());
            cs.setString("_codigo", token.getCodigo());
            cs.setDate("_fechaHora", 
                    new java.sql.Date(token.getFechaHora().getTime()));
            cs.executeUpdate();
            token.setValido(true);
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
    public int eliminar(int id_token)
    {
        int resultado = 0;
        try
        {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call "+
                    "ELIMINAR_TOKEN(?)}");
            cs.setInt("_id_token", id_token);
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
    public ArrayList<Token> listarTodos()
    {
        int resultado = 0;
        ArrayList<Token> ltokens = new ArrayList<Token>();
         try
         {
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_TOKEN()}");
            rs = cs.executeQuery();
            while(rs.next())
            {
                Token token = new Token();
                token.setId(rs.getInt("id_token"));
                token.setCodigo(rs.getString("codigo"));
                token.setFechaHora(rs.getDate("fechaHora"));
                token.setValido(true);
                ltokens.add(token);
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
        return ltokens;
    }
}
