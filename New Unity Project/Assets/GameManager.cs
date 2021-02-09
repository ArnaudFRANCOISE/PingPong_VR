using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score=0;
    //public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void debug_funct()
    {
        Debug.Log("hi it's debugfunct");
        score ++;
        Debug.Log(score);
    }
    // Update is called once per frame
    void Update()
    {
        //scoreText.text="SCORE: "+score.ToString();
        //scoreText.text = "Yolo";
        Debug.Log(score);
    }
}
