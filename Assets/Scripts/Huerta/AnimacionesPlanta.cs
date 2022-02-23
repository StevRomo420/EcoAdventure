using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesPlanta : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public Jugador p2;
    //Convencion de constantes en c
    const string FASE2 = "Fase2";
    const string FASE3 = "Fase3";
    const string COSECHA = "Cosecha";
    const string MARCHITO = "Marchita";
    const string INICIO = "Inicio";
    public int Desarrolla = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
        GameObject prueba = GameObject.Find("Jugador");
        p2 = prueba.GetComponent<Jugador>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Marchitar()
    {
        p2.Perder();
        animator.SetTrigger(MARCHITO);

    }
    public void Crecer()
    {
        p2.Ganar(100);
        switch (Desarrolla)
        {
            case 0:
                animator.SetTrigger(FASE2);
                Desarrolla++;
                break;
            case 1:
                animator.SetTrigger(FASE3);
                Desarrolla++;
                break;
            case 2:
                animator.SetTrigger(COSECHA);
                Desarrolla++;
                break;
            case 3:
                animator.SetTrigger(INICIO);
                Desarrolla = 0;
                break;
        }
    }
}
