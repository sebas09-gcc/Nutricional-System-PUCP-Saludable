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
import pe.edu.pucp.pucpsaludable.receta.model.Ingrediente;

import pe.edu.pucp.pucpsaludable.receta.model.PresetReceta;
import pe.edu.pucp.pucpsaludable.recetas.config.DBManager;
import pe.edu.pucp.pucpsaludable.recetas.dao.PresetRecetaDAO;

/**
 *
 * @author Oleg
 */
public class PresetRecetaMySQL implements PresetRecetaDAO{
    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    Statement st;
    @Override
    public int insertar(PresetReceta presetReceta) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_PRESETRECETA(?,?,?)}");
            cs.registerOutParameter("_id_preseReceta", java.sql.Types.INTEGER);
            cs.setString("_nombre", presetReceta.getNombre());
            cs.setDouble("_kcalTotales", presetReceta.getKcal());

            cs.executeUpdate();
            presetReceta.setIdPresetReceta(cs.getInt("_id_preseReceta"));
            resultado = 1;
            presetReceta.setEstado(1);
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
    public int modificar(PresetReceta presetReceta) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_PRESETRECETA(?,?,?)}");
            cs.setInt("_id_preseReceta",presetReceta.getIdPresetReceta());
            cs.setString("_nombre", presetReceta.getNombre());
            cs.setDouble("_kcalTotales", presetReceta.getKcal());

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
    public int eliminar(PresetReceta presetReceta) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_PRESETRECETA(?)}");
            cs.setInt("_id_preseReceta",presetReceta.getIdPresetReceta());

            cs.executeUpdate();
            
            resultado = 1;
            presetReceta.setEstado(0);
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
    public ArrayList<PresetReceta> listarTodos() {
        ArrayList<PresetReceta> presetRecetas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{ call LISTAR_PRESETRECETA() }");

            rs = cs.executeQuery();
            
            while(rs.next()){
                PresetReceta presetReceta = new PresetReceta();
                presetReceta.setIdPresetReceta(rs.getInt("id_presetReceta"));
                presetReceta.setNombre(rs.getString("nombre"));
                presetReceta.setKcal(rs.getDouble("kcalTotales"));
                
                
                presetRecetas.add(presetReceta);
            }
            
            
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{    
            try{con.close();} catch(Exception ex){System.out.println(ex.getMessage());
            }
        }
        return presetRecetas;
    }

    @Override
    public int asignarIngrediente(PresetReceta presetReceta, Ingrediente ingrediente) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ASIGNAR_INGREDIENTE_A_PRESET_RECETA(?,?,?,?,?)}");
            cs.registerOutParameter("_id_presetRecetaHasIngrediente", java.sql.Types.INTEGER);
            cs.setInt("_fid_presetReceta", presetReceta.getIdPresetReceta());
            cs.setInt("_fid_ingrediente", ingrediente.getIdIngrediente());
            cs.setDouble("_kcal", ingrediente.getKcal());
            cs.setDouble("_cantidad", ingrediente.getCantidad());

            cs.executeUpdate();
            //presetReceta.setIdPresetReceta(cs.getInt("_id_presetRecetaHasIngrediente"));
            resultado = 1;
            presetReceta.setEstado(1);
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
    public ArrayList<PresetReceta> listarPorTipoComida(int tipo) {
        ArrayList<PresetReceta> presetRecetas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{ call LISTAR_PRESETRECETA_X_TIPO_COMIDA(?) }");
            cs.setInt("_tipo", tipo);
            rs = cs.executeQuery();
            
            while(rs.next()){
                PresetReceta presetReceta = new PresetReceta();
                presetReceta.setIdPresetReceta(rs.getInt("i.id_presetReceta"));
                presetReceta.setNombre(rs.getString("i.nombre"));
                presetReceta.setKcal(rs.getDouble("i.kcalTotales"));
                // i.id_presetReceta,i.nombre,i.kcalTotales
                
                presetRecetas.add(presetReceta);
            }
            
            
            rs.close();
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{    
            try{con.close();} catch(Exception ex){System.out.println(ex.getMessage());
            }
        }
        return presetRecetas;
    }
    
}
