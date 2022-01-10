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
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.ConstanciaDAO;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Constancia;

/**
 *
 * @author sebas
 */
public class ConstanciaMySQL implements ConstanciaDAO{

    Connection con; //    
    ResultSet rs; //recibe el contenido de la llamada al query
    PreparedStatement ps; //
    CallableStatement cs;
    
    @Override
    public int insertar(Constancia consta) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call INSERTAR_CONSTANCIA(?,?,?,?)}");
            /*cs.setInt("_fid_alumno", indicadorAntropometrico.getFid_alumno());
            cs.setDate("_fecha_registro",new java.sql.Date(indicadorAntropometrico.getFechaRegistro().getTime()));
            cs.setDouble("_circunferencia_abdominal",indicadorAntropometrico.getCircunferenciaAbdominal());
            cs.setDouble("_circunferencia_brazo",indicadorAntropometrico.getCircunferenciaBrazo());
            cs.setDouble("_circunferencia_cadera",indicadorAntropometrico.getCircunferenciaCadera());
            cs.setDouble("_circunferencia_cintura",indicadorAntropometrico.getCircunferenciaCintura());
            cs.setDouble("_estatura",indicadorAntropometrico.getEstatura());
            cs.setDouble("_peso_habitual",indicadorAntropometrico.getPesoHabitual());*/
            cs.executeUpdate();
            //ahora, hemos obtenido el id autogenerado
            //indicadorAntropometrico.setId_indicadorAntropometrico(cs.getInt("_id_indicador_antropometrico"));
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
    public ArrayList<Constancia> listarConstancias(int id_alumno) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public Constancia adquirirConstancia(int id_alumno) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int id_alumno) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int modificar(Constancia id_constancia) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
    
}
