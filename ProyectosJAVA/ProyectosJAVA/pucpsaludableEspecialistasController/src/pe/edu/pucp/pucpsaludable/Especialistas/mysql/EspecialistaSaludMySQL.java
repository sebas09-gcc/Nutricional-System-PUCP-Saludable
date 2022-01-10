/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.Especialistas.mysql;

import com.mysql.cj.conf.ConnectionUrlParser.Pair;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.Timestamp;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import pe.edu.pucp.pucpsaludable.Especialistas.config.DBManager;
import pe.edu.pucp.pucpsaludable.Especialistas.dao.EspecialistaSaludDAO;

public class EspecialistaSaludMySQL implements EspecialistaSaludDAO
{
    Connection con;
    Statement st;
    ResultSet rs;
    PreparedStatement ps;
    CallableStatement cs;
    @Override
    public ArrayList<Date> listarTodos(int id, Date fecha)
    {
        ArrayList<Date> horariosDisponibles = new ArrayList<>();
        try
        {
            Timestamp tsf = new Timestamp(fecha.getTime());
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_CITAS_DISPONIBLES(?,?)}");
            cs.setInt("_id_especialista", id);
            cs.setTimestamp("_fecha", tsf);
            rs = cs.executeQuery();
            while (rs.next())
            {
                horariosDisponibles.add(rs.getTimestamp("fechaHoraInicio"));
                
            }
        return horariosDisponibles;
        }
        catch (Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        finally
        {
            try
            {
                cs.close();
            }
            catch (Exception ex)
            {
                System.out.println(ex.getMessage());
            }
            try
            {
                con.close();
            }
            catch (Exception ex)
            {
                System.out.println(ex.getMessage());
            }
        }
        return horariosDisponibles;
    }

    

}
