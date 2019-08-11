using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(0f,0f,20f*Time.deltaTime);
        GetComponent<Rigidbody>().velocity = new Vector3(0f,0f,20f);
    }
}
