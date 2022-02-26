using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorDePuntosUI : MonoBehaviour
{

    public Jugador p2;
    public static int scoreValue = 0;
    Text score;


    void Start()
    {
        GameObject prueba = GameObject.Find("Jugador");
        p2 = prueba.GetComponent<Jugador>();
        score = GetComponent<Text>();


    }

    void Update()
    {

        scoreValue = p2.totalDePuntos();
        score.text = scoreValue.ToString();

     

    }
}
