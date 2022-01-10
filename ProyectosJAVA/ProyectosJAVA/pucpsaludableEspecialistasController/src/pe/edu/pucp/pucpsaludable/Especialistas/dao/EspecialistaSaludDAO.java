/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.Especialistas.dao;

import java.util.ArrayList;
import java.util.Date;

public interface EspecialistaSaludDAO {
    ArrayList<Date> listarTodos(int id, Date fecha);

}
