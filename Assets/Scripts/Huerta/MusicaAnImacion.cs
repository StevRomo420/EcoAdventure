using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MusicaAnImacion : MonoBehaviour
{
    Animator animator;
    const string MUSICA_PLAY = "musicaPlay";
    const string MUSICA_PAUSA= "musicaPausa";
    public Vector3 posicionInicio = new Vector3(0, 0, 0);
    public bool quieto = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        posicionInicio = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        animator.SetTrigger(MUSICA_PAUSA);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Planta")
        {
            quieto = true;
            animator.SetTrigger(MUSICA_PLAY);

            
            quieto = false;
        }
        else
        {
            transform.position = posicionInicio;
        }
    }
  
}
