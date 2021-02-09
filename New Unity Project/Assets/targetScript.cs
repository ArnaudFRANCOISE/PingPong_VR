using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class targetScript : MonoBehaviour
{
    [SerializeField] private Text scoretxt_box;
    public GameManager gameManager;
    private int score = 0; 
    //private GameManager gmScript;
    // Start is called before the first frame update
    void Start()
    {
        scoretxt_box.text = "SCORE: ";
        //GameObject gameManager= GameObject.Find("GameManager");
        //GameManager gmScript=gameManager.GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ontrigger enter");
        
        if(other.tag=="ball")
        {
            Debug.Log("ball trigger");
            //gameManager.score++;
            //gmScript.debug_funct();
            //Debug.Log(gameManager.score);
            score++;
            scoretxt_box.text = "SCORE: " + score.ToString();
            Debug.Log("ontrigger score: "+ score.ToString());
        }
        else
        {
            Debug.Log("no enter");
        }
    }
}
