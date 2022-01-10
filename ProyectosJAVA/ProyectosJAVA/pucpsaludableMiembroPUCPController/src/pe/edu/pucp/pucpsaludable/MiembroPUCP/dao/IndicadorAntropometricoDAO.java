/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.IndicadorAntropometrico;

/**
 *
 * @author sebaf
 */
public interface IndicadorAntropometricoDAO {
    int insertar(IndicadorAntropometrico indicadorAntropometrico);
    ArrayList<IndicadorAntropometrico> listarIndicadorAntropometricoPorAlumno(int id_alumno);
    int eliminar(int id_indicadorAntropometrico);
    int modificar(IndicadorAntropometrico indicadorAntropometrico);
}
