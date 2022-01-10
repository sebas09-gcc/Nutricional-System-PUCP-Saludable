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
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.AlimentoDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.AlimentoMySQL;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alimento;

/**
 *
 * @author sebas
 */
@WebService(serviceName = "AlimentoWebService")
public class AlimentoWebService {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "insertarAlimento")
    public int insertarAlimento(@WebParam(name = "alim") Alimento alim) {
        AlimentoDAO dao = new AlimentoMySQL();
        return dao.insertar(alim);
    }
    
    @WebMethod(operationName = "eliminarAlimento")
    public int eliminarAlimento(@WebParam(name = "idAlumno") int idAlumno,@WebParam(name = "idIngred") int idIngred) {
        AlimentoDAO dao = new AlimentoMySQL();
        return dao.eliminar(idAlumno, idIngred);
    }
    
    @WebMethod(operationName = "modificarAlimento")
    public int modificarAlimento(@WebParam(name = "alim") Alimento alim) {
        AlimentoDAO dao = new AlimentoMySQL();
        return dao.modificar(alim);
    }
    
    @WebMethod(operationName = "filtrarPorPreferencia")
    public ArrayList<Alimento> filtrarPorPreferencia(@WebParam(name = "alumno") int id_al,@WebParam(name = "pref") int pref) {
        AlimentoDAO dao = new AlimentoMySQL();
        return dao.filtrarAlimentoPorPreferencia(id_al, pref);
    }
    
    @WebMethod(operationName = "adquirirAlimento")
    public Alimento adquirirAlimento(@WebParam(name = "id_alumno") int id_al,@WebParam(name = "id_ingrediente") int id_ing) {
        AlimentoDAO dao = new AlimentoMySQL();
        return dao.adquirirAlimento(id_al, id_ing);
    }
    
    
}
