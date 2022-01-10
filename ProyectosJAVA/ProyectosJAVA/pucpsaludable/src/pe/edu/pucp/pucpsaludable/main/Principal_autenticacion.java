/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.main;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.logging.Level;
import java.util.logging.Logger;
import pe.edu.pucp.pucpsaludable.autenticacion.dao.SesionActivaDAO;
import pe.edu.pucp.pucpsaludable.autenticacion.dao.TokenDAO;
import pe.edu.pucp.pucpsaludable.autenticacion.model.SesionActiva;
import pe.edu.pucp.pucpsaludable.autenticacion.model.Token;
import pe.edu.pucp.pucpsaludable.autenticacion.mysql.SesionActivaMySQL;
import pe.edu.pucp.pucpsaludable.autenticacion.mysql.TokenMySQL;

/**
 *
 * @author angel
 */
public class Principal_autenticacion
{
    public static void main(String[] args)
    {
        SesionActivaDAO daoSA = new SesionActivaMySQL();
        String [] resp = daoSA.verificar(40);
        System.out.println("Verificar token");
        System.out.println(resp[0] + " - " + resp[1]);
        for(SesionActiva sa: daoSA.listarPorID(253))
        {
            System.out.println(sa.getId() + " " + sa.getIdUsuario() + " " + sa.getDescripcion() + sa.getFechaInicio());
        }
        System.out.println("Iniciar sesión");
        String [] ses = daoSA.iniciarSesion("20166046", "123", "Windows 10");
        System.out.println(ses[0] + " - " + ses[1] + " - " + ses[2]);
    }
}