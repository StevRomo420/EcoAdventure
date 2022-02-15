using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public enum EstadoDelJuego
{
    menu,
    pausa,
    enJuego,
    finDelJuego
}

public enum Juegos
{
    Clasificacion,
    Huerta,
    Barco
}

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;

    public EstadoDelJuego estadoActual = EstadoDelJuego.menu;

    public Juegos juegoActual;

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
        Time.timeScale = 1f;
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
        AudioManager.sharedInstance.PlayAudio("Click");
        
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
        estaPuasado = false;
        CambiarEstadoDeJuego(EstadoDelJuego.enJuego);
        if (juegoActual == Juegos.Clasificacion)
        {
            AudioListener.pause = false;
        }
        else if(juegoActual == Juegos.Barco)
        {
            //ToDo:Logica para poner la musica del juego correspondiente
        }else if(juegoActual == Juegos.Huerta)
        {
            //ToDo:Logica para poner la musica del juego correspondiente
        }



    }
    public void Pausa(){
        AudioManager.sharedInstance.PlayAudio("Click");
        CambiarEstadoDeJuego(EstadoDelJuego.pausa);
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

            AudioListener.pause = true;

            estaPuasado = true;

        }
        else if (nuevoEstado == EstadoDelJuego.finDelJuego)
        {

            finDelJuego.SetActive(true);
           // AudioManager.sharedInstance.StopAudio("ClaficacionTemaPrincipal");
            AudioManager.sharedInstance.StopAudio("Ganar");
            AudioManager.sharedInstance.StopAudio("Perder");






        }

    }




}
