using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedditStopSign : MonoBehaviour {

    public BoxCollider GameOverTrigger; //the reference to the GameOverTrigger Box (B)
    public bool IsGameOver;             //Attach this script to the GameOverTrigger Box (B) too and set this to be true!
    public bool DebugMode = false;      //Helps visualise what is happening. Note == Couldn't be bothered to make the A trigger disable - just turn it off in the inspector.
    private MeshRenderer myMesh;                //Private MyMesh just used for the debug.


    private void Start()
    {
        //If we're in debug mode, handle the mesh renders too whenever the collider box is enabled or disabled;
        myMesh = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (DebugMode)
        {
            myMesh.enabled = GetComponent<BoxCollider>().enabled;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Car Has Set off this trigger
            if (IsGameOver)
            {
                //This is the game over object: Just handle the Game over messaging on collision with the car
                Debug.Log("GAME OVER!");
            }
            else
            {
                //this just starts a coroutine, which enables the gameover box's trigger - it then waits 5 seconds, and then disables it. GameOverTrigger should always start disabled!;
                StartCoroutine(EnableGameOver());
            }
        }
    }

    IEnumerator EnableGameOver()
    {
        if (GameOverTrigger != null)
        {
            GameOverTrigger.enabled = true;
            yield return new WaitForSeconds(5f);
            GameOverTrigger.enabled = false;
        }
    }
}