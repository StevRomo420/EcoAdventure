using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JuegoNuevoC : MonoBehaviour
{
    public void CargarJuegoClasificacion()
    {
        SceneManager.LoadScene("ClasificacionDeDesechos");
    }
}