using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColicionesBasura : MonoBehaviour
{
    public SpawnerBarco spawner;
    public Jugador jugador;
    public int puntos;
   

    private void Start()
    {
        GameObject spawn = GameObject.Find("Spawner");
        spawner = spawn.GetComponent<SpawnerBarco>();
        GameObject player = GameObject.Find("Jugador");
        jugador = player.GetComponent<Jugador>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Barco")
        {

                spawner.Borrar();
                jugador.Ganar(puntos);
            
           
           
            
        }
    }

}
