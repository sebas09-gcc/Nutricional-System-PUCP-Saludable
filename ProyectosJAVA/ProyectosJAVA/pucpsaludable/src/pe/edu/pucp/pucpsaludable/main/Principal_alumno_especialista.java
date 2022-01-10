/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 29/09/2021
Hora: 04:44:09 AM
*/

package pe.edu.pucp.pucpsaludable.main;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.Especialistas.dao.EspecialistaDAO;


import pe.edu.pucp.pucpsaludable.Especialistas.dao.NutricionistaDAO;

import pe.edu.pucp.pucpsaludable.Especialistas.mysql.EspecialistaMySQL;


import pe.edu.pucp.pucpsaludable.Especialistas.mysql.NutricionistaMySQL;



import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.AlumnoDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.EspecialidadDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.dao.FacultadDAO;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.AlumnoMySQL;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.EspecialidadMySQL;
import pe.edu.pucp.pucpsaludable.MiembroPUCP.mysql.FacultadMySQL;

import pe.edu.pucp.pucpsaludable.especialista.model.Nutricionista;

import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Alumno;

import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Especialidad;
import pe.edu.pucp.pucpsaludable.miembroPUCP.model.Facultad;


public class Principal_alumno_especialista {

    public static void main(String[] args){
    
                SimpleDateFormat formato = new SimpleDateFormat("dd-MM-yyyy");
        
        /*
        *************************************************************************
        * ALUMNO, FACULTAD, ESPECIALIDAD: Insertar, listar, modificar
        * 
        *
        *************************************************************************
        */    


/*
        AlumnoDAO daoAlumno = new AlumnoMySQL();
        FacultadDAO daoFacultad = new FacultadMySQL();
        EspecialidadDAO daoEspecialidad = new EspecialidadMySQL();
//
//
        Facultad f1 = new Facultad("Facultad de Ciencias e Ingenieria", "Carreras de ciencias");
        Facultad f2 = new Facultad("Facultad de Ciencias Sociales", "Carreras de letras");

        daoFacultad.insertar(f1);
        daoFacultad.insertar(f2);
//
        ArrayList<Facultad> facultades = daoFacultad.listarTodos();
        for(Facultad f : facultades){
            System.out.println("Facultad: "+f.getId_facultad() + " - " +f.getNombreFacultad()+" - "+f.getDescripcionFacultad());
        }
        System.out.println("*** LISTAR FACULTADES COMPLETADO *** ");
        System.out.println();
//
        Especialidad e1 = new Especialidad("Ingenieria informatica", "Donde estan los dibujitos");
        Especialidad e2 = new Especialidad("Ciencia politica y gobierno", "Donde estan los munequitos");

        e1.setFacultad(f1);
        e2.setFacultad(f2);

        daoEspecialidad.insertar(e1);
        daoEspecialidad.insertar(e2);
//
        ArrayList<Especialidad> especialidades = daoEspecialidad.listarTodos();
        for(Especialidad e : especialidades){
            System.out.println(e.getId_especialidad() + " - " + e.getFacultad().getNombreFacultad() + " - " +
                    e.getNombreEspecialidad() + " - " + e.getDescripcionEspecialidad());
        }
        System.out.println("*** LISTAR ESPECIALIDADES COMPLETADO ***");
        System.out.println();


        Alumno a1 = null;
        Alumno a2 = null;


        try{

            a1 = new Alumno("20142886", "yyyyyyyy", "Marco", "Bossio", "a@a.com", formato.parse("24-05-1986"),
                'M', e1, 1, "Luis Antonio", "padre", "111111111");
            a2 = new Alumno("20149999", "zzzzzzzz", "Sebastian", "Davila", "d@d.com", formato.parse("01-01-2001"),
                'F', e2, 1, "Soraya Montenegro", "madre", "999999999");

            }catch(Exception ex){
            System.out.println(ex.getMessage());
        }

        daoAlumno.insertar(a1);
        daoAlumno.insertar(a2);

//
        ArrayList<Alumno> alumnos = daoAlumno.listarTodos();
        for(Alumno a : alumnos){
            System.out.println("Alumno: "+a.getCodigoPUCP() + " " + a.getApellidos() + " " + 
                    formato.format(a.getFechaNacimiento()) + " " + a.getSexo());
            System.out.println("Facultad: " + a.getEspecialidad().getFacultad().getNombreFacultad() +
                    " - Especialidad: " + a.getEspecialidad().getNombreEspecialidad()+" - Tutor: "+a.getNombreContacto());
        }
        System.out.println("*** LISTAR ALUMNOS COMPLETADOS ***");
        System.out.println();


        //editamos algunos datos
        a1.setApellidos("APELLIDO EDITADO");
        a1.setNombreContacto("CONTACTO EDITADO");
        a1.setSexo('X');
        a1.setEspecialidad(e2); //cambia de especialidad
        
        daoAlumno.modificar(a1);
        

        alumnos = daoAlumno.listarTodos();
        for(Alumno a : alumnos){
            System.out.println("Alumno: "+a.getCodigoPUCP() + " " + a.getApellidos() + " " + 
                    formato.format(a.getFechaNacimiento()));
            System.out.println("Facultad: " + a.getEspecialidad().getFacultad().getNombreFacultad() +
                    " - Especialidad: " + a.getEspecialidad().getNombreEspecialidad()+" - Tutor: "+a.getNombreContacto());
        }
        System.out.println("*** LISTAR ALUMNOS COMPLETADO, SE MODIFICO EL PRIMER ALUMNO: APELLIDO, SEXO, NOMBRECONTACTO, ESPECIALIDAD");
        System.out.println();        
        
        //eliminamos al primer alumno de la lista
        //
        daoAlumno.eliminar(alumnos.get(0).getId_usuario());
        
        alumnos = daoAlumno.listarTodos();
        for(Alumno a : alumnos){
            System.out.println("Alumno: "+a.getCodigoPUCP() + " " + a.getApellidos() + " " + 
                    formato.format(a.getFechaNacimiento()));
            System.out.println("Facultad: " + a.getEspecialidad().getFacultad().getNombreFacultad() +
                    " - Especialidad: " + a.getEspecialidad().getNombreEspecialidad()+" - Tutor: "+a.getNombreContacto());
        }
        System.out.println("*** LISTAR ALUMNOS COMPLETADO, SE ELIMINO AL PRIMER ALUMNO ***");
        System.out.println();  
 */       
        /*
        *************************************************************************
        * ESPECIALISTAS: Insertar, Listar
        * 3 Tipos de especialistas
        *************************************************************************
        */

        Nutricionista nut1 = null;
        Nutricionista nut2 = null;


        NutricionistaDAO daoNutricionista = new NutricionistaMySQL();        

        
        try{

            nut1 = new Nutricionista("N0000001", "claveN1", "Gaston", "Acurio", "0@0.com", formato.parse("10-10-1980"),
                'M', "000000001", "Direccion Nutri1","Col Nutri1");
            nut2 = new Nutricionista("N0000002", "claveN2", "Gastona", "Acuria", "0@0.com", formato.parse("10-10-1980"),
                'F', "000000002", "Direccion Nutri2","Col Nutri2");

            }catch(Exception ex){
            System.out.println(ex.getMessage());
        }

        //daoNutricionista.insertar(nut1);
        //daoNutricionista.insertar(nut2);

        ArrayList<Nutricionista> nutricionistas = daoNutricionista.listarTodos();
        for(Nutricionista nut : nutricionistas){
            System.out.println("Nutricionista: "+nut.getCodigoPUCP() + " " + nut.getNombres()+" "+
                    nut.getApellidos() + " " + formato.format(nut.getFechaNacimiento()) + " " + nut.getSexo());
            System.out.println("Datos de contacto: " + nut.getTelefonoLaboral() + " Colegiatura: "+nut.getColegiatura());
        }
        

        System.out.println("*** LISTAR ESPECIALISTAS COMPLETADO ***");
        System.out.println();
   
    
        EspecialistaDAO  daoEspecialista = new EspecialistaMySQL();
        ArrayList<String> mensaje = daoEspecialista.mensajeEspecialistaPorID(2);
        for(String m : mensaje)
            System.out.println(m);
        
        
        /*
        //MODIFICAMOS ESPECIALISTAS
        nutricionistas.get(0).setNombres("NOMBRE_nnnnnn");
        nutricionistas.get(0).setApellidos("APELLIDO_nnnnnn");        
        nutricionistas.get(0).setTelefonoLaboral("NNNNNNNNN");
        nutricionistas.get(0).setBiografia("        Esta es una pequena biografia del nutrisor\n        Esta es la segunda linea de la bio del nutrisor");
               
        daoNutricionista.modificar(nutricionistas.get(0));
        
        nutricionistas = daoNutricionista.listarTodos();
        for(Nutricionista nut : nutricionistas){
            System.out.println("Nutricionista: "+nut.getCodigoPUCP() + " " + nut.getNombres()+" "+
                    nut.getApellidos() + " " + formato.format(nut.getFechaNacimiento()) + " " + nut.getSexo());
            System.out.println("Datos de contacto: " + nut.getTelefonoLaboral() + " Colegiatura: "+nut.getColegiatura());
            System.out.println("Biografía: \n" + nut.getBiografia());
        }

        System.out.println("*** LISTAR ESPECIALISTAS MODIFICADO COMPLETADO ***");
        System.out.println();
   
        
        
        //eliminar
        daoNutricionista.eliminar(nutricionistas.get(0).getId_usuario());

        nutricionistas = daoNutricionista.listarTodos();
        for(Nutricionista nut : nutricionistas){
            System.out.println("Nutricionista: "+nut.getCodigoPUCP() + " " + nut.getNombres()+" "+
                    nut.getApellidos() + " " + formato.format(nut.getFechaNacimiento()) + " " + nut.getSexo());
            System.out.println("Datos de contacto: " + nut.getTelefonoLaboral() + " Colegiatura: "+nut.getColegiatura());
        }

        
        System.out.println("*** LISTAR ESPECIALISTAS ELIMINADO COMPLETADO: SE ELIMINO AL PRIMER ESPECIALISTA ***");
        System.out.println();
          
        */
    }
    
}
