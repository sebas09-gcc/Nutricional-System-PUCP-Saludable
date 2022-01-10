/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.Especialistas.dao;

import java.util.ArrayList;

/**
 *
 * @author Nico
 */
public interface EspecialistaDAO {
    int agregarVideoAEspecialista(int id,String URL);
    ArrayList<String> listarVideos();
    ArrayList<String> videoEspecialistaPorID(int id) ;
    
    int agregarMensajeAEspecialista(int id,String titulo, String mensaje);
    ArrayList<String> listarMensajes();
    ArrayList<String> mensajeEspecialistaPorID(int id) ;
}
