/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.recetas.dao;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.receta.model.Ingrediente;
import pe.edu.pucp.pucpsaludable.receta.model.PresetReceta;



public interface PresetRecetaDAO {
    int insertar(PresetReceta presetReceta);
    int modificar(PresetReceta presetReceta);
    int eliminar(PresetReceta presetReceta);
    ArrayList<PresetReceta> listarTodos();
    int asignarIngrediente(PresetReceta presetReceta, Ingrediente ingrediente);
    ArrayList<PresetReceta> listarPorTipoComida(int tipo);
    
}
