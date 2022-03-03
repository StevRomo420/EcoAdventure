using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Dificultad : MonoBehaviour
{
    
    const string MEDIO = "Medio";
    const string DIFICIL = "Dificil";
    const string FACIL = "Facil";
    const string iNICIO = "Incio";
    const string INVISIBLE = "Invisible";
    public float time=0f;
    bool Primeros1K = true;
    bool Primeros2K = true;
    bool Primeros3K = true;
    Animator animator;
    public Jugador p2;
    
    // Start is called before the first frame update
    void Start()
    {
        
        animator = GetComponent<Animator>();
        
        GameObject prueba = GameObject.Find("Jugador");
        p2 = prueba.GetComponent<Jugador>();
       
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

     IEnumerator SpawnRandomGameObject()
    {

        int puntos = p2.puntos;
        switch (puntos)
        {
            case 1000:
                if (Primeros1K)
                {
                    Primeros1K = false;
                    animator.SetTrigger(FACIL);
                    yield return new WaitForSeconds(time);
                    animator.SetTrigger(INVISIBLE);
                }
                break;
            case 2000:
                if (Primeros2K)
                {
                    Primeros2K = false;
                    animator.SetTrigger(MEDIO);
                    yield return new WaitForSeconds(time);
                    animator.SetTrigger(INVISIBLE);
                }
                break;
            case 3000:
                if (Primeros3K)
                {
                    Primeros3K = false;
                    animator.SetTrigger(DIFICIL);
                    yield return new WaitForSeconds(time);
                    animator.SetTrigger(INVISIBLE);
                }
                
                break;

        }
    }
}
