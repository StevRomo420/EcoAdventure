using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClasificacionManager : MonoBehaviour
{

    private Rigidbody2D basuraRigibodoy;

    Animator animator;

    public float velocidadDeMovimiento = 2f;

    public Jugador jugador;


 


    private void Awake()
    {
        
        basuraRigibodoy = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
        GameObject player = GameObject.Find("Jugador");
        jugador = player.GetComponent<Jugador>();
    }

    // Update is called once per frame
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

    

   

}
