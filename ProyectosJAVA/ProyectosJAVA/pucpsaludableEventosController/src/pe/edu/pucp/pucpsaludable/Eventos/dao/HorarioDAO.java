/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.Eventos.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.eventos.model.Horario;
/**
 *
 * @author sebas
 */
public interface HorarioDAO {
    int insertar(Horario horar);
    int modificar(Horario horar);
    int eliminarHorariosAnteriores(int id_horar);
    ArrayList<Horario> listarTodos();
    ArrayList<Horario> listarPorEspec(int id);
}
