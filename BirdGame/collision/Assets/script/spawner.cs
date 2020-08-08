using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject worm;
    [SerializeField] float randx;
    [SerializeField] float randy;
    Vector2 wheretosp;
    [SerializeField] float rate=2f;
    float nextSp=0.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>nextSp)
        {
           nextSp=Time.time+rate;
           randx=Random.Range(5.5f,60.8f);
           randy=Random.Range(0.0f,-16.9f);
           wheretosp= new Vector2(randx,randy);
           Instantiate(worm,wheretosp,Quaternion.identity);
        }
        
    }
}
