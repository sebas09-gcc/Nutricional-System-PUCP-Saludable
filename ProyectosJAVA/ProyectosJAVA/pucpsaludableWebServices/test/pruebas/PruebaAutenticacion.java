/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pruebas;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alumno;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Especialidad;
import pe.edu.pucp.pucpsaludable.services.Autenticacion;

public class PruebaAutenticacion
{
    public static void main(String[] args) throws ParseException
    {
        Autenticacion aut = new Autenticacion();
        
        Alumno alumno = new Alumno();
        alumno.setApellidos("A");
        alumno.setNombres("B");
        alumno.setCodigoPUCP("20166046");
        alumno.setContrasena("12345678");
        try
        {
            SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
            alumno.setFechaNacimiento(formato.parse("24-05-1986"));
        }
        catch(Exception ex)
        {
            System.out.println(ex.getMessage());
        }
        alumno.setSexo('H');
        alumno.setEmailPUCP("angel@pxcp.pe");
        alumno.setTelefonoMovil("987654321");
        alumno.setNumContacto("987654321");
        alumno.setParentezcoContacto("X");
        alumno.setNombreContacto("W");
        
        Especialidad especialidad = new Especialidad();
        especialidad.setId_especialidad(1);
        alumno.setEspecialidad(especialidad);
        System.out.println("Insertar:");
        aut.registerAsStudent(alumno);
        System.out.println(alumno.getId_usuario());
    }
}
