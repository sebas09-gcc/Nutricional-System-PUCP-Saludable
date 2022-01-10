/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.Eventos.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.eventos.model.Cita;
//import pe.edu.pucp.pucpsaludable.eventos.model.Cita;


/**
 *
 * @author sebas
 */
public interface CitaDAO {
    int insertar(Cita cita);
    int modificar(Cita cita);
    int eliminar(int id_cita);
    ArrayList<Cita> listarTodos();
    ArrayList<Cita> listarCitaProgramadaPorNombreCodigo(String nombre);
    ArrayList<Cita> listarCitaHistoricaPorNombreCodigo(String nombre);
    ArrayList<Cita> listarCitaProgramadaNutricionistaPorNombre(String nombre);
    ArrayList<Cita> listarCitaHistoricaNutricionistaPorNombre(String nombre);
    
    
    ArrayList<Cita> listarCitaProgramadaPorId(int id);
    ArrayList<Cita> listarCitaHistoricaPorId(int id);
    ArrayList<Cita> listarCitaProgramadaNutricionistaPorId(int id);
    ArrayList<Cita> listarCitaHistoricaNutricionistaPorId(int id);
    int cancelarCitaXAlumnoOEspecialista(int idcita,int idAlum,int idEsp);
    int atenderCitaXAlumnoOEspecialista(int idcita, int idAlum, int idEsp);
}
