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
import java.sql.Timestamp;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.HorarioHabitualDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.HorarioHabitual;

/**
 *
 * @author sebas
 */
public class HorarioHabitualMySQL implements HorarioHabitualDAO{
    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    
    @Override
    public int insertar(HorarioHabitual horhab) {
        int resultado = 0;
        try{
            Timestamp tsDesp,tsAc,tsDesa,tsMeMa,tsCom,tsMer,tsCe;
            tsDesp=new Timestamp(horhab.getDespertarse().getTime());
            tsAc=new Timestamp(horhab.getAcostarse().getTime());
            tsDesa=new Timestamp(horhab.getDesayuno().getTime());
            tsMeMa=new Timestamp(horhab.getMediaManana().getTime());
            tsCom=new Timestamp(horhab.getComida().getTime());
            tsMer=new Timestamp(horhab.getMerienda().getTime());
            tsCe=new Timestamp(horhab.getCena().getTime());
            
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_HORARIO_HABITUAL(?,?,?,?,?,?,?,?)}");
            //cs.registerOutParameter("_id_alumno", java.sql.Types.INTEGER);
            cs.setInt("_fid_alumno", horhab.getFid_alumno());
            cs.setTimestamp("_despertarse",tsDesp);
            cs.setTimestamp("_acostarse",tsAc);
            cs.setTimestamp("_desayuno",tsDesa);
            cs.setTimestamp("_mediaManana",tsMeMa);
            cs.setTimestamp("_comida",tsCom);
            cs.setTimestamp("_merienda",tsMer);
            cs.setTimestamp("_cena",tsCe);
            
            cs.executeUpdate();
            //ahora, hemos obtenido el id autogenerado
            //horhab.setId_horasSueno(cs.getInt("_id_horas_sueno"));
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
    public HorarioHabitual adquirirHorarioHabitual(int id_alumno) {
        int resultado = 0;      
        //ArrayList<Cita> citas = new ArrayList<>();
        HorarioHabitual horhab = new HorarioHabitual();
        horhab.setFid_alumno(-1);
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call CONSULTAR_HORARIO_HABITUAL (?)}");
            cs.setInt("_fid_alumno", id_alumno);
            /*
            CREATE PROCEDURE `CONSULTAR_HORARIO_HABITUAL`(
                IN _fid_alumno INT
            )
            BEGIN
            SELECT * FROM horariohabitual hh
            WHERE _fid_alumno = hh.fid_alumno;
            END
            */
            rs = cs.executeQuery();
            
            while(rs.next()){
                //Cita cit = new Cita();
                
                //sacar campos con set
                //c.setId_usuario(rs.getInt("id_usuario"));
                //INSERT INTO horariohabitual(fid_alumno,despertarse,acostarse,desayuno,mediaManana,comida,merienda,cena)
                horhab.setFid_alumno(rs.getInt("fid_alumno"));
                horhab.setDespertarse(rs.getTimestamp("despertarse"));
                horhab.setAcostarse(rs.getTimestamp("acostarse"));
                horhab.setDesayuno(rs.getTimestamp("desayuno"));
                horhab.setMediaManana(rs.getTimestamp("mediaManana"));
                horhab.setComida(rs.getTimestamp("comida"));
                horhab.setMerienda(rs.getTimestamp("merienda"));
                horhab.setCena(rs.getTimestamp("cena"));
                
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return horhab;
    }

    @Override
    public int modificar(HorarioHabitual horhab) {
        int resultado = 0;
        try{
            Timestamp tsDesp,tsAc,tsDesa,tsMeMa,tsCom,tsMer,tsCe;
            tsDesp=new Timestamp(horhab.getDespertarse().getTime());
            tsAc=new Timestamp(horhab.getAcostarse().getTime());
            tsDesa=new Timestamp(horhab.getDesayuno().getTime());
            tsMeMa=new Timestamp(horhab.getMediaManana().getTime());
            tsCom=new Timestamp(horhab.getComida().getTime());
            tsMer=new Timestamp(horhab.getMerienda().getTime());
            tsCe=new Timestamp(horhab.getCena().getTime());
            //registramos el driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //establecemos la coneccion
            //para ello llamaremos a DBManager,java
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call "+
                    "MODIFICAR_HORARIO_HABITUAL(?,?,?,?,?,?,?,?)}");
            
            cs.setInt("_fid_alumno", horhab.getFid_alumno());
            cs.setTimestamp("_despertarse",tsDesp);
            cs.setTimestamp("_acostarse",tsAc);
            cs.setTimestamp("_desayuno",tsDesa);
            cs.setTimestamp("_mediaManana",tsMeMa);
            cs.setTimestamp("_comida",tsCom);
            cs.setTimestamp("_merienda",tsMer);
            cs.setTimestamp("_cena",tsCe);
            
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
}
