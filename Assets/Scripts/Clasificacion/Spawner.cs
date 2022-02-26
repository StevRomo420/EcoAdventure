using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] basura;
    public float xBoundsStart, xBoundsEnds, yBounds;
    public float time;



    void Start()
    {
        SpawnRandomGameObject();
    }

 

    public void SpawnRandomGameObject()
    {

        int randomGarbage = Random.Range(0, basura.Length);

        if (Random.value <= basura.Length)
        {
            GameObject a = Instantiate(basura[randomGarbage]);

            a.transform.position = new Vector2(Random.Range(xBoundsStart, xBoundsEnds), yBounds);
            
        }
       

    }

   
}
