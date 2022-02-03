using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasureroEnvases : MonoBehaviour
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
        if (collision.tag == "Envaces")
        {
            ClasificacionManager controller = collision.GetComponent<ClasificacionManager>();
            controller.Ganar();
        }
        else
        {
            ClasificacionManager controller = collision.GetComponent<ClasificacionManager>();
            controller.Fallar();
        }
    }
}
