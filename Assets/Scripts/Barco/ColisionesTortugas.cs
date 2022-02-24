using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionesTortugas : MonoBehaviour
{
   
    public Jugador jugador;

   public Animator animator;

    private string CRASH = "live";


    private void Start()
    {
        
        GameObject player = GameObject.Find("Jugador");
        jugador = player.GetComponent<Jugador>();
        animator = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "Barco" && jugador.vidaRestante()>0)
        {
            
            jugador.Perder();
            animator.SetBool(CRASH, true);

        }
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Barco")
        {

            animator.SetBool(CRASH, false);

        }
    }
}
