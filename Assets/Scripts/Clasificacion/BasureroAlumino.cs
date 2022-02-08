using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasureroAlumino : MonoBehaviour
{
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
        if (collision.tag == "Aluminio")
        {
            ClasificacionManager controller = collision.GetComponent<ClasificacionManager>();
            controller.Ganar();
            Destroy(collision.gameObject);
        }
        else
        {
            ClasificacionManager controller = collision.GetComponent<ClasificacionManager>();
            controller.Fallar();
            Destroy(collision.gameObject);
        }
    }
}
