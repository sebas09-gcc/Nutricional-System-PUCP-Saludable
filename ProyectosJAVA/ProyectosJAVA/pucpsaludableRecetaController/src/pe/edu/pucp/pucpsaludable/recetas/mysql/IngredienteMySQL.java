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
import pe.edu.pucp.pucpsaludable.recetas.config.DBManager;
import pe.edu.pucp.pucpsaludable.recetas.dao.IngredienteDAO;

/**
 *
 * @author Oleg
 */
public class IngredienteMySQL implements IngredienteDAO{
    
    //esto se importa siempre
    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    Statement st;

    @Override
    public int insertar(Ingrediente ingrediente) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_INGREDIENTE(?,?,?,?,?,?,?,?,?)}");
            //insertar los datos en las variables
            cs.registerOutParameter("_id_ingrediente", java.sql.Types.INTEGER);
            cs.setString("_nombre",ingrediente.getNombre());
            cs.setString("_unidad",ingrediente.getUnidad());
            cs.setDouble("_cantidad", ingrediente.getCantidad());
            cs.setInt("_kcal", ingrediente.getKcal());
            cs.setBoolean("_grasasSaturadas", ingrediente.isGrasasSaturadas());
            cs.setBoolean("_azucar", ingrediente.isAzucar());
            cs.setBoolean("_sodio", ingrediente.isSodio());
            cs.setBoolean("_grasasTrans", ingrediente.isGrasasTrans());
            cs.executeUpdate();
            //ahora, hemos obtenido el id autogenerado
            ingrediente.setIdIngrediente(cs.getInt("_id_ingrediente"));
            resultado = 1;
            ingrediente.setEstado(true);
           
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
    public int modificar(Ingrediente ingrediente) {
      /*int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_PSICOLOGO(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_administrativo",psic.getIdPersona());
            cs.setInt("_id_miembro_ooia",psic.getIdMiembroOOIA());
            cs.setString("_codigo_pucp",psic.getCodigoPUCP());
            cs.setString("_dni",psic.getDNI());
            cs.setString("_nombre_completo",psic.getNombreCompleto());
            cs.setDate("_fecha_nacimiento",new java.sql.Date(psic.getFechaNacimiento().getTime()));
            cs.setInt("_edad",psic.getEdad());
            cs.setString("_sexo",String.valueOf(psic.getSexo()));
            cs.setString("_telefono",psic.getTelefono());
            cs.setString("_correo",psic.getCorreo());
            cs.setString("_usuario",psic.getUsuario());
            cs.setString("_password",psic.getPassword());
            cs.setInt("_estado",(byte)(psic.getEstado() ? 1 : 0));
            cs.setInt("_horas_semanales", psic.getHorasSemanales());
            cs.setDouble("_rendimiento", psic.getRendimiento());
            cs.setString("_colegiatura", psic.getColegiatura());
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;*/
      int resultado = 0;
      try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_INGREDIENTE(?,?,?,?,?,?,?,?,?}");
            cs.setInt("_id_ingrediente", ingrediente.getIdIngrediente());
            cs.setString("_nombre",ingrediente.getNombre());
            cs.setString("_unidad",ingrediente.getUnidad());
            cs.setDouble("_cantidad", ingrediente.getCantidad());
            cs.setInt("_kcal", ingrediente.getKcal());
            cs.setBoolean("_grasasSaturadas", ingrediente.isGrasasSaturadas());
            cs.setBoolean("_azucar", ingrediente.isAzucar());
            cs.setBoolean("_sodio", ingrediente.isSodio());
            cs.setBoolean("_grasasTrans", ingrediente.isGrasasTrans());
            cs.executeUpdate();
            resultado = 1;
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }
    @Override
    public int eliminar(Ingrediente ingrediente) {
        int resultado = 0;
      try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call ELIMINAR_INGREDIENTE(?}");
            cs.setInt("_id_ingrediente", ingrediente.getIdIngrediente());
            
            cs.executeUpdate();
            resultado = 1;
            ingrediente.setEstado(false);
            cs.close();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }

    @Override
    public ArrayList<Ingrediente> listarTodos() {
        
        ArrayList<Ingrediente> ingredientes = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,
                    DBManager.password);
            st = con.createStatement();
            String sql = "SELECT * FROM ingrediente";
            rs = st.executeQuery(sql);
            while(rs.next()){
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.setIdIngrediente(rs.getInt("id_ingrediente"));
                ingrediente.setNombre(rs.getString("nombre"));
                ingrediente.setCantidad(rs.getDouble("cantidad"));
                ingrediente.setKcal(rs.getInt("kcal"));
                ingrediente.setGrasasSaturadas(rs.getBoolean("grasasSaturadas"));
                ingrediente.setAzucar(rs.getBoolean("azucar"));
                ingrediente.setSodio(rs.getBoolean("sodio"));
                ingrediente.setGrasasTrans(rs.getBoolean("grasasTrans"));
                
                ingredientes.add(ingrediente);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{st.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return ingredientes;
    }

    @Override
    public ArrayList<Ingrediente> listarXNombre(String nombre) {
        ArrayList<Ingrediente> ingredientes = new ArrayList<>();
        try{
            /*Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{ call LISTAR_PRESETRECETA() }");

            rs = cs.executeQuery();/*/
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,
                    DBManager.password);
            cs = con.prepareCall("{ call LISTAR_INGREDIENTES_X_NOMBRE(?) }");
            cs.setString("_nombre",nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.setIdIngrediente(rs.getInt("id_ingrediente"));
                ingrediente.setNombre(rs.getString("nombre"));
                ingrediente.setCantidad(rs.getDouble("cantidad"));
                ingrediente.setKcal(rs.getInt("kcal"));
                ingrediente.setGrasasSaturadas(rs.getBoolean("grasasSaturadas"));
                ingrediente.setAzucar(rs.getBoolean("azucar"));
                ingrediente.setSodio(rs.getBoolean("sodio"));
                ingrediente.setGrasasTrans(rs.getBoolean("grasasTrans"));
                
                ingredientes.add(ingrediente);
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
        return ingredientes;
        
    
    }

    @Override
    public ArrayList<Ingrediente> listarXPresetRecta(int idPreset) {
        ArrayList<Ingrediente> ingredientes = new ArrayList<>();
        try{
            /*Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{ call LISTAR_PRESETRECETA() }");

            rs = cs.executeQuery();/*/
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,
                    DBManager.password);
            cs = con.prepareCall("{ call LISTAR_INGREDIENTES_DE_PRESET_RECETA(?) }");
            cs.setInt("_id_Preset_Receta",idPreset);
            rs = cs.executeQuery();
            while(rs.next()){
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.setIdIngrediente(rs.getInt("i.id_ingrediente"));
                ingrediente.setNombre(rs.getString("i.nombre"));
                ingrediente.setCantidad(rs.getDouble("p.cantidad"));
                ingrediente.setKcal(rs.getInt("p.kcal"));
                ingrediente.setUnidad(rs.getString("i.unidad"));
                ingrediente.setDetalle(rs.getString("p.detalle"));
                ingredientes.add(ingrediente);
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
        return ingredientes;
    }

    @Override
    public ArrayList<Ingrediente> listarXPreferenciaYAlumno(int idAl, int pref) {
        ArrayList<Ingrediente> ingredientes = new ArrayList<>();
        try{
            /*Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{ call LISTAR_PRESETRECETA() }");

            rs = cs.executeQuery();/*/
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,
                    DBManager.password);
            cs = con.prepareCall("{ call LISTAR_INGREDIENTES_POR_PREF_Y_ALUMNO(?,?) }");
            cs.setInt("_fid_alumno",idAl);
            cs.setInt("_pref",pref);
            rs = cs.executeQuery();
            while(rs.next()){
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.setIdIngrediente(rs.getInt("id_ingrediente"));
                ingrediente.setNombre(rs.getString("nombre"));
                ingrediente.setCantidad(rs.getDouble("cantidad"));
                ingrediente.setKcal(rs.getInt("kcal"));
                ingrediente.setGrasasSaturadas(rs.getBoolean("grasasSaturadas"));
                ingrediente.setAzucar(rs.getBoolean("azucar"));
                ingrediente.setSodio(rs.getBoolean("sodio"));
                ingrediente.setGrasasTrans(rs.getBoolean("grasasTrans"));
                ingredientes.add(ingrediente);
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
        return ingredientes;
    }

    @Override
    public ArrayList<Ingrediente> listarXNoClasificados(int idAl) {
        ArrayList<Ingrediente> ingredientes = new ArrayList<>();
        try{
            /*Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{ call LISTAR_PRESETRECETA() }");

            rs = cs.executeQuery();/*/
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,
                    DBManager.password);
            cs = con.prepareCall("{ call LISTAR_INGREDIENTES_NO_CLASIFICADOS(?) }");
            cs.setInt("_fid_alumno",idAl);
            rs = cs.executeQuery();
            while(rs.next()){
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.setIdIngrediente(rs.getInt("id_ingrediente"));
                ingrediente.setNombre(rs.getString("nombre"));
                ingrediente.setCantidad(rs.getDouble("cantidad"));
                ingrediente.setKcal(rs.getInt("kcal"));
                ingrediente.setGrasasSaturadas(rs.getBoolean("grasasSaturadas"));
                ingrediente.setAzucar(rs.getBoolean("azucar"));
                ingrediente.setSodio(rs.getBoolean("sodio"));
                ingrediente.setGrasasTrans(rs.getBoolean("grasasTrans"));
                ingredientes.add(ingrediente);
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
        return ingredientes;
    }
        
}
