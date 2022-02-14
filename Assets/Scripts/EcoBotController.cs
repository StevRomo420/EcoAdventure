using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EcoBotController : MonoBehaviour
{

    Jugador p2;

    Animator animator;
    //Convencion de constantes en c
    const string PUNTO = "punto";
    const string NO_PUNTO = "noPunto";
    const string RETORNO = "retorno";
    // Start is called before the first frame update
    void Start()
    {
        GameObject prueba = GameObject.Find("Jugador");
        p2 = prueba.GetComponent<Jugador>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool(PUNTO, p2.ObtenerPunto());
        animator.SetBool(NO_PUNTO, p2.PerderPunto());
      

    }

    void FixedUpdate()
    {
        animator.SetBool(RETORNO, true);
    }


}
