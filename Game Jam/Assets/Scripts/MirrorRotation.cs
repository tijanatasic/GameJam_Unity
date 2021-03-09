using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MirrorRotation : MonoBehaviour 
{
    [SerializeField] SoundManager manager;

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime*90);
    }

    private void OnTriggerEnter(Collider collider)
    {
        
        if (collider.name == "Woody")
        {
            Destroy(gameObject);
            manager.PlayerSounds("picking");
            collider.GetComponent<Points>().SetScore(++collider.GetComponent<Points>().score);
            transform.parent.gameObject.GetComponent<Winning>().updateLeft(collider.GetComponent<Points>().score);
        }
    }
}
