using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSign : MonoBehaviour {

    public BoxCollider ColliderComponent;
    public GameObject Text;
    
    
	void OnTriggerEnter (Collider collider) {
        
       
        if (collider.name == "Car")
        {
          Text.SetActive(true);
        }

           
        
        
    
    }


}

