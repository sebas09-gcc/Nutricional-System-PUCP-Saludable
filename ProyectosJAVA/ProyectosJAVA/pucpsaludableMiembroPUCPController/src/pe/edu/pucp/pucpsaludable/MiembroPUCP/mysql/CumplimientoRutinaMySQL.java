
package pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.CumplimientoRutinaDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.CumplimientoRutina;


public class CumplimientoRutinaMySQL implements CumplimientoRutinaDAO {

    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    
    
    @Override
    public int insertarCumplimientoRutinaAlimentaria(CumplimientoRutina cumple) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_CUMPLIMIENTO_RUTINA_ALIMENTARIA(?,?,?,?,?,?)}");
            
            /*
            CREATE PROCEDURE `INSERTAR_CUMPLIMIENTO_RUTINA_ALIMENTARIA`(
            OUT _id_cumplimientoRutina int(10),
            IN _id_alumno INT,
            IN _fecha DATE,
            IN _cumplio TINYINT,
            IN _tipoRutina TINYINT,
            IN _tipoComida TINYINT,
            
            )
            BEGIN
                INSERT INTO cumplimientoRutina(fid_alumno,fecha,cumplio,tipoRutina, tipoComida, estado) 
                VALUES(_fid_alumno,_fecha,_cumplio, 0, _tipoComida, 1);
                SET _id_cumplimientoRutina = @@last_insert_id;
            END
            */
            
            cs.setInt("_fid_alumno", cumple.getFid_alumno());
            cs.setDate("_fecha",new java.sql.Date(cumple.getFecha().getTime()));
            cs.setInt("_cumplio", cumple.getCumplio());
            cs.setInt("_tipoRutina", 0);
            cs.setInt("_tipoComida", cumple.getTipoComida());            
            cs.executeUpdate();
            cumple.setId_cumplimientoRutina(cs.getInt("_id_cumplimientoRutina"));
            
            resultado = 1;
        
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;        
    }

    @Override
    public int modificarCumplimientoRutinaAlimentaria(CumplimientoRutina cumple) {
        
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call MODIFICAR_CUMPLIMIENTO_RUTINA_ALIMENTARIA(?,?)}");
            
            /*
            CREATE PROCEDURE `MODIFICAR_CUMPLIMIENTO_RUTINA_ALIMENTARIA`(
            IN _id_cumplimientoRutina int(10),            
            IN _fecha DATE, 
            IN _cumplio TINYINT
            )
            BEGIN
                
                UPDATE cumplimientoRutina
                    SET cumplio = _cumplio
                    WHERE id_cumplimientoRutina = _id_cumplimientoRutina AND
                    fecha = _fecha AND estado = 1;
                    
            END
            */
            
            cs.setInt("_id_cumplimientoRutina", cumple.getId_cumplimientoRutina());
//            cs.setDate("_fecha",new java.sql.Date(cumple.getFecha().getTime()));
            cs.setInt("_cumplio", cumple.getCumplio());           
            cs.executeUpdate();
            resultado = 1;
        
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;  
    }

    @Override
    public int eliminarCumplimientoRutinaAlimentaria(int idCumple) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<CumplimientoRutina> listarCumplimientoRutinaAlimentariaxAlumno(int id_alumno) {
        
        ArrayList<CumplimientoRutina> cumples = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CUMPLIMIENTO_RUTINA_ALIMENTARIA_X_IDALUMNO(?)}");
            cs.setInt("_id_alumno", id_alumno);
            cs.executeUpdate();            
                        
            rs = cs.executeQuery();
            
            while(rs.next()){
                CumplimientoRutina cum = new CumplimientoRutina();
                
                cum.setId_cumplimientoRutina(rs.getInt("id_cumplimientoRutina"));
                cum.setFid_alumno(rs.getInt("fid_alumno"));
                cum.setFid_taller(rs.getInt("Taller_id"));
                cum.setFecha(rs.getDate("fecha"));
                cum.setCumplio(rs.getInt("cumplio"));
                cum.setTipoRutina(rs.getInt("tipoRutina"));
                cum.setTipoComida(rs.getInt("tipoComida"));
                
                cumples.add(cum);
                
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return cumples;
    }

    @Override
    public ArrayList<CumplimientoRutina> listarCumplimientoRutinaAlimentariaxAlumnoyFecha(int id_alumno, Date fecha) {
        
        ArrayList<CumplimientoRutina> cumples = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CUMPLIMIENTO_RUTINA_ALIMENTARIA_X_IDALUMNO_FECHA(?,?)}");
            cs.setInt("_id_alumno", id_alumno);
            cs.setDate("_fecha",new java.sql.Date(fecha.getTime()));
            cs.executeUpdate();            
                        
            rs = cs.executeQuery();
            
            while(rs.next()){
                CumplimientoRutina cum = new CumplimientoRutina();
                
                cum.setId_cumplimientoRutina(rs.getInt("id_cumplimientoRutina"));
                cum.setFid_alumno(rs.getInt("fid_alumno"));
                cum.setFid_taller(rs.getInt("Taller_id"));
                cum.setFecha(rs.getDate("fecha"));
                cum.setCumplio(rs.getInt("cumplio"));
                cum.setTipoRutina(rs.getInt("tipoRutina"));
                cum.setTipoComida(rs.getInt("tipoComida"));
                
                cumples.add(cum);
                
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return cumples;
    }    
    
    @Override
    public ArrayList<CumplimientoRutina>listarPlanAlimentarioNombreRecetasxAlumnoyFecha(int id_alumno, Date fecha) {
        
        ArrayList<CumplimientoRutina> recetas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_PLAN_ALIMENTARIO_NOMBRERECETAS_PORIDYFECHA(?,?)}");
            cs.setInt("_id_alumno", id_alumno);
            cs.setDate("_fecha",new java.sql.Date(fecha.getTime()));
            cs.executeUpdate();            
                        
            rs = cs.executeQuery();
            
            while(rs.next()){
                CumplimientoRutina re = new CumplimientoRutina();
                
                re.setFecha(rs.getDate("fecha"));
                re.setFid_alumno(rs.getInt("fid_alumno"));
                re.setTipoComida(rs.getInt("tipoComida"));                
                re.setCumplio(rs.getInt("dia"));
                re.setNombreReceta(rs.getString("nombre"));         
                recetas.add(re);
                
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return recetas;    
        
    }
    
    
    
}
