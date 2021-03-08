using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Woody")
        {
            Time.timeScale = 0;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}
