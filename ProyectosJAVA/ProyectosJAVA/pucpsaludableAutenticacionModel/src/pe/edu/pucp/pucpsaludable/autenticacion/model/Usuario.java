/*
Autor: Marco Bossio Principe
Codigo: 20142886
Fecha: 15/09/2021
Hora: 04:15:55 PM
*/

package pe.edu.pucp.pucpsaludable.autenticacion.model;

import java.util.Date;

public class Usuario {
    private int id_usuario;
    private String codigoPUCP; //obligatorio
    private String contrasena; //obligatorio
    private String nombres; //obligatorio
    private String apellidos; //obligatorio
    private String emailPUCP; //obligatorio
    private String emailPersonal;
    private String telefonoMovil;
    private Date fechaNacimiento; //obligatorio
    private byte[] fotoSrc;
    private char sexo; //obligatorio
    private int estado; //obligatorio

    // Constructor de la clase
    
    public Usuario(){}  

    public Usuario(String codigoPUCP, String contrasena, String nombres, String apellidos, 
            String emailPUCP, Date fechaNacimiento, char sexo) {
        this.codigoPUCP = codigoPUCP;
        this.contrasena = contrasena;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.emailPUCP = emailPUCP;
        this.fechaNacimiento = fechaNacimiento;
        this.sexo = sexo;
        this.estado = 1;
    }
    
    
    // Setters y getters

    public int getId_usuario() {
        return id_usuario;
    }

    public void setId_usuario(int id_usuario) {
        this.id_usuario = id_usuario;
    }
    
    public String getCodigoPUCP() {
        return codigoPUCP;
    }

    public void setCodigoPUCP(String codigoPUCP) {
        this.codigoPUCP = codigoPUCP;
    }

    public String getContrasena() {
        return contrasena;
    }

    public void setContrasena(String contrasena) {
        this.contrasena = contrasena;
    }

    public String getNombreCompleto() {
        return apellidos + ", " + nombres;
    }

    public void setNombreCompleto(String nombreCompleto) {
        return;
    }

    public String getNombres() {
        return nombres;
    }

    public void setNombres(String nombres) {
        this.nombres = nombres;
    }

    public String getApellidos() {
        return apellidos;
    }

    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }

    public String getEmailPUCP() {
        return emailPUCP;
    }

    public void setEmailPUCP(String emailPUCP) {
        this.emailPUCP = emailPUCP;
    }

    public String getEmailPersonal() {
        return emailPersonal;
    }

    public void setEmailPersonal(String emailPersonal) {
        this.emailPersonal = emailPersonal;
    }

    public String getTelefonoMovil() {
        return telefonoMovil;
    }

    public void setTelefonoMovil(String telefonoMovil) {
        this.telefonoMovil = telefonoMovil;
    }

    public Date getFechaNacimiento() {
        return fechaNacimiento;
    }

    public void setFechaNacimiento(Date fechaNacimiento) {
        this.fechaNacimiento = fechaNacimiento;
    }



    public char getSexo() {
        return sexo;
    }

    public void setSexo(char sexo) {
        this.sexo = sexo;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }

    public byte[] getFotoSrc() {
        return fotoSrc;
    }

    public void setFotoSrc(byte[] fotoSrc) {
        this.fotoSrc = fotoSrc;
    }
}
