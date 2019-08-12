using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnItem : MonoBehaviour
{

	public GameObject item;
	int spawnNum = 3;

	void spawn (){
		for (int i = 0; i < spawnNum; i++)
		{
			Vector3 itemPos = new Vector3(this.transform.position.x + Random.Range(-3f,3.0f),
											this.transform.position.y + Random.Range(0f,0f),
											this.transform.position.z + Random.Range(0f,3.0f));
			Instantiate(item, itemPos, Quaternion.identity);
		}
	}

    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
