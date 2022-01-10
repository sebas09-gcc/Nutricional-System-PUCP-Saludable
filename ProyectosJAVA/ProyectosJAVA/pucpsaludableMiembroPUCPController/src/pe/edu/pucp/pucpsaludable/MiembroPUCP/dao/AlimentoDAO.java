/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alimento;


/**
 *
 * @author sebas
 */
public interface AlimentoDAO {
    int insertar(Alimento alim);
    ArrayList<Alimento> listarTodo();
    ArrayList<Alimento> listarAlimentoPreferidoPorAlumno(int id_alumno);
    ArrayList<Alimento> listarAlimentoAlergiaPorAlumno(int id_alumno);
    ArrayList<Alimento> filtrarAlimentoPorPreferencia(int id_alumno,int pref);
    int eliminar(int id_alum,int id_ingr);
    int modificar(Alimento alim);
    Alimento adquirirAlimento(int id_al,int id_ingre);
}
