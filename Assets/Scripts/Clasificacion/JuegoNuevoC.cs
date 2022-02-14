using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JuegoNuevoC : MonoBehaviour
{
    public void CargarJuegoClasificacion()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        
        SceneManager.LoadScene("ClasificacionDeDesechos");
        GameManager.sharedInstance.estadoActual = EstadoDelJuego.enJuego;

    }
}
