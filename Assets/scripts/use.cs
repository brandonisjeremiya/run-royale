using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class use : MonoBehaviour {

 // spawning items
    public GameObject ramp;
    public GameObject fireball;
/*
	public void useMe()
	{
		if(System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) > 1)
		{
			int tcount =  System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) - 1;
	 		this.transform.Find("Text").GetComponent<Text>().text = "" + tcount;

		}
		else
		{
			Destroy(this.gameObject);
		}

	} 
*/
	void Update (){
	
	}

public void use_ramp(){

         if(System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) > 1)
		{
				//Destroy(this.gameObject);
		}else{
			Destroy(this.gameObject);
		}

        if(System.Int32.Parse( this.transform.Find("Text").GetComponent<Text>().text) == 0){

        }else{
            int tcount =  System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) - 1;
           this.transform.Find("Text").GetComponent<Text>().text = "" + tcount;
            Instantiate(ramp, GameObject.Find("player 1").transform.position+(GameObject.Find("player 1").transform.forward*3), GameObject.Find("player 1").transform.rotation);
            
        }
        
    }

public void use_fireball(){

         if(System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) > 1)
		{
				//Destroy(this.gameObject);
		}else{
			Destroy(this.gameObject);
		}

        if(System.Int32.Parse( this.transform.Find("Text").GetComponent<Text>().text) == 0){

        }else{
            int tcount =  System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) - 1;
           this.transform.Find("Text").GetComponent<Text>().text = "" + tcount;
            Instantiate(fireball, GameObject.Find("player 1").transform.position+(GameObject.Find("player 1").transform.forward*1), GameObject.Find("player 1").transform.rotation);
            
        }
        
    }

	/*function void use_ramp(){
		if((System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) == 0){

		}else{
			int tcount =  System.Int32.Parse(this.transform.Find("Text").GetComponent<Text>().text) - 1;
	 		this.transform.Find("Text").GetComponent<Text>().text = "" + tcount;
	 		Instantiate(ramp, GameObject.Find("player 1").transform.position+(GameObject.Find("player 1").transform.forward*3), GameObject.Find("player 1").transform.rotation);
	 		
		}
		
	}*/
}
