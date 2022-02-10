using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Audios
{

    public string nombre;
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volumen;
    [Range(.1f, 3)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource recurso;

}
