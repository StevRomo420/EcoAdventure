using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nubes : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
   
    

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
       

        
    }


    void Update()
    {
        if (transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }

    }
}
