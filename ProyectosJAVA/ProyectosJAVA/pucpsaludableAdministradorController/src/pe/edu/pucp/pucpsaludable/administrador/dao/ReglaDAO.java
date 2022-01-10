/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.administrador.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.administrador.model.Regla;

/**
 *
 * @author angel
 */
public interface ReglaDAO
{
    int insertar(Regla regla);
    int modificar(Regla regla);
    int eliminar(int id_regla);
    ArrayList<Regla> listarTodos();
}
