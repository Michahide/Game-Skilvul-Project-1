using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteSFXScript : MonoBehaviour
{
    Toggle muteToggle;
    
    public void MuteSFX(){
        muteToggle = GetComponent<Toggle>();

        if (muteToggle.isOn)
        {
            Debug.Log("SFX Muted");
        } else
        {
            Debug.Log("SFX Unmuted");
        }
        
    }
}
