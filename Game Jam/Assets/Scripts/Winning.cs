using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Winning : MonoBehaviour
{
    int children;
    [SerializeField] public TextMeshProUGUI textMesh;
    [SerializeField] public GameObject mainPanel;
    [SerializeField] public GameObject gameOver;
    [SerializeField] public GameObject winner;
    [SerializeField] public SoundManager manager;
    [SerializeField] public GameObject body1;
    [SerializeField] public GameObject body2;

    void Start()
    {
        CountChildren();
        updateLeft(0);
        
    }

    public void updateLeft(int score)
    {
        
        textMesh.SetText("Left: " + (children-score));
        if (children - score == 0)
        {
            Win();
        }
    }

    public void Win()
    {
        Time.timeScale = 0;
        openWinnigPanel();
    }

    private void openWinnigPanel()
    {
        manager.PlayerSounds("winning");
        body1.SetActive(false);
        body2.SetActive(false);
        mainPanel.SetActive(true);
        gameOver.SetActive(false);
        winner.SetActive(true);
    }
    
    public void CountChildren()
    {
        children = transform.childCount;
        for (int i = 0; i < children; ++i)
            transform.GetChild(i);
    }
}
