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
import pe.edu.pucp.pucpsaludable.receta.model.Ingrediente;
import pe.edu.pucp.pucpsaludable.recetas.dao.IngredienteDAO;
import pe.edu.pucp.pucpsaludable.recetas.mysql.IngredienteMySQL;

/**
 *
 * @author sebas
 */
@WebService(serviceName = "IngredienteService")
public class IngredienteService {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "insertarIngre")
    public int insertarIngre(@WebParam(name = "ingred") Ingrediente ingredient) {
        IngredienteDAO _dao = new IngredienteMySQL();
        return _dao.insertar(ingredient);
    }
    
    @WebMethod(operationName = "modificarIngre")
    public int modificarIngre(@WebParam(name = "ingred") Ingrediente ingredient) {
        IngredienteDAO _dao = new IngredienteMySQL();
        return _dao.modificar(ingredient);
    }
    
    @WebMethod(operationName = "eliminarIngre")
    public int eliminarIngre(@WebParam(name = "ingred") Ingrediente ingredient) {
        IngredienteDAO _dao = new IngredienteMySQL();
        return _dao.eliminar(ingredient);
    }
    
    @WebMethod(operationName = "listarIngredientesTodos")
    public ArrayList<Ingrediente> listarIngredientesTodos() {
        IngredienteDAO _dao = new IngredienteMySQL();
        return _dao.listarTodos();
    }
    
    @WebMethod(operationName = "listarIngredientesNombre")
    public ArrayList<Ingrediente> listarIngredientesNombre(@WebParam(name = "nombre") String nombre) {
        IngredienteDAO _dao = new IngredienteMySQL();
        return _dao.listarXNombre(nombre);
    }
    
    @WebMethod(operationName = "listarIngredientesPreset")
    public ArrayList<Ingrediente> listarIngredientesPreset(@WebParam(name = "idPreset") int idPreset) {
        IngredienteDAO _dao = new IngredienteMySQL();
        return _dao.listarXPresetRecta(idPreset);
    }
    
    @WebMethod(operationName = "listarIngredientesNoClasificados")
    public ArrayList<Ingrediente> listarIngredientesNoClasificados(@WebParam(name = "idAlumno") int idAlumno) {
        IngredienteDAO _dao = new IngredienteMySQL();
        return _dao.listarXNoClasificados(idAlumno);
    }
    
    @WebMethod(operationName = "listarIngredientesPrefAl")
    public ArrayList<Ingrediente> listarIngredientesPrefAl(@WebParam(name = "idAlumno") int idAlumno,@WebParam(name = "preferencia") int preferencia) {
        IngredienteDAO _dao = new IngredienteMySQL();
        return _dao.listarXPreferenciaYAlumno(idAlumno,preferencia);
    }
    
    
    
    
}
