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
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.IndicadorAntropometricoDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.IndicadorAntropometricoMySQL;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.IndicadorAntropometrico;

/**
 *
 * @author sebas
 */
@WebService(serviceName = "IndicadorAntropoService")
public class IndicadorAntropoService {

    /**
     * This is a sample web service operation
     */
    
    @WebMethod(operationName = "insertarIndicadorAntropom")
    public int insertarIndicadorAntropom(@WebParam(name = "indicadorAntropometrico") IndicadorAntropometrico india) {
        IndicadorAntropometricoDAO daoInd = new IndicadorAntropometricoMySQL();
        return daoInd.insertar(india);
    }
    
    @WebMethod(operationName = "modificarIndicadorAntropom")
    public int modificarIndicadorAntropom(@WebParam(name = "indicadorAntropometrico") IndicadorAntropometrico india) {
        IndicadorAntropometricoDAO daoInd = new IndicadorAntropometricoMySQL();
        return daoInd.modificar(india);
    }
    
    @WebMethod(operationName = "eliminarIndicadorAntropom")
    public int eliminarIndicadorAntropom(@WebParam(name = "idIndicador") int id_ind) {
        IndicadorAntropometricoDAO daoInd = new IndicadorAntropometricoMySQL();
        return daoInd.eliminar(id_ind);
    }
    
    
    @WebMethod(operationName = "listarIndicadorAntropomPorAlumno")
    public ArrayList<IndicadorAntropometrico> listarIndicadorAntropomPorAlumno(@WebParam(name = "id") int id_al) {
        IndicadorAntropometricoDAO daoInd = new IndicadorAntropometricoMySQL();
        return daoInd.listarIndicadorAntropometricoPorAlumno(id_al);
    }
}
