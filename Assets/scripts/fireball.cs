using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{

	private Rigidbody rb;
	public bool move_forward  = true; 

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
    	
    	if(move_forward == true){
             rb.AddForce(0f,0f,20f);
        }else{
            rb.AddForce(0f,0f,0f);
        }
        // transform.Translate(0f,0f,20f*Time.deltaTime);
        // GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,20f);
    }

    void OnCollisionEnter(Collision any) {

        if (any.gameObject.tag == "wall")
        {
            move_forward = false;
        }
    }
}
