/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.administrador.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.administrador.model.Rol;

/**
 *
 * @author angel
 */
public interface RolDAO
{
    int insertar(Rol rol);
    int modificar(Rol rol);
    int eliminar(int id_rol);
    ArrayList<Rol> listarTodos();
}
