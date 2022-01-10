/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.HorarioHabitualDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.HorarioHabitualMySQL;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.HorarioHabitual;

/**
 *
 * @author sebas
 */
@WebService(serviceName = "HorarioHabitual")
public class HorarioHabitualService {

    /**
     * This is a sample web service operation
     */
    @WebMethod(operationName = "insertarHorarioHabitual")
    public int insertarHorarioHabitual(@WebParam(name = "horarioHab") HorarioHabitual horhab) {
        HorarioHabitualDAO dao= new HorarioHabitualMySQL();
        return dao.insertar(horhab);
    }
    
    @WebMethod(operationName = "modificarHorarioHabitual")
    public int modificarHorarioHabitual(@WebParam(name = "horarioHab") HorarioHabitual horhab) {
        HorarioHabitualDAO dao= new HorarioHabitualMySQL();
        return dao.modificar(horhab);
    }
    
    @WebMethod(operationName = "obtenerHorarioHabitual")
    public HorarioHabitual obtenerHorarioHabitual(@WebParam(name = "id_alumno") int id_al) {
        HorarioHabitualDAO dao= new HorarioHabitualMySQL();
        return dao.adquirirHorarioHabitual(id_al); 
    }
}
