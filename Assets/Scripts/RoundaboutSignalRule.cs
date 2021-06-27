using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundaboutSignalRule : MonoBehaviour {


    public BoxCollider boxColliderComponent;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            boxColliderComponent.enabled = false;
           
        }
        else if (Input.GetKeyUp(KeyCode.X))
        {
            boxColliderComponent.enabled = true;
           

        }
    }
}
