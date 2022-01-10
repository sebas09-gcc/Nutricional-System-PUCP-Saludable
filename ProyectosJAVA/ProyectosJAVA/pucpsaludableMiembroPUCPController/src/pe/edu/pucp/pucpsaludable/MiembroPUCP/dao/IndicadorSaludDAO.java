/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.IndicadorSalud;

/**
 *
 * @author sebas
 */
public interface IndicadorSaludDAO {
    int insertar(IndicadorSalud indicadorSalud);
    int modificar(IndicadorSalud indicadorSalud);
    IndicadorSalud adquirir(int id_alumno);
}
