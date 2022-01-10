/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.recetas.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.receta.model.Ingrediente;


public interface IngredienteDAO {
    //modificar
    int insertar(Ingrediente ingrediente);
    int modificar(Ingrediente ingrediente);
    int eliminar(Ingrediente ingrediente);
    ArrayList<Ingrediente> listarTodos();
    ArrayList<Ingrediente> listarXNombre(String nombre);
    //modificado
    ArrayList<Ingrediente> listarXPresetRecta(int idPreset);
    ArrayList<Ingrediente> listarXPreferenciaYAlumno(int idAl,int pref);
    ArrayList<Ingrediente> listarXNoClasificados(int idAl);
}
