/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.autenticacion.dao;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.autenticacion.model.SesionActiva;

/**
 *
 * @author angel
 */
public interface SesionActivaDAO
{
    public String [] verificar(int idSesionActiva);
    public String [] iniciarSesion(String usuario, String contrasena, String descripcion);
    int insertar(SesionActiva sesionActiva);
    int modificar(SesionActiva sesionActiva);
    int eliminar(int id_sesionActiva);
    ArrayList<SesionActiva> listarPorID(int id_usuario);
    void cerrarTodas(int id_usuario);
}
