using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteBGMScript : MonoBehaviour
{
    Toggle muteToggle;
    
    public void MuteBGM(){
        muteToggle = GetComponent<Toggle>();

        if (muteToggle.isOn)
        {
            Debug.Log("BGM Muted");
        } else
        {
            Debug.Log("BGM Unmuted");
        }
        
    }
}
