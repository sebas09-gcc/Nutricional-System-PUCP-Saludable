/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
 */
package pe.edu.pucp.pucpsaludable.autenticacion.model;

import java.util.Date;

public class Token
{
    private int id;
    private String codigo;
    private Date fechaHora;
    private boolean valido;
    // Constructor de clase
    public Token()
    {
    }

    public Token(String codigo, Date fechaHora)
    {
        this.codigo = codigo;
        this.fechaHora = fechaHora;
        this.valido = true;
    }

    // Setters y getters
    public int getId()
    {
        return id;
    }

    public void setId(int id)
    {
        this.id = id;
    }

    public String getCodigo()
    {
        return codigo;
    }

    public void setCodigo(String codigo)
    {
        this.codigo = codigo;
    }

    public Date getFechaHora()
    {
        return fechaHora;
    }

    public void setFechaHora(Date fechaHora)
    {
        this.fechaHora = fechaHora;
    }

    public boolean getValido()
    {
        return valido;
    }

    public void setValido(boolean valido)
    {
        this.valido = valido;
    }

    // Métodos
    // Retorna el ID del token registrado o cero en caso de error
    public int registrarToken()
    {
        return 0;
    }

    // Retorna true en caso de invalidación de token exitosa o false en caso de error
    public boolean invalidarToken()
    {
        return true;
    }
}
