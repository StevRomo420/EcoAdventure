using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColicionMaiz : MonoBehaviour
{
    SolicitarIteams Items;
    AnimacionesMaiz animacion;
    // Start is called before the first frame update
    void Start()
    {
        GameObject prueba = GameObject.Find("Maiz");
        Items = prueba.GetComponent<SolicitarIteams>();
        animacion = GetComponent<AnimacionesMaiz>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Items.Colicion = true;
       
            if ( Items.ObtenerTag(collision.tag))
            {
                animacion.Crecer();
                // p2.Ganar(100);
                //Destroy(collision.gameObject);

            }
            else
            {
                animacion.Marchitar();
                Items.time = 0;
                Items.Viva = false;
                //p2.Perder();
                //Destroy(collision.gameObject);
            }
        
    }
}
