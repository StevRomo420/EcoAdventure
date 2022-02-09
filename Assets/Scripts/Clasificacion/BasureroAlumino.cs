using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasureroAlumino : MonoBehaviour
{
    private Jugador p2;

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
        if (collision.tag == "Aluminio")
        {
            p2.Ganar(100);
            Destroy(collision.gameObject);
        }
        else
        {
            p2.Perder(50);
            Destroy(collision.gameObject);
        }
    }
}
