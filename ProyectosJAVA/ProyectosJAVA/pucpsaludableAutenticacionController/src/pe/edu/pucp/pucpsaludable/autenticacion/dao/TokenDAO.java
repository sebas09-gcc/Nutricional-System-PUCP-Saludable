/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.autenticacion.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Token;

/**
 *
 * @author angel
 */
public interface TokenDAO
{
    int insertar(Token token);
    int modificar(Token token);
    int eliminar(int id_sesionActiva);
    ArrayList<Token> listarTodos();
}
