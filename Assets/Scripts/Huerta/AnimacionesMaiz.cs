using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionesMaiz : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    //Convencion de constantes en c
    const string MAIZ_FASE2 = "maizFase2";
    const string MAIZ_FASE3 = "maizFase3";
    const string MAIZ_COSECHA = "maizCosecha";
    const string MAIZ_MARCHITO = "maizMarchita";
    public int Desarrolla = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Marchitar()
    {
        animator.SetTrigger(MAIZ_MARCHITO);

    }
    public void Crecer()
    {

        switch (Desarrolla)
        {
            case 0:
                animator.SetTrigger(MAIZ_FASE2);
                Desarrolla++;
                break;
            case 1:
                animator.SetTrigger(MAIZ_FASE3);
                Desarrolla++;
                break;
            case 2:
                animator.SetTrigger(MAIZ_COSECHA);
                break;
        }
    }
}
