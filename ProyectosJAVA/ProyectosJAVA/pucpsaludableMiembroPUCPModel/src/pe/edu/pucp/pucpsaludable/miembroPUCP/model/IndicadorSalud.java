/*
    Proyecto : Sistema de gestion de salud
    Grupo : Martin Router King
*/

package pe.edu.pucp.pucpsaludable.miembroPUCP.model;


public class IndicadorSalud {
    
    private int fid_alumno;
    private boolean cafe;
    private boolean alcohol;
    private boolean tabaco;
    private boolean diarrea;
    private boolean estrenimiento;
    private boolean celiaquia;
    private boolean gastritis;
    private boolean ulcera;
    private boolean nausea;
    private boolean pirosis;
    private boolean vomito;
    private boolean colitis;
    private boolean dentadura;
    private boolean sensibilidadDental;
    private boolean laxantes;
    private boolean diureticos;
    private boolean antiacidos;
    private boolean analgesicos;
    private boolean embarazo;
    private boolean anticonceptivosOrales;
    private boolean climaterio;
    private boolean terapiaHormonal;
    private String cirugiasPrevias;
    private boolean aFObesidad;
    private boolean aFDiabetes;
    private boolean aFHTA;
    private boolean aFCancer;
    private boolean aFHipercolesterolemia;
    private boolean aFHipertrigliceridemia;
    private String alergiasMed;
    
    //constructor vacio
    public IndicadorSalud(){}

    public IndicadorSalud(int fid_alumno, boolean cafe, boolean alcohol, boolean tabaco, boolean diarrea, boolean estrenimiento, boolean celiaquia, boolean gastritis, boolean ulcera, boolean nausea, boolean pirosis, boolean vomito, boolean colitis, boolean dentadura, boolean sensibilidadDental, boolean laxantes, boolean diureticos, boolean antiacidos, boolean analgesicos, boolean embarazo, boolean anticonceptivosOrales, boolean climaterio, boolean terapiaHormonal, String cirugiasPrevias, boolean aFObesidad, boolean aFDiabetes, boolean aFHTA, boolean aFCancer, boolean aFHipercolesterolemia, boolean aFHipertrigliceridemia, String alergiasMed) {
        this.fid_alumno = fid_alumno;
        this.cafe = cafe;
        this.alcohol = alcohol;
        this.tabaco = tabaco;
        this.diarrea = diarrea;
        this.estrenimiento = estrenimiento;
        this.celiaquia = celiaquia;
        this.gastritis = gastritis;
        this.ulcera = ulcera;
        this.nausea = nausea;
        this.pirosis = pirosis;
        this.vomito = vomito;
        this.colitis = colitis;
        this.dentadura = dentadura;
        this.sensibilidadDental = sensibilidadDental;
        this.laxantes = laxantes;
        this.diureticos = diureticos;
        this.antiacidos = antiacidos;
        this.analgesicos = analgesicos;
        this.embarazo = embarazo;
        this.anticonceptivosOrales = anticonceptivosOrales;
        this.climaterio = climaterio;
        this.terapiaHormonal = terapiaHormonal;
        this.cirugiasPrevias = cirugiasPrevias;
        this.aFObesidad = aFObesidad;
        this.aFDiabetes = aFDiabetes;
        this.aFHTA = aFHTA;
        this.aFCancer = aFCancer;
        this.aFHipercolesterolemia = aFHipercolesterolemia;
        this.aFHipertrigliceridemia = aFHipertrigliceridemia;
        this.alergiasMed = alergiasMed;
    }
    
    //getset
    
    public String getAlergiasMed() {    
        return alergiasMed;
    }    

    public void setAlergiasMed(String alergiasMed) {
        this.alergiasMed = alergiasMed;
    }

    public int getFid_alumno() {
        return fid_alumno;
    }

    public void setFid_alumno(int fid_alumno) {
        this.fid_alumno = fid_alumno;
    }

    public boolean isCafe() {
        return cafe;
    }

    public void setCafe(boolean cafe) {
        this.cafe = cafe;
    }

    public boolean isAlcohol() {
        return alcohol;
    }

    public void setAlcohol(boolean alcohol) {
        this.alcohol = alcohol;
    }

    public boolean isTabaco() {
        return tabaco;
    }

    //set y get
    public void setTabaco(boolean tabaco) {
        this.tabaco = tabaco;
    }

    public boolean isDiarrea() {
        return diarrea;
    }

    public void setDiarrea(boolean diarrea) {
        this.diarrea = diarrea;
    }

    public boolean isEstrenimiento() {
        return estrenimiento;
    }

    public void setEstrenimiento(boolean estrenimiento) {
        this.estrenimiento = estrenimiento;
    }

    public boolean isCeliaquia() {
        return celiaquia;
    }

    public void setCeliaquia(boolean celiaquia) {
        this.celiaquia = celiaquia;
    }

    public boolean isGastritis() {
        return gastritis;
    }

    public void setGastritis(boolean gastritis) {
        this.gastritis = gastritis;
    }

    public boolean isUlcera() {
        return ulcera;
    }

    public void setUlcera(boolean ulcera) {
        this.ulcera = ulcera;
    }

    public boolean isNausea() {
        return nausea;
    }

    public void setNausea(boolean nausea) {
        this.nausea = nausea;
    }

    public boolean isPirosis() {
        return pirosis;
    }

    public void setPirosis(boolean pirosis) {
        this.pirosis = pirosis;
    }

    public boolean isVomito() {
        return vomito;
    }

    public void setVomito(boolean vomito) {
        this.vomito = vomito;
    }

    public boolean isColitis() {
        return colitis;
    }

    public void setColitis(boolean colitis) {
        this.colitis = colitis;
    }

    public boolean isDentadura() {
        return dentadura;
    }

    public void setDentadura(boolean dentadura) {
        this.dentadura = dentadura;
    }

    public boolean isSensibilidadDental() {
        return sensibilidadDental;
    }

    public void setSensibilidadDental(boolean sensibilidadDental) {
        this.sensibilidadDental = sensibilidadDental;
    }

    public boolean isLaxantes() {
        return laxantes;
    }

    public void setLaxantes(boolean laxantes) {
        this.laxantes = laxantes;
    }

    public boolean isDiureticos() {
        return diureticos;
    }

    public void setDiureticos(boolean diureticos) {
        this.diureticos = diureticos;
    }

    public boolean isAntiacidos() {
        return antiacidos;
    }

    public void setAntiacidos(boolean antiacidos) {
        this.antiacidos = antiacidos;
    }

    public boolean isAnalgesicos() {
        return analgesicos;
    }

    public void setAnalgesicos(boolean analgesicos) {
        this.analgesicos = analgesicos;
    }

    public boolean isEmbarazo() {
        return embarazo;
    }

    public void setEmbarazo(boolean embarazo) {
        this.embarazo = embarazo;
    }

    public boolean isAnticonceptivosOrales() {
        return anticonceptivosOrales;
    }

    public void setAnticonceptivosOrales(boolean anticonceptivosOrales) {
        this.anticonceptivosOrales = anticonceptivosOrales;
    }

    public boolean isClimaterio() {
        return climaterio;
    }

    public void setClimaterio(boolean climaterio) {
        this.climaterio = climaterio;
    }

    public boolean isTerapiaHormonal() {
        return terapiaHormonal;
    }

    public void setTerapiaHormonal(boolean terapiaHormonal) {
        this.terapiaHormonal = terapiaHormonal;
    }

    public String getCirugiasPrevias() {
        return cirugiasPrevias;
    }

    public void setCirugiasPrevias(String cirugiasPrevias) {
        this.cirugiasPrevias = cirugiasPrevias;
    }

    public boolean isaFObesidad() {
        return aFObesidad;
    }

    public void setaFObesidad(boolean aFObesidad) {
        this.aFObesidad = aFObesidad;
    }

    public boolean isaFDiabetes() {
        return aFDiabetes;
    }

    public void setaFDiabetes(boolean aFDiabetes) {
        this.aFDiabetes = aFDiabetes;
    }

    public boolean isaFHTA() {
        return aFHTA;
    }

    public void setaFHTA(boolean aFHTA) {
        this.aFHTA = aFHTA;
    }

    public boolean isaFCancer() {
        return aFCancer;
    }

    public void setaFCancer(boolean aFCancer) {
        this.aFCancer = aFCancer;
    }

    public boolean isaFHipercolesterolemia() {
        return aFHipercolesterolemia;
    }

    public void setaFHipercolesterolemia(boolean aFHipercolesterolemia) {
        this.aFHipercolesterolemia = aFHipercolesterolemia;
    }

    public boolean isaFHipertrigliceridemia() {
        return aFHipertrigliceridemia;
    }

    public void setaFHipertrigliceridemia(boolean aFHipertrigliceridemia) {
        this.aFHipertrigliceridemia = aFHipertrigliceridemia;
    }
    
}
