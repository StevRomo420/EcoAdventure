using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EstadoDelJuego
{
    menu,
    pausa,
    enJuego,
    finDelJuego
}

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;

    public EstadoDelJuego estadoActual = EstadoDelJuego.menu;

    private void Awake()
    {
        sharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IniciarJuego()
    {

    }


    public void FinDeJuego()
    {

    }

    public void RegresarAlMenu()
    {

    }

    void CambiarEstadoDeJuego()
    {

    }



}
