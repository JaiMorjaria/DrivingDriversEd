using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalRuleLeft : MonoBehaviour {

    public BoxCollider boxColliderComponent;
    public BoxCollider boxColliderComponent2;
    public BoxCollider boxColliderComponent3;
    public BoxCollider boxColliderComponent4;
    public BoxCollider boxColliderComponent5;
    public BoxCollider boxColliderComponent6;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            boxColliderComponent.enabled = false;
            boxColliderComponent2.enabled = false;
            boxColliderComponent3.enabled = false;
            boxColliderComponent4.enabled = false;
            boxColliderComponent5.enabled = false;
            boxColliderComponent6.enabled = false;
        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            boxColliderComponent.enabled = true;
            boxColliderComponent2.enabled = true;
            boxColliderComponent3.enabled = true;
            boxColliderComponent4.enabled = true;
            boxColliderComponent5.enabled = true;
            boxColliderComponent6.enabled = true;


        }
    }
}
