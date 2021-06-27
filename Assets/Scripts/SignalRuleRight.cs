using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalRuleRight : MonoBehaviour
{

    public BoxCollider boxColliderComponent;
    public BoxCollider boxColliderComponent2;
    public BoxCollider boxColliderComponent3;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            boxColliderComponent.enabled = false;
            boxColliderComponent2.enabled = false;
            boxColliderComponent3.enabled = false;
        }
        else if (Input.GetKeyUp(KeyCode.X))
        {
            boxColliderComponent.enabled = true;
            boxColliderComponent2.enabled = true;
            boxColliderComponent3.enabled = true;


        }
    }
}