using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColicionPlanta : MonoBehaviour
{

    SolicitarIteams Items;
    AnimacionesPlanta animacion;
    public string Nombre;
    // Start is called before the first frame update
    void Start()
    {
        GameObject prueba = GameObject.Find(Nombre);
        Items = prueba.GetComponent<SolicitarIteams>();
        animacion = GetComponent<AnimacionesPlanta>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Items.Colicion = true;
        if (Items.ObtenerTag() == "") { }
        else
        {
            if (collision.tag == Items.ObtenerTag())
            {

                animacion.Crecer();
                Items.DestruirOdgeto();
                // p2.Ganar(100);
                //Destroy(collision.gameObject);

            }
            else
            {
                animacion.Marchitar();
                Items.DestruirOdgeto();
                Items.time = 0;
                Items.Viva = false;
                //p2.Perder();
                //Destroy(collision.gameObject);
            }
        }
    }
}
