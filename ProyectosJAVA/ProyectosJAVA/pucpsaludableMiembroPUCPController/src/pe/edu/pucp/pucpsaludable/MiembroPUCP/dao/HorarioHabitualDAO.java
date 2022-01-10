/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.dao;

import pe.edu.pucp.pucpsaludable.miembroPUCP.model.HorarioHabitual;

/**
 *
 * @author sebas
 */
public interface HorarioHabitualDAO {
    int insertar(HorarioHabitual horhab);
    HorarioHabitual adquirirHorarioHabitual(int id_alumno);
    //int eliminar(int id_horasSuenho);
    int modificar(HorarioHabitual horhab);
}
