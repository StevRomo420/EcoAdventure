using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnerBarco : MonoBehaviour
{

    public GameObject[] basuraMar;
    public GameObject[] posicionSpawner;
    private Vector2 posicionFinal;
    private GameObject laBasura;
    public Jugador jugador;



    private void Start()
    { 
        SpawnRandonGarbage();

        GameObject player = GameObject.Find("Jugador");
        jugador = player.GetComponent<Jugador>();
    }

    public void SpawnRandonGarbage()
    {
        if (jugador.vidaRestante() != 0 && jugador.vidaRestante()>0)
        {


            SpawnPositions();

            int randomSeaGarbage = Random.Range(0, basuraMar.Length);

            if (Random.value <= basuraMar.Length)
            {
                laBasura = Instantiate(basuraMar[randomSeaGarbage]);

                laBasura.transform.position = new Vector2(posicionFinal.x, posicionFinal.y);
            }
        }

    }

    public void SpawnPositions()
    {
        int randomPosition = Random.Range(0, posicionSpawner.Length);
      
        if (Random.value <= posicionSpawner.Length)
        {
            Vector2 laPosicion = posicionSpawner[randomPosition].transform.position;

            posicionFinal = laPosicion;
        }
      
    }


    public void Borrar()
    {
      
            Destroy(laBasura);

            SpawnRandonGarbage();
        
    }
   



}
