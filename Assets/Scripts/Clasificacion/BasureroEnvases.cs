using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasureroEnvases : MonoBehaviour
{
    public Jugador p2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject prueba = GameObject.Find("Jugador");
        p2 = prueba.GetComponent<Jugador>();

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Envases")
        {

            p2.Ganar(100);

            Destroy(collision.gameObject);
        }
        else
        {
            p2.Perder();

            Destroy(collision.gameObject);
        }
    }
}
