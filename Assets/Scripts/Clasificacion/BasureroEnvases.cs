using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasureroEnvases : MonoBehaviour
{

    private Jugador jugador;
    public Spawner elemento;

    void Start()
    {
        GameObject player = GameObject.Find("Jugador");
        jugador = player.GetComponent<Jugador>();

        GameObject basura = GameObject.Find("SpawPonit");
        elemento = basura.GetComponent<Spawner>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Envases")
        {

            jugador.Ganar(100);

            Destroy(collision.gameObject);
            elemento.SpawnRandomGameObject();
        }
        else
        {
            jugador.Perder();

            Destroy(collision.gameObject);
            elemento.SpawnRandomGameObject();
        }
    }
}
