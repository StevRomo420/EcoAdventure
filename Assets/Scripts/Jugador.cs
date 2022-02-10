using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour

{
    public int vida=0;
    public int puntos=0;




    public bool punto=false;
    public bool noPunto=false;


    // Start is called before the first frame update
    void Start()
    {

        
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Ganar(int puntosObtenidos)
    {
        this.puntos += puntosObtenidos;
        this.punto = true;
        this.noPunto = false;
        
    }

    public void Perder(int puntosObtenidos)
    {
        this.puntos -= puntosObtenidos;
        this.vida = vida - 1;
        this.noPunto = true;
        this.punto = false;
       
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
