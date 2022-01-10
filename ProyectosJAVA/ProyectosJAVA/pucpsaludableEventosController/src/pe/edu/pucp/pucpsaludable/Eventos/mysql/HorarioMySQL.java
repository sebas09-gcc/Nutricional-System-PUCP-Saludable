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
import pe.edu.pucp.pucpsaludable.Eventos.dao.HorarioDAO;
import pe.edu.pucp.pucpsaludable.eventos.model.Horario;

/**
 *
 * @author sebas
 */
public class HorarioMySQL implements HorarioDAO{
    Connection con;
    Statement st;
    ResultSet rs;
    PreparedStatement ps;
    CallableStatement cs;
    CallableStatement cscond;

    @Override
    public int insertar(Horario horar) {
        //horario entra con el id de especialista o de taller en 0
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");//registrar driver de conexion
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs=con.prepareCall("{call INSERTAR_HORARIO(?,?,?,?,?,?,?)}");//7 parametros
            //idHorario idTaller fidEspec horarioIni horaFin diaSemana fechaHoraReg estado
            //intAUTOGENERADO int int Date Date int Date int
            cs.registerOutParameter("_id_horario", java.sql.Types.INTEGER);            
            cs.setInt("_fid_especialistaSalud",horar.getFid_especialista());
            
            Timestamp tsIni = new Timestamp(horar.getHorarioInicio().getTime());
            Timestamp tsFin = new Timestamp(horar.getHoraFin().getTime());
            
            cs.setTimestamp("_horaInicio", tsIni);
            cs.setTimestamp("_horaFin", tsFin);
            cs.setInt("_diaSemana", horar.getDiaSemana());
            cs.setDate("_fechaHoraRegistro", new java.sql.Date(horar.getFechaHoraRegistro().getTime()));
            cs.setInt("_estado", 1);
            
            cs.executeUpdate();
            horar.setId_horario(cs.getInt("_id_horario"));
            
            resultado = 1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());};
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());};
        }
        return resultado;
    }
//INSERTAR COMPLETO
    @Override
    public int modificar(Horario horar) {
        int resultado = 0;
        try{
            //registramos el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //establecemos la coneccion
            //para ello llamaremos a DBManager,java
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call "+
                    "MODIFICAR_ESPECIALISTA(?,?,?,?,?,?,?,?)}");
            
            /*
            DELIMITER $
            CREATE PROCEDURE `MODIFICAR_HORARIO`(
                IN _id_horario INT,
                IN _fid_taller INT,
                IN _fid_especialista INT,
                IN _horaInicio DATE,
                IN _horaFin DATE,
                IN _diaSemana INT,
                IN _fechaHoraRegistro DATE,
                IN _estado TINYINT
            )
            BEGIN
                UPDATE horario
                    SET fid_taller= _fid_taller,
                    fid_especialistaSalud = _fid_especialista,
                    horaInicio = _horaInicio,
                    horaFin = _horaFin,
                    diaSemana = _diaSemana,
                    fechaHoraRegistro = _fechaHoraRegistro,
                    estado = _estado
                    WHERE id_horario = _id_horario;       
            END$           
            */
            //idHorario idTaller fidEspec horarioIni horaFin diaSemana fechaHoraReg estado
            //intAUTOGENERADO int int Date Date int Date int
            cs.setInt("_id_horario", horar.getId_horario());
            cs.setInt("_fid_taller", horar.getId_taller());
            cs.setInt("_fid_especialista", horar.getFid_especialista());
            cs.setDate("_horaInicio", 
                new java.sql.Date(horar.getHorarioInicio().getTime()));
            cs.setDate("_horaFin",
                new java.sql.Date(horar.getHoraFin().getTime()));
            cs.setInt("_diaSemana", horar.getDiaSemana());
            cs.setDate("_fechaHoraReg", 
                new java.sql.Date(horar.getFechaHoraRegistro().getTime()));
            cs.setInt("_estado", horar.getEstado());
            cs.executeUpdate();
            
            //EJECUTAMOS EL PREPARED STATEMENT 
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
//MODIFICAR LISTO
    @Override
    public int eliminarHorariosAnteriores(int id_espec) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call "+
                    "ELIMINAR_HORARIOS_ANTERIORES(?)}");
            /*
            CREATE PROCEDURE ELIMINAR_HORARIOS_ANTERIORES(
                IN _id_espec INT
            )
            BEGIN
                UPDATE horario SET estado = 0 WHERE _id_espec = id_especialistaSalud;
            END
            */
            cs.setInt("_id_espec", id_espec);
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
    public ArrayList<Horario> listarTodos() {
        int resultado = 0;
        String instruccion;        
        ArrayList<Horario> horarios = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call LISTAR_HORARIO()}");
            
            /*
            CREATE PROCEDURE `LISTAR_HORARIO`()
            BEGIN
                SELECT * FROM horario h ON
                u.estado = 1;
            END
            */
            rs = cs.executeQuery();
            
            while(rs.next()){
                Horario hor = new Horario();
                //int int int adate Date int date int
                hor.setId_horario(rs.getInt("id_horario"));
                hor.setId_taller(rs.getInt("fid_taller"));
                hor.setFid_especialista(rs.getInt("id_especialistaSalud"));
                hor.setHorarioInicio(rs.getDate("horaInicio"));
                hor.setHoraFin(rs.getDate("horaFin"));
                hor.setDiaSemana(rs.getInt("diaSemana"));
                hor.setFechaHoraRegistro(rs.getDate("fechaHoraRegistro"));
                hor.setEstado(rs.getInt("estado"));
                
                horarios.add(hor);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return horarios;
    }

    @Override
    public ArrayList<Horario> listarPorEspec(int id_espec) {
        int resultado = 0;
        String instruccion;        
        ArrayList<Horario> horarios = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            
            cs = con.prepareCall("{call LISTAR_HORARIO_ESPEC_SALUD(?)}");
            
            /*
            CREATE PROCEDURE LISTAR_HORARIO_ESPEC_SALUD(
                IN _id_espec int
            )
            BEGIN
                SELECT * FROM horario h 
            WHERE h.estado = 1 AND _id_espec = h.fid_especialistaSalud;
            END$
            */
            cs.setInt("_id_espec",id_espec);
            rs = cs.executeQuery();
            
            while(rs.next()){
                Horario hor = new Horario();
                //int int int adate Date int date int
                hor.setId_horario(rs.getInt("id_horario"));
                hor.setId_taller(0);
                hor.setFid_especialista(rs.getInt("fid_especialistaSalud"));
                hor.setHorarioInicio(rs.getTimestamp("horaInicio"));
                hor.setHoraFin(rs.getTimestamp("horaFin"));
                hor.setDiaSemana(rs.getInt("diaSemana"));
                hor.setFechaHoraRegistro(rs.getDate("fechaHoraRegistro"));
                hor.setEstado(rs.getInt("estado"));
                
                horarios.add(hor);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return horarios;
    }
    


    
    
    
}
