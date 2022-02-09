using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public static bool estaPuasado;
    public GameObject menuPausa;
    public GameObject finDelJuego;


    private void Awake()
    {
        sharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        estadoActual = EstadoDelJuego.enJuego;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IniciarJuego()
    {
        CambiarEstadoDeJuego(EstadoDelJuego.enJuego);
    }


    public void FinDeJuego()
    {
        CambiarEstadoDeJuego(EstadoDelJuego.finDelJuego);
    }

    public void RegresarAlMenu()
    {
        CambiarEstadoDeJuego(EstadoDelJuego.menu);
    }

    public void Resume()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
        estaPuasado = false;
        CambiarEstadoDeJuego(EstadoDelJuego.enJuego);
    }

    void CambiarEstadoDeJuego(EstadoDelJuego nuevoEstado)
    {
        if (nuevoEstado == EstadoDelJuego.menu)
        {

        }
        else if (nuevoEstado == EstadoDelJuego.enJuego)
        {
            finDelJuego.SetActive(false);
        }
        else if (nuevoEstado == EstadoDelJuego.pausa)
        {
            menuPausa.SetActive(true);
            Time.timeScale = 0f;
            estaPuasado = true;

        }
        else if (nuevoEstado == EstadoDelJuego.finDelJuego)
        {

            finDelJuego.SetActive(true);
        }

    }




}
