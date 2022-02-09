using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour

{
    public int vida=0;
    public int puntos=0;
 
  

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
    }

    public void Perder(int puntosObtenidos)
    {
        this.puntos -= puntosObtenidos;
    }




}
