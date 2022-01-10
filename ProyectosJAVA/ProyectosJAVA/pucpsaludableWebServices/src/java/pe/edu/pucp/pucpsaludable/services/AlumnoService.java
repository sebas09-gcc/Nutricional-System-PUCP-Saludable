package pe.edu.pucp.pucpsaludable.services;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Locale;
import java.util.TimeZone;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.config.DBManager;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.AlumnoDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.AlumnoMySQL;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alumno;
import pe.edu.pucp.pucpsaludable.servlets.ReporteAlumno;

/**
 *
 * @author sebaf
 */
@WebService(serviceName = "Alumno")
public class AlumnoService {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "listarAlumnoNombreCodigo")
    public ArrayList<Alumno> listarAlumnoNombreCodigo(@WebParam(name = "nombre") String nombre)
    {
        AlumnoDAO _dao = new AlumnoMySQL();
        return _dao.listarPorNombreCodigo(nombre);
    }
    
    
    @WebMethod(operationName = "listarAlumnoID")
    public ArrayList<Alumno> listarAlumnoID(@WebParam(name = "id") int id)
    {
        AlumnoDAO _dao = new AlumnoMySQL();
        return _dao.listarPorId(id);
    }
    
    @WebMethod(operationName = "modificarAlumnoID")
    public int modificar(@WebParam(name = "Alumno") Alumno alumno)
    {
        AlumnoDAO _dao = new AlumnoMySQL();
        return _dao.modificar(alumno);
    }
    @WebMethod(operationName = "listarAlumno")
    public ArrayList<Alumno> listarTodosAlumno()
    {
        AlumnoDAO _dao = new AlumnoMySQL();
        return _dao.listarTodos();
    }
    
    
    @WebMethod(operationName = "generarPlanAlimenticio")
    public byte[] generarReportePlanAlimentario(@WebParam(name = "id") int id)
    {
        byte[] reporteBytes = null;
        try{
                Locale.setDefault(new Locale("es","PE"));
            TimeZone.setDefault(TimeZone.getTimeZone("GMT-5"));
            JasperReport reporte = 
                    (JasperReport) JRLoader.loadObject(ReporteAlumno.class.getResource(
                            "/pe/edu/pucp/pucpsaludable/reportes/DatosAlumno.jasper"));
            String rutaSubreportePlanAlimentario = 
                ReporteAlumno.class.getResource("/pe/edu/pucp/pucpsaludable/reportes/PlanAlimentario.jasper").getPath();
            Class.forName("com.mysql.cj.jdbc.Driver");
            Connection con = DriverManager.getConnection(DBManager.url, DBManager.user, DBManager.password);
            HashMap hm = new HashMap();
            hm.put("IdAlumno",String.valueOf(id));
            hm.put("rutaPlanAlimentario",rutaSubreportePlanAlimentario);
            JasperPrint jp = JasperFillManager.fillReport(reporte,hm,con);
            
            con.close();
                //Devolver el reporte a nivel de bytes
            reporteBytes = JasperExportManager.exportReportToPdf(jp);
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        return reporteBytes;
    }
}
