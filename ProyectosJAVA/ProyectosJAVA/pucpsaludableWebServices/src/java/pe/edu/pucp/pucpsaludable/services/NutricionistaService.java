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
import pe.edu.pucp.pucpsaludable.Especialistas.dao.NutricionistaDAO;
import pe.edu.pucp.pucpsaludable.Especialistas.mysql.NutricionistaMySQL;
import pe.edu.pucp.pucpsaludable.especialista.model.Nutricionista;

/**
 *
 * @author sebaf
 */
@WebService(serviceName = "NutricionistaService")
public class NutricionistaService {

    /**
     * This is a sample web service operation
     * @param id
     * @return 
     */
    @WebMethod(operationName = "listarNutricionistaID")
    public ArrayList<Nutricionista> listarNutricionistaID(@WebParam(name = "id") int id)
    {
        NutricionistaDAO _dao = new NutricionistaMySQL();
        return _dao.listarxId(id);
    }
    @WebMethod(operationName = "modificarNutricionista")
    public int modificarNutricionista(@WebParam(name = "Nutricionista") Nutricionista nutri)
    {
        NutricionistaDAO _dao = new NutricionistaMySQL();
        return _dao.modificar(nutri);
    }
}
