
package pe.edu.pucp.pucpsaludable.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.CumplimientoRutinaDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.CumplimientoRutinaMySQL;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.CumplimientoRutina;

@WebService(serviceName = "CumplimientoRutina")
public class CumplimientoRutinaService {


    @WebMethod(operationName = "insertarCumplimientoRutinaAlimentaria")
    public int insertarCumplimientoRutinaAlimentaria(CumplimientoRutina cumple) {
        CumplimientoRutinaDAO _dao = new CumplimientoRutinaMySQL();
        return _dao.insertarCumplimientoRutinaAlimentaria(cumple);        
    }
    
    @WebMethod(operationName = "modificarCumplimientoRutinaAlimentaria")
    public int modificarCumplimientoRutinaAlimentaria(CumplimientoRutina cumple) {
        CumplimientoRutinaDAO _dao = new CumplimientoRutinaMySQL();
        return _dao.modificarCumplimientoRutinaAlimentaria(cumple);        
    }

    @WebMethod(operationName = "listarCumplimientoRutinaAlimentariaxAlumno")
    public ArrayList<CumplimientoRutina> listarCumplimientoRutinaAlimentariaxAlumno(int id_alumno) {
        CumplimientoRutinaDAO _dao = new CumplimientoRutinaMySQL();
        return _dao.listarCumplimientoRutinaAlimentariaxAlumno(id_alumno);
    }  
    
    @WebMethod(operationName = "listarCumplimientoRutinaAlimentariaxAlumnoyFecha")
    public ArrayList<CumplimientoRutina> listarCumplimientoRutinaAlimentariaxAlumnoyFecha(int id_alumno, Date fecha) {
        CumplimientoRutinaDAO _dao = new CumplimientoRutinaMySQL();
        return _dao.listarCumplimientoRutinaAlimentariaxAlumnoyFecha(id_alumno, fecha);
    }   
    
    @WebMethod(operationName = "listarPlanAlimentarioNombreRecetasxAlumnoyFecha")
    public ArrayList<CumplimientoRutina> listarPlanAlimentarioNombreRecetasxAlumnoyFecha(int id_alumno, Date fecha) {
        CumplimientoRutinaDAO _dao = new CumplimientoRutinaMySQL();
        return _dao.listarPlanAlimentarioNombreRecetasxAlumnoyFecha(id_alumno, fecha);
    }  
    
}



    