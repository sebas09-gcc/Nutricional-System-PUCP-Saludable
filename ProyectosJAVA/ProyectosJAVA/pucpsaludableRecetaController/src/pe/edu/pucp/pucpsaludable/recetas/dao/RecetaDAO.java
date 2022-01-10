/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.recetas.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.receta.model.PresetReceta;
import pe.edu.pucp.pucpsaludable.receta.model.Receta;


public interface RecetaDAO {
    int insertar(Receta receta);
    int modificar(Receta receta);
    int eliminar(Receta receta);
    ArrayList<Receta> listarTodos();
    int asignarPreset(Receta receta,PresetReceta presetReceta);
    Receta obtenerRecetaXIDPreset(int idPreset);//nuevo
}
