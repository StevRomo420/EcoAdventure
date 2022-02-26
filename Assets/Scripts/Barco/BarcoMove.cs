using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BarcoMove : MonoBehaviour
{

    Animator animator;
    public Rigidbody2D rb;
    public float moveSpeed;
   
    public float rotationSpeed;

    private Vector2 moveDirection;

    private string MOVIMIENTO_BARCO = "Move";

    public Jugador player;

    Vector3 mousePosition;





  

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        GameObject jugador = GameObject.Find("Jugador");
        player = jugador.GetComponent<Jugador>();
    }

    // Update is called once per frame
    void Update()
    {
         Entradas();
    }

    void FixedUpdate()
    {
        Move();
    }

  
    void Entradas()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moveDirection = (mousePosition - transform.position).normalized;

        }else if (moveDirection != Vector2.zero)
        {
        Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, moveDirection);
         transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            animator.SetBool(MOVIMIENTO_BARCO,true);
        }
        else
        {
            animator.SetBool(MOVIMIENTO_BARCO,false);
        }


    }

    void Move()
    {
       
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Remolino")
        {
            moveSpeed = 6f;
        }else if (collision.tag == "Basura")
        {
            Destroy(collision.gameObject);
        }

        

     
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Remolino")
        {
            moveSpeed = 12f;
        }
    }


}
