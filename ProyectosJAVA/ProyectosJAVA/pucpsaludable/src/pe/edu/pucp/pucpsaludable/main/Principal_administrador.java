/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.pucpsaludable.main;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.administrador.dao.ReglaDAO;
import pe.edu.pucp.pucpsaludable.administrador.dao.RolDAO;
import pe.edu.pucp.pucpsaludable.administrador.model.Regla;
import pe.edu.pucp.pucpsaludable.administrador.model.Rol;
import pe.edu.pucp.pucpsaludable.administrador.mysql.ReglaMySQL;
import pe.edu.pucp.pucpsaludable.administrador.mysql.RolMySQL;

/**
 *
 * @author angel
 */
public class Principal_administrador
{
    public static void main(String[] args)
    {
        // Insertar
        ReglaDAO DAORegla = new ReglaMySQL();
        Regla regla1 = new Regla("Aceeso citas", 1, 1);
        Regla regla2 = new Regla("Acceso plan alimentario", 2, 1);
        Regla regla3 = new Regla("Restricción administración", 3, 0);
        DAORegla.insertar(regla1);
        DAORegla.insertar(regla2);
        DAORegla.insertar(regla3);
        System.out.println("Insertar regla completado");
        // Modificar
        regla3.setNombre("Psicólogo nutricional");
        DAORegla.modificar(regla3);
        System.out.println("Modificar regla completado");
        // Eliminar
        DAORegla.eliminar(regla2.getId_regla());
        System.out.println("Eliminar regla completado");
        // Listar
        ArrayList<Regla> lisregla = DAORegla.listarTodos();
        for (Regla regla : lisregla)
        {
            System.out.println("ID: " + regla.getId_regla()
                    + " Nombre: " + regla.getNombre());
        }
        System.out.println("Listar regla completado");

        // Lista de reglas para entrenador
        ArrayList<Regla> lregEnt= new ArrayList<Regla>();
        lregEnt.add(regla1);
        lregEnt.add(regla3);

        // Lista de reglas para nutricionista y psicólogo
        ArrayList<Regla> lregNutPsi= new ArrayList<Regla>();
        lregNutPsi.add(regla1);
        lregNutPsi.add(regla2);


        // Insertar
        RolDAO DAORol = new RolMySQL();
        Rol rol1 = new Rol("Entrenador");
        Rol rol2 = new Rol("Nutricionista");
        Rol rol3 = new Rol("Psicólogo");
        rol1.setReglas(lregEnt);
        rol2.setReglas(lregNutPsi);
        rol3.setReglas(lregNutPsi);
        DAORol.insertar(rol1);
        DAORol.insertar(rol2);
        DAORol.insertar(rol3);
        System.out.println("Insertar rol completado");
        // Modificar
        rol1.setReglas(lregNutPsi);
        rol3.setNombre("Psicólogo nutricional");
        DAORol.modificar(rol3);
        System.out.println("Modificar rol completado");
        // Eliminar
        DAORol.eliminar(rol2.getId_rol());
        System.out.println("Eliminar rol completado");
        // Listar
        ArrayList<Rol> lisrol = DAORol.listarTodos();
        for (Rol rol : lisrol)
        {
            System.out.println("ID: " + rol.getId_rol()
                    + " Nombre: " + rol.getNombre());
            System.out.println("Reglas:");
            for (Regla regla : rol.getReglas())
            {
                System.out.println("    ID: " + regla.getId_regla() + " Nombre: " + regla.getNombre());
            }
        }
        System.out.println("Listar rol completado");
    }
}
