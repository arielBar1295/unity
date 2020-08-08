using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 using UnityEngine.SceneManagement;

public class brick : MonoBehaviour
{
    // Start is called before the first frame update
    public int nextlevel;
    public int numberOfB;
 
    public int numofCol=0;


 static public int numberOfBrick=0;

    void Start()
    {   
        
        Time.timeScale = 1;
        numberOfBrick=numberOfB;
    }
     private void OnSceneLoaded(Scene aScene, LoadSceneMode aMode)
 {
        Time.timeScale = 1;
        numberOfBrick=numberOfB;
  
 }

    IEnumerator WaitAndPrint()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(5);
        print("WaitAndPrint " + Time.time);
    }

    IEnumerator Starti()
    {
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine
        yield return StartCoroutine("WaitAndPrint");
        print("Done " + Time.time);
    }
   
    void OnCollisionEnter2D(Collision2D col)
    {   
       

        if(col.gameObject.tag=="ball"){

             if(this.tag=="blueB")
             {
                 numofCol++;
                 if(numofCol==2)
                 {   
                     Debug.Log("herh numofcol=2");
                      
                      Destroy(gameObject);
                      numberOfBrick--;

                 }
                    
             }
            else{

            
              Destroy(gameObject);
              numberOfBrick--;

            }
              if(numberOfBrick==0)
              {   
                
                WaitAndPrint();
        
                 SceneManager.LoadScene(nextlevel);


              }
              
            
        }
    }

   
}
