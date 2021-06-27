using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLimit : MonoBehaviour {

   
    public GameObject SpeedLimitCollider;
    Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
        
        rigidbody = GameObject.Find("Car").GetComponent<Rigidbody>();
        SpeedLimitCollider.SetActive(false);
       
    }
	
	// Update is called once per frame
	void OnTriggerEnter () {
        if (rigidbody.velocity.magnitude > 0)
        {
            SpeedLimitCollider.SetActive(true);
        }
    }

  
}
