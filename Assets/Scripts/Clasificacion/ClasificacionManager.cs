using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClasificacionManager : MonoBehaviour
{

    private Rigidbody2D basuraRigibodoy;

    Animator animator;

    public float velocidadDeMovimiento = 2f;

    public Jugador jugador;

    bool subirDificultad = false;


 


    private void Awake()
    {
        
        basuraRigibodoy = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

 
    void Start()
    {
       
        GameObject player = GameObject.Find("Jugador");
        jugador = player.GetComponent<Jugador>();
    }

    
    void Update()
    {

        if (Input.GetButtonDown("Horizontal"))
        {
            MovimientoDeLaBasura();
        }
       
    }

    private void FixedUpdate()
    {
        MovimientoDeLaBasura();
        MasDificultad();
    }

    void MovimientoDeLaBasura()
    {
        if (jugador.vidaRestante() > 0)
        {
            if (basuraRigibodoy.velocity.x < velocidadDeMovimiento)
            {
                float movimiento = Input.GetAxis("Horizontal");
                basuraRigibodoy.velocity = new Vector2(movimiento * velocidadDeMovimiento, basuraRigibodoy.velocity.y);

            }
        }
        else {
            basuraRigibodoy.velocity = new Vector2(0, 0);
        }
       
              
    }

    void MasDificultad()
    {
        if (jugador.puntos >= 1000)
        {
            subirDificultad = true;
            if (subirDificultad == true)
            {
                basuraRigibodoy.gravityScale = 1f;
                subirDificultad = false;
            }
        }else if (jugador.puntos >= 2000)
        {
            subirDificultad = true;
            if (subirDificultad == true)
            {
                basuraRigibodoy.gravityScale = 2f; ;
                subirDificultad = false;
            }
        }
      


    }

    

   

}
