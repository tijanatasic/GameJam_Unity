using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] public AudioClip picking, hitting,victory,gameOver, themeSong;
    static AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(themeSong,0.2f);
    }
    
    public void PlayerSounds(string option)
    {
        switch (option)
        {
            case "picking":
                audioSource.PlayOneShot(picking,0.5f);
                break;
            case "hitting":
                audioSource.Stop();
                audioSource.PlayOneShot(hitting);
                
                break;
            case "winning":
                audioSource.Stop();
                audioSource.PlayOneShot(victory);
                break;
            case "gameOver":
                audioSource.PlayOneShot(gameOver);
                break;
        }
    }
}
