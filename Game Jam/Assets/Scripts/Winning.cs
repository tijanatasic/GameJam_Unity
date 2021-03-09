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
