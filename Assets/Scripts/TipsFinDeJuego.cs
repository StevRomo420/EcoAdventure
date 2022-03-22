using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TipsFinDeJuego : MonoBehaviour
{
    public string[] Tips;
    Text Tip;
 
    void Start()
    {
        Tip = GetComponent<Text>();
        SelectorDeTip();
       
    }

    public void SelectorDeTip()
    {
        int randomTip = Random.Range(0, Tips.Length);
        if (Random.value <= Tips.Length)
        {
            Tip.text = Tips[randomTip];
            
           
        }
    }


   
}
