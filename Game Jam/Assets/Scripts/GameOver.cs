using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    [SerializeField] private SoundManager manager;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Woody")
        {
            manager.PlayerSounds("hitting");
            Time.timeScale = 0;
            collider.GetComponent<PlayerMovement>().end=true;
            
            
        }
    }

}
