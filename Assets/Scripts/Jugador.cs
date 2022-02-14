using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour

{
    public int vida=0;
    public int puntos=0;




    public bool punto=false;
    public bool noPunto=false;
    public bool retorno = false;


   

    public void Ganar(int puntosObtenidos)
    {
        this.puntos += puntosObtenidos;
        this.punto = true;
        this.noPunto = false;
        AudioManager.sharedInstance.PlayAudio("Ganar");
        
    }

    public void Perder()
    {
        this.vida = vida - 1;
        this.noPunto = true;
        this.punto = false;
        AudioManager.sharedInstance.PlayAudio("Perder");

    }

    public int totalDePuntos()
    {
        return puntos;
    }

    public int vidaRestante()
    {
        return vida;
    }

    public bool ObtenerPunto()
    {
        return punto;
    }

    public bool PerderPunto()
    {
        return noPunto;
    }




}
