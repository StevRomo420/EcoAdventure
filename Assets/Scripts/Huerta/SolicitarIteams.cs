using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolicitarIteams : MonoBehaviour
{
    [SerializeField]
    public GameObject[] items;
    [SerializeField]
    public float xBoundsStart, xBoundsEnds, yBounds;
    [SerializeField]
    public float time;
    public bool Viva = true; 
    public bool Colicion = false;
    GameObject iteam;
    AnimacionesMaiz animacion;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
        animacion = GetComponent<AnimacionesMaiz>();
    }


    // Update is called once per frame

    IEnumerator SpawnRandomGameObject()
    {

       
        yield return new WaitForSeconds(time);
        
        int randomIteam = Random.Range(0, items.Length);

        if (Random.value <= items.Length)
        {
            iteam = Instantiate(items[randomIteam]) as GameObject;

            iteam.transform.position = new Vector2(Random.Range(xBoundsStart, xBoundsEnds), yBounds);
            Colicion = false;
             yield return new WaitForSeconds(time);
            Destroy(iteam);
            if (Colicion){
                Debug.Log("si");
            }
                else
                {
                animacion.Marchitar();
                time = 0;
                Viva = false;
                Debug.Log("no");
            }
        }
        if(Viva)
        {
            StartCoroutine(SpawnRandomGameObject());
        }
        


    }
    public bool ObtenerTag(string Tag)
    {
        
        return true;
    }
   
}
