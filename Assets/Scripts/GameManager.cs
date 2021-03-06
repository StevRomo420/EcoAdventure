using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

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

    public EstadoDelJuego estadoActual;

    public Juegos juegoActual;

    public static bool estaPuasado;
    public GameObject menuPausa;
    public GameObject finDelJuego;
    public GameObject acercaDe;

    public GameObject loadingScreen;

    public Slider loadBar;
  


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

    /// <summary>
    /// Para el control de estados de juego
    /// </summary>

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

    

    }
    public void Pausa(){
        AudioManager.sharedInstance.PlayAudio("Click");
       
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
        estaPuasado = true;
        CambiarEstadoDeJuego(EstadoDelJuego.pausa);
    }

    void CambiarEstadoDeJuego(EstadoDelJuego nuevoEstado)
    {
        if (nuevoEstado == EstadoDelJuego.menu)
        {
            SceneManager.LoadScene("MenuPricipal");
            AudioManager.sharedInstance.PlayAudio("Menu");
            estadoActual = EstadoDelJuego.menu;
           
        }
        else if (nuevoEstado == EstadoDelJuego.enJuego)
        {
            finDelJuego.SetActive(false);
            estadoActual = EstadoDelJuego.enJuego;
          
        }
        else if (nuevoEstado == EstadoDelJuego.pausa)
        {
            menuPausa.SetActive(true);
            Time.timeScale = 0f;
            estaPuasado = true;
            estadoActual = EstadoDelJuego.pausa;
            
        }
        else if (nuevoEstado == EstadoDelJuego.finDelJuego)
        {

            finDelJuego.SetActive(true);

            estadoActual = EstadoDelJuego.finDelJuego;
        
        }

    }

    /// <summary>
    /// Para la seleccion de juegos
    /// </summary>

    public void JuegoClasificacion()
    {
        CambiarJuego(Juegos.Clasificacion);
    }

    public void JuegoHuerta()
    {
        CambiarJuego(Juegos.Huerta);
    }

    public void JuegoBarco()
    {
        CambiarJuego(Juegos.Barco);
    }


    public void JuegoClasificacionPA()
    {
        SceneManager.LoadScene("ClasificacionDeDesechos");
    }

    public void JuegoHuertaPA()
    {
        SceneManager.LoadScene("Invernadero");
    }

    public void JuegoBarcoPA()
    {
        SceneManager.LoadScene("Barco");
    }


    void CambiarJuego(Juegos juegoElejido)
    {
        if (juegoElejido == Juegos.Clasificacion)
        {
            StartCoroutine(LoadingEscene("ClasificacionDeDesechos"));
           
            IniciarJuego();

        }else if (juegoElejido == Juegos.Huerta)
        {
            StartCoroutine(LoadingEscene("Invernadero"));
          

            IniciarJuego();
        }
        else if (juegoElejido == Juegos.Barco)
        {
            StartCoroutine(LoadingEscene("Barco"));

            IniciarJuego();
        }
    }
/// <summary>
/// Botones funcionales del juego
/// </summary>

    public void Cerrarjuego()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        Application.Quit();

    }
    public void AbrirInformacion()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        acercaDe.SetActive(true);
    }
    public void CerrarInformacion()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        acercaDe.SetActive(false);
    }

    IEnumerator LoadingEscene(string escena)
    {

        loadingScreen.SetActive(true);
        loadBar.value = 0;

        float numeroPrueba = 0f;

        while (numeroPrueba!=10)
        {
            numeroPrueba += 2.5f;

            loadBar.value = numeroPrueba;

            yield return new WaitForSeconds(0.3f);
        }
        
        SceneManager.LoadScene(escena);


    }


}
