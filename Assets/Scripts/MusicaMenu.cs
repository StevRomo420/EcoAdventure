using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaMenu : MonoBehaviour
{
    
    void Start()
    {
        AudioManager.sharedInstance.PlayAudio("Menu");
    }

  
    void Update()
    {
        
    }
}
