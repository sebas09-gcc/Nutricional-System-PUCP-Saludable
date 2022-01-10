/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.dao;

import java.util.ArrayList;

import pe.edu.pucp.pucpsaludable.miembroPUCP.model.PlanAlimentario;
import pe.edu.pucp.pucpsaludable.receta.model.PresetReceta;

/**
 *
 * @author Oleg
 */
public interface PlanAlimentarioDAO {
    int insertar(PlanAlimentario planAlimentario);
    int modificarPlanAlumno(ArrayList<PlanAlimentario> planAlimentario);
    int insertarPlanAlumno(ArrayList<PlanAlimentario> pl);
    ArrayList<PresetReceta> generarPlan(int idAlumno,int limite,int tipoC);
    int modificar(PlanAlimentario planAlimentario);
    void eliminar(int id_planAlimentario);
    ArrayList<PlanAlimentario> listarTodos();
    ArrayList<PlanAlimentario> listarPorUnAlumno(int idAlumno);
    ArrayList<PresetReceta> listarPorUnAlumnoPreset(int idAlumno);
    int eliminarPlanAlimentarioxAlumno(int idAlumno);
}
