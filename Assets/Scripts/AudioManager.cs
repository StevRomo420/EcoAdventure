using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{

    public Audios[] audios;
    public static AudioManager sharedInstance;
    // Start is called before the first frame update
    void Awake()
    {
      

        sharedInstance = this;
      
        foreach (Audios audioClip in audios)
        {
            audioClip.recurso = gameObject.AddComponent<AudioSource>();
            audioClip.recurso.clip = audioClip.clip;

            audioClip.recurso.volume = audioClip.volumen;
            audioClip.recurso.pitch = audioClip.pitch;
            audioClip.recurso.loop = audioClip.loop;
        }
        PlayAudio("ClaficacionTemaPrincipal");
    }

    public void PlayAudio(string nombre)
    {

        Audios s = Array.Find(audios, audio => audio.nombre == nombre);
        if (s == null)
        {
            Debug.LogWarning("Audio " + nombre + " no encontrado");
            return;
        }

        s.recurso.Play();
    }

   


}
