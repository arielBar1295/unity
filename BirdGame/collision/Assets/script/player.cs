using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{     
      public static AudioClip eatSound;
      public static AudioSource source;
      [SerializeField] KeyCode right;
     [SerializeField] KeyCode left;
     [SerializeField] KeyCode up;
     [SerializeField] KeyCode down;
     [SerializeField] float stepSize = 0.03f;
    public RectTransform mpane;
    void Start()
    {
      
       eatSound = Resources.Load<AudioClip>("eating_sound");;
        source=GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKey(up)) 
          transform.position += new Vector3(0, stepSize, 0);  
         if (Input.GetKey(down)) 
            transform.position += new Vector3(0, -stepSize, 0);
         if (Input.GetKey(right)) 
            transform.position += new Vector3(stepSize,0, 0);
         if (Input.GetKey(left)) 
            transform.position += new Vector3(-stepSize, 0, 0);
        
    }
     private void OnTriggerEnter2D(Collider2D col){
            if(col.gameObject.tag =="food")
            {
            Vector3 scale = transform.localScale;
 
            scale.Set(0.2f,0.2f, 0.0f);
 
             transform.localScale += scale;
                Destroy(col.gameObject);
                source.PlayOneShot(eatSound);
            }
          if(col.gameObject.tag =="boundry")
          {
              mpane.gameObject.SetActive(true);
              Destroy(this);
          }

     }
               
}
