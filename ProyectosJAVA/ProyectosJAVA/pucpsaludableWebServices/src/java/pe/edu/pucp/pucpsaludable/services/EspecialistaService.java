/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.services;

import java.util.ArrayList;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import pe.edu.pucp.pucpsaludable.Especialistas.dao.EspecialistaDAO;
import pe.edu.pucp.pucpsaludable.Especialistas.mysql.EspecialistaMySQL;


/**
 *
 * @author Nico
 */
@WebService(serviceName = "Especialista")
public class EspecialistaService {
    
    @WebMethod(operationName = "agregarVideo")
    public int agregarVideoAEspecialista(@WebParam(name = "id_especialista")int id, @WebParam(name = "URL_video")String URL) {
        EspecialistaDAO dao = new EspecialistaMySQL();
        return dao.agregarVideoAEspecialista(id, URL);
    }
    @WebMethod(operationName = "listarVideos")
    public ArrayList<String> listarVideos()
    {
        EspecialistaDAO dao = new EspecialistaMySQL();
        return dao.listarVideos();
    }
    
    @WebMethod(operationName = "videoEspecialistaPorID")
    public ArrayList<String> videoEspecialistaPorID(@WebParam(name = "id_especialista")int id)
    {
        EspecialistaDAO dao = new EspecialistaMySQL();
        return dao.videoEspecialistaPorID(id);
    }
    
    
        
    @WebMethod(operationName = "agregarMensaje")
    public int agregarMensajeAEspecialista(@WebParam(name = "id_especialista")int id, @WebParam(name = "tituloMensaje")String tituloMensaje, @WebParam(name = "mensajeMensaje")String mensajeMensaje) {
        EspecialistaDAO dao = new EspecialistaMySQL();
        return dao.agregarMensajeAEspecialista(id, tituloMensaje, mensajeMensaje);
    }
    @WebMethod(operationName = "listarMensajes")
    public ArrayList<String> listarMensajes()
    {
        EspecialistaDAO dao = new EspecialistaMySQL();
        return dao.listarMensajes();
    }
    
    @WebMethod(operationName = "mensajeEspecialistaPorID")
    public ArrayList<String> mensajeEspecialistaPorID(@WebParam(name = "id_especialista")int id)
    {
        EspecialistaDAO dao = new EspecialistaMySQL();
        return dao.mensajeEspecialistaPorID(id);
    }
    
}
