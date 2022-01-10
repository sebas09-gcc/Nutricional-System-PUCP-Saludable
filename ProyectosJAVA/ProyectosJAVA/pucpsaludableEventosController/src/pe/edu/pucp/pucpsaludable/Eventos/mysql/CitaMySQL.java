/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.Eventos.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.Timestamp;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.Eventos.config.DBManager;
import pe.edu.pucp.pucpsaludable.Eventos.dao.CitaDAO;
import pe.edu.pucp.pucpsaludable.eventos.model.Cita;

/**
 *
 * @author sebas
 */
public class CitaMySQL implements CitaDAO{
    Connection con;//pa la cnexion
    Statement st;//pa mandar lineas de ejec
    ResultSet rs;
    PreparedStatement ps;
    CallableStatement cs; //para llamar procesos almacenados en sql

    @Override
    public int insertar(Cita cita) {
        int resultado=0;
        try{
            Timestamp tsfhat = new Timestamp(cita.getFechaHoraAtencion().getTime());
            Class.forName("com.mysql.cj.jdbc.Driver");//registrar driver de conexion
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs=con.prepareCall("{call INSERTAR_CITA(?,?,?,?,?,?)}");//8 parametros
            //idCita idAl idEsp estado fechaHoraReg fechHoraAt diagnostico referencia
            //intAUTOGENERADO int int int Date Date string string
            cs.registerOutParameter("_id_cita", java.sql.Types.INTEGER);
            cs.setInt("_fid_alumno",cita.getFid_alumno());
            cs.setInt("_fid_especialista",cita.getFid_especialista());
            cs.setTimestamp("_fechaHoraAtencion", tsfhat);
            cs.setString("_diagnostico", cita.getDiagnostico());
            cs.setString("_referencia", cita.getReferencia());
            cs.executeUpdate();
            cita.setId_cita(cs.getInt("_id_cita"));
            resultado = cs.getInt("_id_cita");
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            //cierra la conexion
        }
        return resultado;
    }

    @Override
    public int modificar(Cita cita) {
        int resultado = 0;
        try{
            Timestamp tsfhat = new Timestamp(cita.getFechaHoraAtencion().getTime());
            Timestamp tsfhreg = new Timestamp(cita.getFechaHoraRegistro().getTime());
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call "+
                    "MODIFICAR_CITA(?,?,?,?,?,?,?,?,?)}");
            cs.setInt("_id_cita",cita.getId_cita());
            cs.setInt("_fid_alumno",cita.getFid_alumno());
            cs.setInt("_fid_especialista",cita.getFid_especialista());
            cs.setInt("_estado",cita.getEstado());
            cs.setTimestamp("_fechaHoraRegistro", tsfhreg);
            cs.setTimestamp("_fechaHoraAtencion", tsfhat);
            cs.setString("_diagnostico", cita.getDiagnostico());
            cs.setString("_referencia", cita.getReferencia());
            cs.setInt("_atencion",cita.getAtencion());
            
            cs.executeUpdate();
             
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
    public int eliminar(int id_cita) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call "+
                    "ELIMINAR_CITA(?)}");
            cs.setInt("_id_cita", id_cita);
            resultado = cs.executeUpdate();
            
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
    public ArrayList<Cita> listarTodos() {
        int resultado = 0;
        String instruccion;        
        ArrayList<Cita> citas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA()}");
            rs = cs.executeQuery();
            
            while(rs.next()){
                Cita cit = new Cita();
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                cit.setId_cita(rs.getInt("id_cita"));
                cit.setFid_alumno(rs.getInt("fid_alumno"));
                cit.setFid_especialista(rs.getInt("fid_especialistaSalud"));
                cit.setEstado(rs.getInt("estado"));
                cit.setFechaHoraRegistro(rs.getTimestamp("fechaHoraRegistro"));
                cit.setFechaHoraAtencion(rs.getTimestamp("fechaHoraAtencion"));
                cit.setDiagnostico(rs.getString("diagnostico"));
                cit.setReferencia(rs.getString("referencia"));       
                cit.setAtencion(rs.getInt("atencion"));
                citas.add(cit);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return citas;
    }
    
    public ArrayList<CitaRep> consultarCitas() {
        int resultado = 0;
        String instruccion;        
        ArrayList<CitaRep> citas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA()}");
            rs = cs.executeQuery();
            
            while(rs.next()){
                CitaRep cit = new CitaRep();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                cit.setId_cita(rs.getInt("id_cita"));
                cit.setNomAlumno(rs.getString("ua.nombres"));
                cit.setApAlumno(rs.getString("ua.apellidos"));   
                cit.setNomEspecialista(rs.getString("ue.nombres"));
                cit.setApEspecialista(rs.getString("ue.apellidos"));
                //cit.setEstado(rs.getInt("estado"));
                cit.setFechaHoraRegistro(rs.getTimestamp("fechaHoraRegistro"));
                cit.setFechaHoraAtencion(rs.getTimestamp("fechaHoraAtencion"));
                cit.setDiagnostico(rs.getString("diagnostico"));
                cit.setReferencia(rs.getString("referencia"));       
                cit.setAtencion(rs.getInt("atencion"));
                citas.add(cit);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return citas;
    }

    @Override
    public ArrayList<Cita> listarCitaProgramadaPorNombreCodigo(String nombre) {      
        ArrayList<Cita> citas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA_PROGRAMADA_X_NOMBRECODIGO(?)}");
            cs.setString("_nombre",nombre);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Cita cit = new Cita();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                cit.setId_cita(rs.getInt("id_cita"));
                cit.setFid_alumno(rs.getInt("fid_alumno"));
                cit.setFid_especialista(rs.getInt("fid_especialistaSalud"));
                cit.setEstado(rs.getInt("estado"));
                cit.setFechaHoraRegistro(rs.getTimestamp("fechaHoraRegistro"));
                cit.setFechaHoraAtencion(rs.getTimestamp("fechaHoraAtencion"));
                cit.setDiagnostico(rs.getString("diagnostico"));
                cit.setReferencia(rs.getString("referencia"));       
                cit.setAtencion(rs.getInt("atencion"));
                citas.add(cit);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return citas;
    }

    @Override
    public ArrayList<Cita> listarCitaHistoricaPorNombreCodigo(String nombre) {
        ArrayList<Cita> citas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA_HISTORICA_X_NOMBRECODIGO(?)}");
            cs.setString("_nombre",nombre);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Cita cit = new Cita();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                cit.setId_cita(rs.getInt("id_cita"));
                cit.setFid_alumno(rs.getInt("fid_alumno"));
                cit.setFid_especialista(rs.getInt("fid_especialistaSalud"));
                cit.setEstado(rs.getInt("estado"));
                cit.setFechaHoraRegistro(rs.getTimestamp("fechaHoraRegistro"));
                cit.setFechaHoraAtencion(rs.getTimestamp("fechaHoraAtencion"));
                cit.setDiagnostico(rs.getString("diagnostico"));
                cit.setReferencia(rs.getString("referencia"));       
                cit.setAtencion(rs.getInt("atencion"));
                citas.add(cit);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return citas;
    }

    @Override
    public ArrayList<Cita> listarCitaProgramadaNutricionistaPorNombre(String nombre) {
        ArrayList<Cita> citas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA_PROGRAMADA_NUTRICIONISTA_X_NOMBRE(?)}");
            cs.setString("_nombre",nombre);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Cita cit = new Cita();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                cit.setId_cita(rs.getInt("id_cita"));
                cit.setFid_alumno(rs.getInt("fid_alumno"));
                cit.setFid_especialista(rs.getInt("fid_especialistaSalud"));
                cit.setEstado(rs.getInt("estado"));
                cit.setFechaHoraRegistro(rs.getTimestamp("fechaHoraRegistro"));
                cit.setFechaHoraAtencion(rs.getTimestamp("fechaHoraAtencion"));
                cit.setDiagnostico(rs.getString("diagnostico"));
                cit.setReferencia(rs.getString("referencia"));       
                cit.setAtencion(rs.getInt("atencion"));
                citas.add(cit);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return citas;
    }

    @Override
    public ArrayList<Cita> listarCitaHistoricaNutricionistaPorNombre(String nombre) {
        ArrayList<Cita> citas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA_HISTORICA_NUTRICIONISTA_X_NOMBRE(?)}");
            cs.setString("_nombre",nombre);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Cita cit = new Cita();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                cit.setId_cita(rs.getInt("id_cita"));
                cit.setFid_alumno(rs.getInt("fid_alumno"));
                cit.setFid_especialista(rs.getInt("fid_especialistaSalud"));
                cit.setEstado(rs.getInt("estado"));
                cit.setFechaHoraRegistro(rs.getTimestamp("fechaHoraRegistro"));
                cit.setFechaHoraAtencion(rs.getTimestamp("fechaHoraAtencion"));
                cit.setDiagnostico(rs.getString("diagnostico"));
                cit.setReferencia(rs.getString("referencia"));       
                cit.setAtencion(rs.getInt("atencion"));
                citas.add(cit);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return citas;
    }

    @Override
    public ArrayList<Cita> listarCitaProgramadaPorId(int id) {
        ArrayList<Cita> citas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA_PROGRAMADA_X_ID(?)}");
            cs.setInt("_id",id);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Cita cit = new Cita();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                cit.setId_cita(rs.getInt("id_cita"));
                cit.setFid_alumno(rs.getInt("fid_alumno"));
                cit.setFid_especialista(rs.getInt("fid_especialistaSalud"));
                cit.setEstado(rs.getInt("estado"));
                cit.setFechaHoraRegistro(rs.getTimestamp("fechaHoraRegistro"));
                cit.setFechaHoraAtencion(rs.getTimestamp("fechaHoraAtencion"));
                cit.setDiagnostico(rs.getString("diagnostico"));
                cit.setReferencia(rs.getString("referencia"));       
                cit.setAtencion(rs.getInt("atencion"));
                citas.add(cit);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return citas;
    }

    @Override
    public ArrayList<Cita> listarCitaHistoricaPorId(int id) {
        ArrayList<Cita> citas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA_HISTORICA_X_ID(?)}");
            cs.setInt("_id",id);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Cita cit = new Cita();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                cit.setId_cita(rs.getInt("id_cita"));
                cit.setFid_alumno(rs.getInt("fid_alumno"));
                cit.setFid_especialista(rs.getInt("fid_especialistaSalud"));
                cit.setEstado(rs.getInt("estado"));
                cit.setFechaHoraRegistro(rs.getTimestamp("fechaHoraRegistro"));
                cit.setFechaHoraAtencion(rs.getTimestamp("fechaHoraAtencion"));
                cit.setDiagnostico(rs.getString("diagnostico"));
                cit.setReferencia(rs.getString("referencia"));       
                cit.setAtencion(rs.getInt("atencion"));
                citas.add(cit);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return citas;
    }

    @Override
    public ArrayList<Cita> listarCitaProgramadaNutricionistaPorId(int id) {
        ArrayList<Cita> citas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA_PROGRAMADA_NUTRICIONISTA_X_ID(?)}");
            cs.setInt("_id",id);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Cita cit = new Cita();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                cit.setId_cita(rs.getInt("id_cita"));
                cit.setFid_alumno(rs.getInt("fid_alumno"));
                cit.setFid_especialista(rs.getInt("fid_especialistaSalud"));
                cit.setEstado(rs.getInt("estado"));
                cit.setFechaHoraRegistro(rs.getTimestamp("fechaHoraRegistro"));
                cit.setFechaHoraAtencion(rs.getTimestamp("fechaHoraAtencion"));
                cit.setDiagnostico(rs.getString("diagnostico"));
                cit.setReferencia(rs.getString("referencia"));       
                cit.setAtencion(rs.getInt("atencion"));
                citas.add(cit);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return citas;
    }

    @Override
    public ArrayList<Cita> listarCitaHistoricaNutricionistaPorId(int id) {
        ArrayList<Cita> citas = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITA_HISTORICA_NUTRICIONISTA_X_ID(?)}");
            cs.setInt("_id",id);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Cita cit = new Cita();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                cit.setId_cita(rs.getInt("id_cita"));
                cit.setFid_alumno(rs.getInt("fid_alumno"));
                cit.setFid_especialista(rs.getInt("fid_especialistaSalud"));
                cit.setEstado(rs.getInt("estado"));
                cit.setFechaHoraRegistro(rs.getTimestamp("fechaHoraRegistro"));
                cit.setFechaHoraAtencion(rs.getTimestamp("fechaHoraAtencion"));
                cit.setDiagnostico(rs.getString("diagnostico"));
                cit.setReferencia(rs.getString("referencia"));       
                cit.setAtencion(rs.getInt("atencion"));
                citas.add(cit);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return citas;
    }

    @Override
    public int cancelarCitaXAlumnoOEspecialista(int idcita, int idAlum, int idEsp) {
        int resultado=0;
        try{
            
            Class.forName("com.mysql.cj.jdbc.Driver");//registrar driver de conexion
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs=con.prepareCall("{call CANCELAR_CITA_X_ALUMNO_O_ESPECIALISTA(?,?,?)}");
            cs.setInt("_id_cita",idcita);
            cs.setInt("_fid_alumno",idAlum);
            cs.setInt("_fid_especialistaSalud",idEsp);

            cs.executeUpdate();
            resultado=1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            //cierra la conexion
        }
        return resultado;
    }
    
    @Override
    public int atenderCitaXAlumnoOEspecialista(int idcita, int idAlum, int idEsp) {
        int resultado=0;
        try{
            
            Class.forName("com.mysql.cj.jdbc.Driver");//registrar driver de conexion
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs=con.prepareCall("{call ATENDER_CITA_X_ALUMNO_O_ESPECIALISTA(?,?,?)}");
            cs.setInt("_id_cita",idcita);
            cs.setInt("_fid_alumno",idAlum);
            cs.setInt("_fid_especialistaSalud",idEsp);

            cs.executeUpdate();
            resultado=1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            //cierra la conexion
        }
        return resultado;
    }
    
}
