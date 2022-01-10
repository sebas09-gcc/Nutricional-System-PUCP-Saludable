/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 29/09/2021
Hora: 04:44:09 AM
*/

package pe.edu.pucp.pucpsaludable.main;

import java.util.ArrayList;
import pe.edu.pucp.pucpsaludable.receta.model.Ingrediente;
import pe.edu.pucp.pucpsaludable.receta.model.PresetReceta;
import pe.edu.pucp.pucpsaludable.receta.model.Receta;
import pe.edu.pucp.pucpsaludable.recetas.dao.IngredienteDAO;
import pe.edu.pucp.pucpsaludable.recetas.dao.PresetRecetaDAO;
import pe.edu.pucp.pucpsaludable.recetas.dao.RecetaDAO;
import pe.edu.pucp.pucpsaludable.recetas.mysql.IngredienteMySQL;
import pe.edu.pucp.pucpsaludable.recetas.mysql.PresetRecetaMySQL;
import pe.edu.pucp.pucpsaludable.recetas.mysql.RecetaMySQL;


public class Principal_recetas {

    public static void main(String[] args){
    
    
    /*
    *************************************************************************
    * RECETA,PRESETRECETA,INGREDIENTE: Insertar, Listar
    * 
    *   
    *   
    *   
    *************************************************************************
    */
    
    
    
    RecetaDAO DAOReceta= new RecetaMySQL();
    PresetRecetaDAO DAOPresetReceta = new PresetRecetaMySQL();
    IngredienteDAO DAOIngrediente = new IngredienteMySQL();
    
    Ingrediente ing1= new Ingrediente("naranja","gramos",100,53,false,true,false,false);
    Ingrediente ing2= new Ingrediente("arroz","gramos",100,130,false,false,true,false);
    Ingrediente ing3= new Ingrediente("pollo","gramos",100,200,true,false,false,false);
    Ingrediente ing4= new Ingrediente("papa","gramos",80,53,false,false,false,false);
    
    
    DAOIngrediente.insertar(ing1);
    DAOIngrediente.insertar(ing2);
    DAOIngrediente.insertar(ing3);
    DAOIngrediente.insertar(ing4);
     
    
    IngredienteDAO DAOIngrediente2 = new IngredienteMySQL();
    ArrayList<Ingrediente> ingredientes = DAOIngrediente2.listarTodos();
    /////////////////////////// 
    //ArrayList<Facultad> facultades = daoFacultad.listarTodos();
    for(Ingrediente f : ingredientes){
        System.out.println("Nombre: "+ f.getNombre() + "- Kcal: " +f.getKcal()+ "-cantidad: " + f.getCantidad() );
    }
    System.out.println("Listar ingredientes completado");
    System.out.println();
    
    
    Receta r1 = new Receta("Arroz con pollo","plato a base arroz verde con pollo ","pasos a seguir",1);
    Receta r2 = new Receta("Arroz chaufa","plato a base arroz con varios ingredientes y al sillao ","pasos a seguir",1);
    Receta r3 = new Receta("Hamburguesa","plato a base de pan, relleno de carne,lechuga y demas ","pasos a seguir",1);
    
     
     
    DAOReceta.insertar(r1);
    DAOReceta.insertar(r2);
    DAOReceta.insertar(r3);
    
    RecetaDAO DAOReceta2 = new RecetaMySQL();
    ArrayList<Receta> recetas = DAOReceta2.listarTodos();
    for(Receta f : recetas){
        System.out.println("ID: "+ f.getIdReceta() + " - Nombre: "+ f.getNombre() );
    }
    System.out.println("Listar recetas completado");
    System.out.println();
    
    
    
    PresetReceta pr1 = new PresetReceta("Arroz con pollo hipercalorico",1600);
    PresetReceta pr2 = new PresetReceta("Arroz con pollo standard",1200);
    PresetReceta pr3 = new PresetReceta("Arroz chaufa standard",1105);
    PresetReceta pr4 = new PresetReceta("Arroz chaufa hipocalorico",950);
    
    DAOPresetReceta.insertar(pr1);
    DAOPresetReceta.insertar(pr2);
    DAOPresetReceta.insertar(pr3);
    DAOPresetReceta.insertar(pr4);
    
    PresetRecetaDAO DAOPresetReceta2 = new PresetRecetaMySQL();
    ArrayList<PresetReceta> presetRecetas = DAOPresetReceta2.listarTodos();
    for(PresetReceta f : presetRecetas){
        System.out.println("ID: "+ f.getIdPresetReceta() + " - Nombre: "+ f.getNombre() + " - kcal: "  + f.getKcal());
    }
    System.out.println("Listar presetRecetas completado");
    System.out.println();
    
    }
    
    
    
}
