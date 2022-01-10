/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.HorasSuenho;

/**
 *
 * @author sebaf
 */
public interface HorasSuenhoDAO {
    int insertar(HorasSuenho horasDeSuenho);
    ArrayList<HorasSuenho> listarHorasSuenhoPorAlumno(int id_alumno);
    int eliminar(int id_horasSuenho);
    int modificar(HorasSuenho horasDeSuenho);
}
