using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Woody")
        {
            Time.timeScale = 0;
            collider.GetComponent<PlayerMovement>().end=true;
            
        }
    }

   
}
