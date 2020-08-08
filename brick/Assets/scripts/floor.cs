using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class floor : MonoBehaviour
{

     public int currLevel;
 
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="ball")
             SceneManager.LoadScene(currLevel);
        
    }
}
