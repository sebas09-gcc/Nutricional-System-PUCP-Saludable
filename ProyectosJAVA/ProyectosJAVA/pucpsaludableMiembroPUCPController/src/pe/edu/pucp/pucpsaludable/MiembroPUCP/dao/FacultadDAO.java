/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Facultad;

public interface FacultadDAO {
    int insertar(Facultad facultad);
    int modificar(Facultad facultad);
    int eliminar(int id_facultad);
    ArrayList<Facultad> listarTodos();
}
