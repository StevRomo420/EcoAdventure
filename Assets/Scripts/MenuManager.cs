using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Clasificacion()
    {
        SceneManager.LoadScene("ClasificacionDeDesechos");

    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPricipal");

    }
    public void Cerrarjuego()
    {
        Application.Quit();

    }
}
