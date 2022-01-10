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
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.IndicadorSaludDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.IndicadorSaludMySQL;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.IndicadorSalud;

/**
 *
 * @author sebas
 */
@WebService(serviceName = "IndicadorSaludService")
public class IndicadorSaludService {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "insertarIndicadorSalud")
    public int insertarIndicadorSalud(@WebParam(name = "indicadorSalud") IndicadorSalud indis) {
        IndicadorSaludDAO daoInd = new IndicadorSaludMySQL();
        return daoInd.insertar(indis);
    }
    
    @WebMethod(operationName = "modificarIndicadorSalud")
    public int modificarIndicadorSalud(@WebParam(name = "indicadorSalud") IndicadorSalud indis) {
        IndicadorSaludDAO daoInd = new IndicadorSaludMySQL();
        return daoInd.modificar(indis);
    }
    
    
    @WebMethod(operationName = "adquirirIndicadorSalud")
    public IndicadorSalud adquirirIndicadorSalud(@WebParam(name = "name") int id_al) {
        IndicadorSaludDAO daoInd = new IndicadorSaludMySQL();
        return daoInd.adquirir(id_al);
    }
}
