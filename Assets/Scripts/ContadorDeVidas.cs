using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorDeVidas : MonoBehaviour
{
    public Jugador p2;

    public static int vidaRestante =0;

    Text vida;


    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Jugador");
        p2 = player.GetComponent<Jugador>();
        vida = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        vidaRestante = p2.vidaRestante();
        vida.text = vidaRestante.ToString();
        if (vidaRestante <= 0)
        {
            GameManager.sharedInstance.FinDeJuego();
        }
        
    }
}
