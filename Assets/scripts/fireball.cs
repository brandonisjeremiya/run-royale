using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{

	private Rigidbody rb;
    public bool move_forward  = true; 
    // public bool captured  = false; 

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        // velocity

    	if(move_forward == true){
             GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,20f);
             Destroy(gameObject,5f);
        }
        else{
            rb.AddForce(0f,0f,0f);
        }

        // if(captured == true){
        //      Destroy(gameObject,0f);
        // }
        // else{
            
        // }

        // force

    	// if(move_forward == true){
     //         rb.AddForce(0f,0f,200f);
     //    }else{
     //        rb.AddForce(0f,0f,0f);
     //    }

        // translate

        // transform.Translate(0f,0f,20f*Time.deltaTime);
        
    }

    void OnCollisionEnter(Collision any) {

        if (any.gameObject.tag == "wall")
        {
            move_forward = false;
        }

        if (any.gameObject.tag == "ramp")
        {
            move_forward = false;
        }

        // if (any.gameObject.tag == "player")
        // {
        //     captured = true;
        // }

        // if (any.gameObject.tag == "lava")
        // {
        //     captured = true;
        // }
    }
}
