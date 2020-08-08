using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    int score=0;
    public Text scoreT;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void incrementScore()
    {   Debug.Log("JJH");
        score++;
        scoreT.text="Score:"+score;
    }
}
