using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MirrorRotation : MonoBehaviour 
{

    
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime*90);
    }

    private void OnTriggerEnter(Collider collider)
    {
        
        if (collider.name == "Woody")
        {
            Destroy(gameObject);
            collider.GetComponent<Points>().SetScore(++collider.GetComponent<Points>().score);
            transform.parent.gameObject.GetComponent<Winning>().updateLeft(collider.GetComponent<Points>().score);

        }
    }
}
