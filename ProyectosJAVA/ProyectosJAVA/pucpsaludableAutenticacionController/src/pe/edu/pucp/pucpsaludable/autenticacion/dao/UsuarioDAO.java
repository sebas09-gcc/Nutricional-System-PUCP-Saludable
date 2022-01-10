/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.autenticacion.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Token;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Usuario;

/**
 *
 * @author angel
 */
public interface UsuarioDAO
{
    int verificarRegistro(String codigoPUCP);
    int cambiarContrasena(int userid, String contrasena);
    ArrayList<Usuario> listarUsuariosPorEstado(String name, int estado);
    int cambiarEstadoUsuario(int id, int estado);
}
