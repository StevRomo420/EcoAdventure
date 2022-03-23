using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TortugaMove : MonoBehaviour
{
    public float moveSpeed;

    public Vector3[] posiciones;
  
    public int index;
    public int rotationSpeed;
    public SpriteRenderer cambiador;
    public Jugador jugador;

    void Start()
    {
        GameObject player = GameObject.Find("Jugador");
        jugador = player.GetComponent<Jugador>();
    }

    
    void Update()
    {
        if (jugador.vidaRestante() != 0)
        {


            transform.position = Vector2.MoveTowards(transform.position, posiciones[index], Time.deltaTime * moveSpeed);


            if (transform.position == posiciones[index])
            {
                if (index == posiciones.Length - 1)
                {
                    index = 0;
                    cambiador.flipX = false;
                }
                else
                {
                    index++;
                    cambiador.flipX = true;

                }

            }

        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, posiciones[index], Time.deltaTime * 0);
        }
        
    }

   

}

