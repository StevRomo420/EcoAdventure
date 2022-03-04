using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject TutorialClasificacion;
    public GameObject TutorialBarco;
    public GameObject TutorialInvernadero;
    public GameObject Instrusiones;
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
    
    public void AbrirInstruciones()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        Instrusiones.SetActive(true);
    }
    public void CerrarInstruciones()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        Instrusiones.SetActive(false);
    }
    /*-----------------------------*/
    public void AbrirTutorialBarco()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        TutorialBarco.SetActive(true);
    }
    public void CerrarTutorialBarco()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        TutorialBarco.SetActive(false);
    }
    /*------------------------------*/
    public void AbrirTutorialClasificacion()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        TutorialClasificacion.SetActive(true);
    }
    public void CerrarTutorialClasificacion()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        TutorialClasificacion.SetActive(false);
    }
    /*---------------------------------*/
    public void AbrirTutorialInvernadero()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        TutorialInvernadero.SetActive(true);
    }
    public void CerrarTutorialInvernadero()
    {
        AudioManager.sharedInstance.PlayAudio("Click");
        TutorialInvernadero.SetActive(false);
    }
}
