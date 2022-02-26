using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClouds : MonoBehaviour
{

    public float time;
    public GameObject[] clouds;
    public float xBounds, yBoundsStart, yBoundsEnd;


    void Start()
    {
        StartCoroutine(SpawnerClouds());
    }

   
    IEnumerator SpawnerClouds()
    {
        
        int randomCloud = Random.Range(0, clouds.Length);

        if (Random.value <= clouds.Length)
        {
           
                GameObject a = Instantiate(clouds[randomCloud]);

                a.transform.position = new Vector2(xBounds, Random.Range(yBoundsStart, yBoundsEnd)+0.5f);
            
        }
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnerClouds());

    }

}
