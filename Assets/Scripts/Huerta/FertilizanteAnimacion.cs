using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FertilizanteAnimacion : MonoBehaviour
{
    Animator animator;
    const string FERTILIZANTE_PLAY = "fertilizantePlay";
    const string FERTILIZANTE_PAUSA = "fertilizantePausa";
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
        animator.SetTrigger(FERTILIZANTE_PAUSA);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Planta")
        {
            quieto = true;
            animator.SetTrigger(FERTILIZANTE_PLAY);


            quieto = false;
        }
        else
        {
            transform.position = posicionInicio;
        }
    }
}
