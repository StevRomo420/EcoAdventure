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
    string Tag = "";
    GameObject iteam;
    AnimacionesPlanta animacion;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
        animacion = GetComponent<AnimacionesPlanta>();
    }


    // Update is called once per frame

    IEnumerator SpawnRandomGameObject()
    {

        float randomTime = Random.Range(time, time * 2);
        yield return new WaitForSeconds(randomTime);
       
        
        int randomIteam = Random.Range(0, items.Length);

        if (Random.value <= items.Length)
        {
            iteam = Instantiate(items[randomIteam]) as GameObject;

            iteam.transform.position = new Vector2(Random.Range(xBoundsStart, xBoundsEnds), yBounds);
            Tag = iteam.tag;
            Colicion = false;
             yield return new WaitForSeconds(time);
            
            DestruirOdgeto();
            Tag = "";
            if (Colicion){
               
            }
                else
                {
                animacion.Marchitar();
                time = 0;
                Viva = false;
                
            }
        }
        if(Viva)
        {
            StartCoroutine(SpawnRandomGameObject());
        }
        


    }
    public string ObtenerTag()
    {
        
        return Tag;
    }
    public void DestruirOdgeto()
    {
        Tag = "";
        Destroy(iteam);
    }

}
