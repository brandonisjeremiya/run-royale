using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    // [SerializeField] private Transform player;
    // [SerializeField] private Transform respawnPoint;
    public Transform player;
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    
    {
    	Debug.Log (gameObject.name + "was triggered by " + other.gameObject.name);
        player.transform.position = respawnPoint.transform.position;
    }

	// void OnTriggerEnter(Collider other) {
	//     if(gameObject.name == "player 1")
	//      {
	//      	Debug.Log (gameObject.name + "was triggered by " + other.gameObject.name);
	//          player.transform.position = respawnPoint.transform.position;       
	//      }
	// }

}
