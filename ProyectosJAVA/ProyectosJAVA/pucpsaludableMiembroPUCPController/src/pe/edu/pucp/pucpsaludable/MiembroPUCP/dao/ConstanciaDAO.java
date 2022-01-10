/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Constancia;

/**
 *
 * @author sebas
 */
public interface ConstanciaDAO {
    int insertar(Constancia consta);
    ArrayList<Constancia> listarConstancias(int id_alumno);
    Constancia adquirirConstancia(int id_alumno);
    int eliminar(int id_alumno);
    int modificar(Constancia id_constancia);
}
