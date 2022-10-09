using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitBut : MonoBehaviour
{
    public void But(){
        Debug.Log("You just pressed quit!");
        Application.Quit();
    }
}
