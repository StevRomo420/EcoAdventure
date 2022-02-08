using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClasificacionManager : MonoBehaviour
{

    private Rigidbody2D basuraRigibodoy;

    Animator animator;

    public float velocidadDeMovimiento = 2f;

    public int puntos;


 


    private void Awake()
    {
        basuraRigibodoy = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
        if (GameManager.sharedInstance.estadoActual == EstadoDelJuego.enJuego)
        {
            if (basuraRigibodoy.velocity.x < velocidadDeMovimiento)
            {
                float movimiento = Input.GetAxis("Horizontal");
                basuraRigibodoy.velocity = new Vector2(movimiento*velocidadDeMovimiento,basuraRigibodoy.velocity.y);

            }
        }
        else
        {
            basuraRigibodoy.velocity = new Vector2(0, basuraRigibodoy.velocity.y);
        }
    }

    public void Ganar()
    {
        puntos += 1 * 100;
    }

   public void Fallar()
    {
        puntos -= +1 * 50;
    }

   

}
