﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    [SerializeField] private targetScript targetScript;
    // Start is called before the first frame update
    void Start()
    {
        //score=0;
    }
    
    // Update is called once per frame
    void Update()
    {
        //score = targetScript.score;
        //scoreText.text="SCORE: "+score.ToString();
    }
}
