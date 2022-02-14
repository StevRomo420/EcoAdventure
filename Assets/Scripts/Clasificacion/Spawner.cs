using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] basura;
    public float xBoundsStart, xBoundsEnds, yBounds;
    public float time;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

 
    // Update is called once per frame

    IEnumerator SpawnRandomGameObject()
    {

        yield return new WaitForSeconds(time);

        int randomGarbage = Random.Range(0, basura.Length);

        if (Random.value <= basura.Length)
        {
            GameObject a = Instantiate(basura[randomGarbage]) as GameObject;

            a.transform.position = new Vector2(Random.Range(xBoundsStart, xBoundsEnds), yBounds);
        }
        StartCoroutine(SpawnRandomGameObject());


    }
}
