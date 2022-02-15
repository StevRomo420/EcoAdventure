using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject AcercaDe; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Clasificacion()
    {
        SceneManager.LoadScene("ClasificacionDeDesechos");
        Time.timeScale = 1f;
       
    }
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPricipal");

    }
    public void Cerrarjuego()
    {
        Application.Quit();

    }
    public void AbrirInformacion()
    {
        AcercaDe.SetActive(true);
    }
    public void CerrarInformacion()
    {
        AcercaDe.SetActive(false);
    }
}
