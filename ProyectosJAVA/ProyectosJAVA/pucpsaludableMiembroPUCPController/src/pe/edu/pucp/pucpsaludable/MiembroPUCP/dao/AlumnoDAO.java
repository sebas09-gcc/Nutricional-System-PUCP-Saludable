/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.MiembroPUCP.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alumno;
import pe.edu.pucp.pucpsaludable.receta.model.Ingrediente;

public interface AlumnoDAO{
    int insertar(Alumno alumno);
    int modificar(Alumno alumno);
    int eliminar(int id_alumno);
    ArrayList<Alumno> listarTodos();
    ArrayList<Alumno> listarPorNombreCodigo(String nombre);
    ArrayList<Alumno> listarPorId(int id);
    int AgregarAlimento(Alumno alumno,Ingrediente ingrediente,boolean preferencia);
}
