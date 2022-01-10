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
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.IndicadorSaludDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.IndicadorSalud;

/**
 *
 * @author sebas
 */
public class IndicadorSaludMySQL implements IndicadorSaludDAO{

    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    
    @Override
    public int insertar(IndicadorSalud indis) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            

            cs = con.prepareCall("{call INSERTAR_INDICADOR_SALUD(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");//30
            
            //ver atributos salida entrada
            
            //preparamos el callable statement
            cs.setInt("_fid_alumno", indis.getFid_alumno());
            cs.setBoolean("_cafe", indis.isCafe());
            cs.setBoolean("_alcohol", indis.isAlcohol());
            cs.setBoolean("_tabaco", indis.isTabaco());
            cs.setBoolean("_laxantes", indis.isLaxantes());
            cs.setBoolean("_diureticos", indis.isDiureticos());
            cs.setBoolean("_antiacidos", indis.isAntiacidos());
            cs.setBoolean("_analgesicos", indis.isAnalgesicos());
            cs.setBoolean("_anticonceptivos_orales", indis.isAnticonceptivosOrales());
            cs.setBoolean("_terapia_hormonal", indis.isTerapiaHormonal());
            cs.setBoolean("_diarrea", indis.isDiarrea());
            cs.setBoolean("_celiaquia", indis.isCeliaquia());
            cs.setBoolean("_estrenimiento", indis.isEstrenimiento());
            cs.setBoolean("_gastritis", indis.isGastritis());
            cs.setBoolean("_ulcera", indis.isUlcera());
            cs.setBoolean("_nausea", indis.isNausea());
            cs.setBoolean("_pirosis", indis.isPirosis());
            cs.setBoolean("_vomito", indis.isVomito());
            cs.setBoolean("_colitis", indis.isColitis());
            cs.setBoolean("_dentadura", indis.isDentadura());
            cs.setBoolean("_sensibilidad_dental", indis.isSensibilidadDental());
            cs.setBoolean("_embarazo", indis.isEmbarazo());
            cs.setBoolean("_climaterio", indis.isClimaterio());
            cs.setString("_cirugias_previas", indis.getCirugiasPrevias());
            cs.setBoolean("_aFObesidad", indis.isaFObesidad());
            cs.setBoolean("_aFDiabetes", indis.isaFDiabetes());
            cs.setBoolean("_aFHTA", indis.isaFHTA());
            cs.setBoolean("_aFCancer", indis.isCafe());
            cs.setBoolean("_aFHipercolesterolemia", indis.isaFHipercolesterolemia());
            cs.setBoolean("_aFHipertrigliceridemia", indis.isaFHipertrigliceridemia());
            cs.setString("_alergiasMed", indis.getAlergiasMed());
            
            cs.executeUpdate();
            
            //ahora, hemos obtenido el id autogenerado
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
    public int modificar(IndicadorSalud indis) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            

            cs = con.prepareCall("{call MODIFICAR_INDICADOR_SALUD(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)}");//30
            
            //ver atributos salida entrada
            
            //preparamos el callable statement
            cs.setInt("_fid_alumno", indis.getFid_alumno());
            cs.setBoolean("_cafe", indis.isCafe());
            cs.setBoolean("_alcohol", indis.isAlcohol());
            cs.setBoolean("_tabaco", indis.isTabaco());
            cs.setBoolean("_laxantes", indis.isLaxantes());
            cs.setBoolean("_diureticos", indis.isDiureticos());
            cs.setBoolean("_antiacidos", indis.isAntiacidos());
            cs.setBoolean("_analgesicos", indis.isAnalgesicos());
            cs.setBoolean("_anticonceptivos_orales", indis.isAnticonceptivosOrales());
            cs.setBoolean("_terapia_hormonal", indis.isTerapiaHormonal());
            cs.setBoolean("_diarrea", indis.isDiarrea());
            cs.setBoolean("_celiaquia", indis.isCeliaquia());
            cs.setBoolean("_estrenimiento", indis.isEstrenimiento());
            cs.setBoolean("_gastritis", indis.isGastritis());
            cs.setBoolean("_ulcera", indis.isUlcera());
            cs.setBoolean("_nausea", indis.isNausea());
            cs.setBoolean("_pirosis", indis.isPirosis());
            cs.setBoolean("_vomito", indis.isVomito());
            cs.setBoolean("_colitis", indis.isColitis());
            cs.setBoolean("_dentadura", indis.isDentadura());
            cs.setBoolean("_sensibilidad_dental", indis.isSensibilidadDental());
            cs.setBoolean("_embarazo", indis.isEmbarazo());
            cs.setBoolean("_climaterio", indis.isClimaterio());
            cs.setString("_cirugias_previas", indis.getCirugiasPrevias());
            cs.setBoolean("_aFObesidad", indis.isaFObesidad());
            cs.setBoolean("_aFDiabetes", indis.isaFDiabetes());
            cs.setBoolean("_aFHTA", indis.isaFHTA());
            cs.setBoolean("_aFCancer", indis.isCafe());
            cs.setBoolean("_aFHipercolesterolemia", indis.isaFHipercolesterolemia());
            cs.setBoolean("_aFHipertrigliceridemia", indis.isaFHipertrigliceridemia());
            cs.setString("_alergiasMed", indis.getAlergiasMed());
            
            cs.executeUpdate();
            
            //ahora, hemos obtenido el id autogenerado
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
    public IndicadorSalud adquirir(int id_alumno) {
        IndicadorSalud inds = new IndicadorSalud();
        inds.setFid_alumno(-1);
        ArrayList<IndicadorSalud> indicadores = new ArrayList<>();
         try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url,DBManager.user,DBManager.password);
            cs = con.prepareCall("{call CONSULTAR_INDICADOR_SALUD(?)}");
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
                inds.setFid_alumno(rs.getInt("fid_alumno"));
                inds.setCafe(rs.getBoolean("cafe"));
                inds.setAlcohol(rs.getBoolean("alcohol"));
                inds.setTabaco(rs.getBoolean("tabaco"));
                inds.setLaxantes(rs.getBoolean("laxantes"));
                inds.setDiureticos(rs.getBoolean("diureticos"));
                inds.setAntiacidos(rs.getBoolean("antiacidos"));
                inds.setAnalgesicos(rs.getBoolean("analgesicos"));
                inds.setAnticonceptivosOrales(rs.getBoolean("anticonceptivosOrales"));
                inds.setTerapiaHormonal(rs.getBoolean("terapiaHormonal"));
                inds.setDiarrea(rs.getBoolean("diarrea"));
                inds.setCeliaquia(rs.getBoolean("celiaquia"));
                inds.setEstrenimiento(rs.getBoolean("estrenimiento"));
                inds.setGastritis(rs.getBoolean("gastritis"));
                inds.setUlcera(rs.getBoolean("ulcera"));
                inds.setNausea(rs.getBoolean("nausea"));
                inds.setPirosis(rs.getBoolean("pirosis"));
                inds.setVomito(rs.getBoolean("vomito"));
                inds.setColitis(rs.getBoolean("colitis"));
                inds.setDentadura(rs.getBoolean("dentadura"));
                inds.setSensibilidadDental(rs.getBoolean("sensibilidadDental"));
                inds.setEmbarazo(rs.getBoolean("embarazo"));
                inds.setClimaterio(rs.getBoolean("climaterio"));
                inds.setCirugiasPrevias(rs.getString("cirugiasPrevias"));
                inds.setaFObesidad(rs.getBoolean("aFObesidad"));
                inds.setaFDiabetes(rs.getBoolean("aFDiabetes"));
                inds.setaFHTA(rs.getBoolean("aFHTA"));
                inds.setaFCancer(rs.getBoolean("aFCancer"));
                inds.setaFHipercolesterolemia(rs.getBoolean("aFHipercolesterolemia"));
                inds.setaFHipertrigliceridemia(rs.getBoolean("aFHipertrigliceridemia"));
                inds.setAlergiasMed(rs.getString("alergiasMed"));
                
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        finally{
            try{cs.close();}catch(Exception ex){System.out.println(ex.getMessage());}
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }   
        
        return inds;
    }
    
}
