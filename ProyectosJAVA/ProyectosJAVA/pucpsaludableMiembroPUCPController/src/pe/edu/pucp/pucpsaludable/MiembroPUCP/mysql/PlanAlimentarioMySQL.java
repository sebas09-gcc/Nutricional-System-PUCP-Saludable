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
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.PlanAlimentarioDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alumno;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.PlanAlimentario;
import pe.edu.pucp.pucpsaludable.receta.model.PresetReceta;

/**
 *
 * @author Oleg
 */
public class PlanAlimentarioMySQL implements PlanAlimentarioDAO{
    //esto se importa siempre
    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    @Override
    public int insertar(PlanAlimentario planAlimentario)
    {
        int resultado = 0; 
        try{
        
            //establecemos la coneccion
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            //cargamos la instruccion a la conexion
            cs = con.prepareCall("{call INSERTAR_PLANALIMENTARIO(?,?,?,?,?)}");
            cs.setInt("_fid_alumno", planAlimentario.getAlumno().getId_usuario());
            cs.setInt("_fid_presetReceta", planAlimentario.getComida().getIdPresetReceta());
            cs.setInt("_fid_nutricionista", planAlimentario.getFid_Nutricionista());
            cs.setInt("_tipoComida", planAlimentario.getComida().getTipo());
            cs.setInt("_dia", planAlimentario.getDia());
            rs = cs.executeQuery();            
            resultado = 1;
        
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
    public int modificarPlanAlumno(ArrayList<PlanAlimentario> planAlimentario) {
        int resultado = 0;
        
        for(PlanAlimentario pl : planAlimentario){
            //PlanAlimentario pl=new PlanAlimentario();
            
            
            if(modificar(pl)==0)return resultado;
        }
        resultado=1;
        return resultado;
    }

    @Override
    public void eliminar(int id_planAlimentario) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<PlanAlimentario> listarTodos() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<PlanAlimentario> listarPorUnAlumno(int idAlumno) {
        // NOTA: Definir que criterio se utiolizara para registar, por fecha mas reciente o estado
        int resultado = 0;
        String instruccion;
        ArrayList<PlanAlimentario> planAlimentario = new ArrayList<>();
        
        try{
        
            //establecemos la coneccion
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            //cargamos la instruccion a la conexion
            cs = con.prepareCall("{call LISTAR_PLAN_ALIMENTICIO_ALUMNO(?)}");
            cs.setInt("_fid_alumno", idAlumno);
            rs = cs.executeQuery();
            
            while(rs.next()){
                PlanAlimentario a = new PlanAlimentario();
                PresetReceta comida = new PresetReceta();
                comida.setIdPresetReceta(rs.getInt("id_presetReceta"));
                comida.setKcal(rs.getDouble("kcalTotales"));
                comida.setNombre(rs.getString("nombre"));
                a.setComida(comida);
                a.setFid_Nutricionista(rs.getInt("fid_nutricionista"));
                a.setFecha(rs.getDate("fecha"));// posible error
                a.setTipoComida(rs.getInt("tipoComida"));
                a.setDia(rs.getInt("dia"));
                planAlimentario.add(a);
            }
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return planAlimentario;  
    }

    @Override
    public ArrayList<PresetReceta> listarPorUnAlumnoPreset(int idAlumno) {
        int resultado = 0;
        String instruccion;
        ArrayList<PresetReceta> presets = new ArrayList<>();
        
        try{
        
            //establecemos la coneccion
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            //cargamos la instruccion a la conexion
            cs = con.prepareCall("{call LISTAR_PLAN_ALIMENTICIO_ALUMNO(?)}");
            cs.setInt("_fid_alumno", idAlumno);
            rs = cs.executeQuery();
            
            while(rs.next()){
                
                PresetReceta comida = new PresetReceta();
                comida.setIdPresetReceta(rs.getInt("id_presetReceta"));
                comida.setKcal(rs.getDouble("kcalTotales"));
                comida.setNombre(rs.getString("nombre"));
                comida.setTipo(rs.getInt("tipoComida"));
                comida.setEstado(rs.getInt("dia"));
                presets.add(comida);
            }
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        
        return presets; 
    }

    @Override
    public int eliminarPlanAlimentarioxAlumno(int idAlumno) {
        int resultado = 0;
        try{
        
            //establecemos la coneccion
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            //cargamos la instruccion a la conexion
            cs = con.prepareCall("{call ELIMINAR_PLANES_ALIMENTARIOS_X_ALUMNO(?)}");
            cs.setInt("_fid_alumno", idAlumno);
            cs.executeQuery();
            
            resultado=1;
        
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
    public int modificar(PlanAlimentario planAlimentario) {
        int resultado = 0; 
        try{
        
            //establecemos la coneccion
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            //cargamos la instruccion a la conexion
            cs = con.prepareCall("{call MODIFICAR_PLANALIMENTARIO(?,?,?,?,?)}");
            cs.setInt("_fid_alumno", planAlimentario.getAlumno().getId_usuario());
            cs.setInt("_fid_presetReceta", planAlimentario.getComida().getIdPresetReceta());
            cs.setInt("_fid_nutricionista", planAlimentario.getFid_Nutricionista());
            cs.setInt("_tipoComida", planAlimentario.getComida().getTipo());
            cs.setInt("_dia", planAlimentario.getDia());
            rs = cs.executeQuery();
            
            resultado = 1;
        
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
    public int insertarPlanAlumno(ArrayList<PlanAlimentario> plist)
    {
        eliminarPlanAlimentarioxAlumno(plist.get(0).getAlumno().getId_usuario());
        int resultado = 0;
        for (PlanAlimentario pa : plist)
        {
            insertar(pa);
        }
        resultado = 1;
        return resultado;
    }

    @Override
    public ArrayList<PresetReceta> generarPlan(int idAlumno,int limite,int tipoC) {
        ArrayList<PresetReceta> presets = new ArrayList<>();
        try{
        
            //establecemos la coneccion
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            //cargamos la instruccion a la conexion
            cs = con.prepareCall("{call GENERAR_PLAN_ALIMETARIO(?,?,?)}");
            cs.setInt("_id_usuario", idAlumno);
            cs.setInt("_limite", limite);
            cs.setInt("_tipo_comida", tipoC);
            rs = cs.executeQuery();
            int i = 0;
            while(rs.next())
            {
                PresetReceta comida = new PresetReceta();
                comida.setIdPresetReceta(rs.getInt("id_presetReceta"));
                comida.setKcal(rs.getDouble("kcalTotales"));
                comida.setNombre(rs.getString("nombre"));
                comida.setTipo(rs.getInt("tipo"));
                comida.setEstado(i);
                comida.setTipo(tipoC);
                presets.add(comida);
                i++;
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{ //siempre se va a cerrar la conexion y el statement porque esta dentro de finally
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return presets;
    }
    
}
