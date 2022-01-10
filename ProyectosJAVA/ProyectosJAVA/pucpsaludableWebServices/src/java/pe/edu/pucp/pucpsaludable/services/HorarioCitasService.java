/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import pe.edu.pucp.pucpsaludable.Eventos.dao.HorarioDAO;
import pe.edu.pucp.pucpsaludable.Eventos.mysql.HorarioMySQL;
import pe.edu.pucp.pucpsaludable.eventos.model.Horario;

/**
 *
 * @author Marina
 */
@WebService(serviceName = "HorarioCitasService")
public class HorarioCitasService {


    @WebMethod(operationName = "listarPorEspec")
    public ArrayList<Horario> listarPorEspec(int id_espec){
        HorarioDAO _dao = new HorarioMySQL();
        return _dao.listarPorEspec(id_espec);
    } 
 
    @WebMethod(operationName = "insertar")
    public int insertar(Horario horar){
        HorarioDAO _dao = new HorarioMySQL();
        return _dao.insertar(horar);
    } 
    
    @WebMethod(operationName = "eliminarHorariosAnteriores")
    public int eliminarHorariosAnteriores(int id_espec){
        HorarioDAO _dao = new HorarioMySQL();
        return _dao.eliminarHorariosAnteriores(id_espec);
    } 
    
}
