using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpawnerBarco : MonoBehaviour
{

    public GameObject[] basuraMar;
    public GameObject[] posicionSpawner;
    private Vector2 posicionFinal;
    private GameObject laBasura;


 

    private void Start()
    { 
        SpawnRandonGarbage();
    }

    public void SpawnRandonGarbage()
    {
        SpawnPositions();

        int randomSeaGarbage = Random.Range(0, basuraMar.Length);

        if (Random.value <= basuraMar.Length)
        {
            laBasura = Instantiate(basuraMar[randomSeaGarbage]);

            laBasura.transform.position = new Vector2(posicionFinal.x,posicionFinal.y);
        }
    }

    public void SpawnPositions()
    {
        int randomPosition = Random.Range(0, posicionSpawner.Length);
        Debug.Log("El numero es : "+randomPosition);
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
