/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.administrador.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.administrador.model.Administrador;

/**
 *
 * @author angel
 */
public interface AdministradorDAO
{
    int insertar(Administrador administrador);
    int modificar(Administrador administrador);
    int eliminar(int id_administrador);
    ArrayList<Administrador> listarTodos();
}
