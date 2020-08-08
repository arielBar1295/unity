using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	
	
	// Update is called once per frame
	void Update () {

	
     Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
     pos.y=-4.078947f;
     pos.x=Mathf.Clamp(pos.x,-4.98f,5f);
     Debug.Log(pos.x);
     transform.position = pos;
		}

}