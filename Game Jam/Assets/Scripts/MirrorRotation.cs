using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorRotation : MonoBehaviour 
{
    

    void Start()
    {
        
    }
    
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
            //collider.GetComponent<PlayerMovement>().points++;

        }
    }
}
