/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.Especialistas.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.especialista.model.Nutricionista;

public interface NutricionistaDAO {
    int insertar(Nutricionista nutricionista);
    int modificar(Nutricionista nutricionista);
    int eliminar(int id_nutricionista);
    ArrayList<Nutricionista> listarTodos();
    ArrayList<Nutricionista> listarxId(int id);
}
