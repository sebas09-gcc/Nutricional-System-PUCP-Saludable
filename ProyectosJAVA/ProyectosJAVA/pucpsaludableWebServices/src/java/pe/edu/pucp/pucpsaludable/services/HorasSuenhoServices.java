/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.HorasSuenhoDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.HorasSuenhoMySQL;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.HorasSuenho;

/**
 *
 * @author sebas
 */
@WebService(serviceName = "HorasSuenhoServices")
public class HorasSuenhoServices {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "insertarHorasSuenho")
    public int insertarHorasSuen(@WebParam(name = "horasSue") HorasSuenho horassue) {
        HorasSuenhoDAO _dao = new HorasSuenhoMySQL();
        return _dao.insertar(horassue);
    }
    
    @WebMethod(operationName = "modificarHorasSuenho")
    public int modificarHorasSuen(@WebParam(name = "horasSue") HorasSuenho horassue) {
        HorasSuenhoDAO _dao = new HorasSuenhoMySQL();
        return _dao.modificar(horassue);
    }
    
    @WebMethod(operationName = "eliminarHorasSuenho")
    public int eliminarHorasSuen(@WebParam(name = "idHorasSue") int idHoraSue) {
        HorasSuenhoDAO _dao = new HorasSuenhoMySQL();
        return _dao.eliminar(idHoraSue);
    }
    
    @WebMethod(operationName = "listarHorasSuenPorAlum")
    public ArrayList<HorasSuenho> listarHorasSuenPorAl(@WebParam(name = "idAl") int idAl) {
        HorasSuenhoDAO _dao = new HorasSuenhoMySQL();
        return _dao.listarHorasSuenhoPorAlumno(idAl);
    }
}
