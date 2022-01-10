/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.pucpsaludable.Especialistas.dao.EspecialistaSaludDAO;
import pe.edu.pucp.pucpsaludable.Especialistas.dao.NutricionistaDAO;
import pe.edu.pucp.pucpsaludable.Especialistas.mysql.EspecialistaSaludMySQL;
import pe.edu.pucp.pucpsaludable.Especialistas.mysql.NutricionistaMySQL;
import pe.edu.pucp.pucpsaludable.Eventos.dao.CitaDAO;
import pe.edu.pucp.pucpsaludable.Eventos.mysql.CitaMySQL;
import pe.edu.pucp.pucpsaludable.especialista.model.Nutricionista;
import pe.edu.pucp.pucpsaludable.eventos.model.Cita;

/**
 *
 * @author sebaf
 */
@WebService(serviceName = "CitasService")
public class CitasService {
    // Alumno
    @WebMethod(operationName = "getNutritionists")
    public ArrayList<Nutricionista> getNutritionists()
    {
        NutricionistaDAO _dao = new NutricionistaMySQL();            
        return _dao.listarTodos();
    }
    @WebMethod(operationName = "getAvailableAppointments")
    public ArrayList<Date> getAvailableAppointments(@WebParam(name = "specialistID") int specialistID, @WebParam(name = "date") Date date)
    {
        EspecialistaSaludDAO _dao = new EspecialistaSaludMySQL();
        return _dao.listarTodos(specialistID, date);
    }

    
    @WebMethod(operationName = "registerAppointment")
    public int registerAppointment(@WebParam(name = "appointment") Cita cita)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.insertar(cita);
    }

    @WebMethod(operationName = "listarCitaHistoricaPorNombreCodigo")
    public ArrayList<Cita> listarCitaHistoricaPorNombreCodigo(@WebParam(name = "nombre") String nombre)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.listarCitaHistoricaPorNombreCodigo(nombre);
    }

    @WebMethod(operationName = "listarCitaProgramadaPorNombreCodigo")
    public ArrayList<Cita> listarCitaProgramadaPorNombreCodigo(@WebParam(name = "nombre") String nombre)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.listarCitaProgramadaPorNombreCodigo(nombre);
    }
    @WebMethod(operationName = "listarCitaHistoricaPorID")
    public ArrayList<Cita> listarCitaHistoricaPorID(@WebParam(name = "id") int id)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.listarCitaHistoricaPorId(id);
    }

    @WebMethod(operationName = "listarCitaProgramadaPorID")
    public ArrayList<Cita> listarCitaProgramadaPorID(@WebParam(name = "id") int id)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.listarCitaProgramadaPorId(id);
    }

    // Nutricionista
    @WebMethod(operationName = "listarCitaHistoricaNutricionistaPorNombre")
    public ArrayList<Cita> listarCitaHistoricaNutricionistaPorNombre(@WebParam(name = "nombre") String nombre)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.listarCitaHistoricaNutricionistaPorNombre(nombre);
    }

    @WebMethod(operationName = "listarCitaProgramadaNutricionistaPorNombre")
    public ArrayList<Cita> listarCitaProgramadaNutricionistaPorNombre(@WebParam(name = "nombre") String nombre)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.listarCitaProgramadaNutricionistaPorNombre(nombre);
    }

    @WebMethod(operationName = "listarCitaHistoricaNutricionistaPorID")
    public ArrayList<Cita> listarCitaHistoricaNutricionistaPorID(@WebParam(name = "id") int id)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.listarCitaHistoricaNutricionistaPorId(id);
    }

    @WebMethod(operationName = "listarCitaProgramadaNutricionistaPorID")
    public ArrayList<Cita> listarCitaProgramadaNutricionistaPorID(@WebParam(name = "id") int id)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.listarCitaProgramadaNutricionistaPorId(id);
    }
    
    @WebMethod(operationName = "cancelarCitaXAlumnoOEspecialista")
    public int cancelarCitaXAlumnoOEspecialista(@WebParam(name = "idCita")int idcita,
            @WebParam(name = "idAlum") int idAlum,@WebParam(name = "idEsp") int idEsp)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.cancelarCitaXAlumnoOEspecialista(idcita,idAlum,idEsp);
    }
    
    @WebMethod(operationName = "modificarCita")
    public int modificarCita(@WebParam(name = "Cita")Cita cita)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.modificar(cita);
    }
    
    @WebMethod(operationName = "eliminarCitaxId")
    public int eliminarCitaxId(@WebParam(name = "idCita")int idcita)
    {
        CitaDAO _dao = new CitaMySQL();
        return _dao.eliminar(idcita);
    }
}
