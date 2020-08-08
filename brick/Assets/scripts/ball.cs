using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{   
    public Rigidbody2D rigidbody;
    public float ballforce;
    public static bool startGame;
    void Start()
    {
          startGame=true;
    }

 private void OnSceneLoaded(Scene aScene, LoadSceneMode aMode)
 {
        startGame=true;
        rigidbody= GetComponent<Rigidbody2D>();


 }

     void Update()
     {   
         //add force only once!
         if (Input.GetMouseButtonDown(0) && startGame){
             print(startGame);
            transform.SetParent(null);
            rigidbody.AddForce(new Vector2 (ballforce,ballforce));
            startGame=false;
         }
     }
    }

