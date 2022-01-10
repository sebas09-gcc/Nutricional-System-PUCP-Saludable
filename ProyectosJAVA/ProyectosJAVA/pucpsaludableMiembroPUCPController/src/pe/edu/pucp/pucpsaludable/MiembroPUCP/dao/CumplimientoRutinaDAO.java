/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.dao;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.CumplimientoRutina;

/**
 *
 * @author Marina
 */
public interface CumplimientoRutinaDAO {
    
        
    public int insertarCumplimientoRutinaAlimentaria(CumplimientoRutina cumple);
    public int modificarCumplimientoRutinaAlimentaria(CumplimientoRutina cumple);
    public int eliminarCumplimientoRutinaAlimentaria(int idCumple);
    public ArrayList<CumplimientoRutina> listarCumplimientoRutinaAlimentariaxAlumno(int id_alumno);
    public ArrayList<CumplimientoRutina> listarCumplimientoRutinaAlimentariaxAlumnoyFecha(int id_alumno, Date fecha);
    public ArrayList<CumplimientoRutina>listarPlanAlimentarioNombreRecetasxAlumnoyFecha(int id_alumno, Date fecha);    
    
}
