using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Points : MonoBehaviour
{
    [SerializeField]public TextMeshProUGUI textMesh;
    public int score=0;


    internal void SetScore(int score)
    {
        textMesh.SetText("Score: " + score);
    }
}
