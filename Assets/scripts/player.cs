using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    // spawning items
    public GameObject ramp;

    // movement
    public float moveSpeed;

	// jump
    public bool onGround;
    private Rigidbody rb;
    
    // When set to true, player move forward, otherwise, bounce back
    public bool move_forward  = true; 

    // boosted
    public bool boosted  = false; 

    // sliding
    public bool is_sliding  = false; 

    // Start is called before the first frame update
    void Start()
    {
    	moveSpeed = 5f;
    	onGround = true;
        is_sliding  = false;
    	rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      

    	// left, right and forward

        if(move_forward == true){
             transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,8f*Time.deltaTime);
        }else{
            transform.Translate(Vector3.back * 0.05f);
        }

        if(boosted == true){
             transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,12f*Time.deltaTime);
        }
        // else{
            
        // }

        // jump
        if(onGround) {
        	if(Input.GetButtonDown("Jump")){
        		rb.velocity = new Vector3(0f,4.5f,0f);
        		onGround = false;
        	}
        }

        // slide

		if (Input.GetKeyDown ("s")) {
            is_sliding = true;
			transform.localScale = new Vector3 (0.2946206f, 0.3f,0.3475012f);
            StartCoroutine(timer(1.3f));
		}

        if(is_sliding == false) {
            transform.localScale = new Vector3 (0.2946206f, 0.9268705f,0.3475012f);
        }

  //       if (Input.GetKeyDown ("s")) {
  //           transform.localScale = new Vector3 (0.2946206f, 0.3f,0.3475012f);
  //       }
		// if (Input.GetKeyUp ("s")) {
		// 	transform.localScale = new Vector3 (0.2946206f, 0.9268705f,0.3475012f);
		// }
    }

    // if grounded jump
    void OnCollisionEnter(Collision any) {
    	any.gameObject.CompareTag("Ground");
    	onGround = true;

        // bounce back when hitting walls

        if (any.gameObject.tag == "wall")
        {
            move_forward = false;
           StartCoroutine(timer(0.8f));
        }

        // boost when hit boost pad

        if (any.gameObject.tag == "boost")
        {
            boosted = true;
           StartCoroutine(timer(0.5f));
        }
    }

    //This function set how long the player bounce back
     public IEnumerator timer(float countdownValue)
     {
            yield return new WaitForSeconds(countdownValue);
            move_forward = true;
            boosted = false;
            is_sliding = false;
     }

    //   void use_ramp(){

       
    //     if(System.Int32.Parse( GameObject.Find("item1 1").transform.Find("Text").GetComponent<Text>().text) == 0){

    //     }else{
    //         int tcount =  System.Int32.Parse(GameObject.Find("item1 1").transform.Find("Text").GetComponent<Text>().text) - 1;
    //         GameObject.Find("item1 1").transform.Find("Text").GetComponent<Text>().text = "" + tcount;
    //         Instantiate(ramp, GameObject.Find("player 1").transform.position+(GameObject.Find("player 1").transform.forward*3), GameObject.Find("player 1").transform.rotation);
            
    //     }
        
    // }

    
    
}
