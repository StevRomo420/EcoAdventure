using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DesplegarAnimacion : MonoBehaviour
{
   
    
    public GameObject items;
    GameObject item;
    public GameObject[] posicionSpawner;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 laPosicion;
        if (collision.tag == "Maiz")
        {
            item = Instantiate(items) as GameObject;
            laPosicion = posicionSpawner[3].transform.position;
            item.transform.position = new Vector2(laPosicion.x, laPosicion.y);

            Destroy(item, 2.2F);
            
            
        }
        if (collision.tag == "Maiz(1)")
        {
            item = Instantiate(items) as GameObject;
            laPosicion = posicionSpawner[1].transform.position;
            item.transform.position = new Vector2(laPosicion.x, laPosicion.y);

            Destroy(item, 2.2F);


        }
        if (collision.tag == "Chile")
        {
            item = Instantiate(items) as GameObject;
            laPosicion = posicionSpawner[2].transform.position;
            item.transform.position = new Vector2(laPosicion.x, laPosicion.y);

            Destroy(item, 2.2F);


        }
        if (collision.tag == "Tomate")
        {
            item = Instantiate(items) as GameObject;
            laPosicion = posicionSpawner[0].transform.position;
            item.transform.position = new Vector2(laPosicion.x, laPosicion.y);

            Destroy(item, 2.2F);


        }
    }
  
}
