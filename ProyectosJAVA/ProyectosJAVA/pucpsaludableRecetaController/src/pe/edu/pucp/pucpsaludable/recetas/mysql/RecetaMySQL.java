/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.recetas.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.receta.model.PresetReceta;

import pe.edu.pucp.pucpsaludable.receta.model.Receta;
import pe.edu.pucp.pucpsaludable.recetas.config.DBManager;
import pe.edu.pucp.pucpsaludable.recetas.dao.RecetaDAO;

/**
 *
 * @author Oleg
 */
public class RecetaMySQL implements RecetaDAO{
    //esto se importa siempre
    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    Statement st;
    
    @Override
    public int insertar(Receta receta) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_RECETA(?,?,?,?,?)}");
            cs.registerOutParameter("_id_receta", java.sql.Types.INTEGER);
            cs.setString("_nombre", receta.getNombre());
            cs.setString("_descripcion", receta.getDescripcion());
            cs.setString("_indicaciones", receta.getIndicaciones());
            cs.setInt("_tipo", receta.getTipo());
            cs.executeUpdate();
            receta.setIdReceta(cs.getInt("_id_receta"));
            resultado = 1;
            receta.setEstado(true);
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
    public int modificar(Receta receta) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_RECETA(?,?,?,?,?)}");
            cs.setInt("_id_receta", receta.getIdReceta());
            cs.setString("_nombre", receta.getNombre());
            cs.setString("_descripcion", receta.getDescripcion());
            cs.setString("_indicaciones", receta.getIndicaciones());
            cs.setInt("_tipo", receta.getTipo());
            cs.executeUpdate();
            receta.setIdReceta(cs.getInt("_id_receta"));
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
    public int eliminar(Receta receta) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_RECETA(?)}");
            cs.setInt("_id_receta", receta.getIdReceta());
            
            cs.executeUpdate();
            
            resultado = 1;
            receta.setEstado(false);
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
    public ArrayList<Receta> listarTodos() {
        ArrayList<Receta> recetas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,
                    DBManager.password);
            st = con.createStatement();
            String sql = "select id_receta,nombre from receta";
            rs = st.executeQuery(sql);
            while(rs.next()){
                Receta receta = new Receta();
                receta.setIdReceta(rs.getInt("id_receta"));
                receta.setNombre(rs.getString("nombre"));
                
                
                recetas.add(receta);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{st.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return recetas;
    }

    @Override
    public int asignarPreset(Receta receta,PresetReceta presetRecetat) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ASIGNAR_PRESET_RECETA_A_RECETA(?,?,?)}");
            cs.registerOutParameter("_id_recetaHasPresetReceta", java.sql.Types.INTEGER);
            cs.setInt("_fid_receta", receta.getIdReceta());
            cs.setInt("_fid_presetReceta", presetRecetat.getIdPresetReceta());
            
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
    public Receta obtenerRecetaXIDPreset(int idPreset) {
        Receta recetaRet=new Receta();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call BUSCAR_RECETA_X_ID_PRESET_RECETA(?)}");
            cs.setInt("_id_Preset_Receta", idPreset);
            rs = cs.executeQuery();
            while(rs.next()){
                
                recetaRet.setIdReceta(rs.getInt("p.id_receta"));
                recetaRet.setNombre(rs.getString("p.nombre"));
                recetaRet.setDescripcion(rs.getString("p.descripcion"));
                recetaRet.setEstado(rs.getBoolean("p.estado"));
                recetaRet.setIndicaciones(rs.getString("p.indicaciones"));//p.tipo
                recetaRet.setTipo(rs.getInt("p.indicaciones"));
                 
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{st.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return recetaRet;
    }
    
}
