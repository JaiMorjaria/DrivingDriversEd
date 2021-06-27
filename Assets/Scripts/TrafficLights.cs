using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLights : MonoBehaviour
{
    public Renderer Red;
    public Material RedLightOff;
    public Material RedLightOn;
    public Renderer Yellow;
    public Material YellowLightOff;
    public Material YellowLightOn;
    public Renderer Green;
    public Material GreenLightOff;
    public Material GreenLightOn;
    private bool redlightON = true;
    private bool yellowlightON = false;
    private bool greenlightON = false;
    public BoxCollider boxCollider;
   
    
    

    private void Start()
    {
        Red.material = RedLightOn;
        Yellow.material = YellowLightOff;
        Green.material = GreenLightOff;
        StartCoroutine(ChangeLights());

    }

    




    IEnumerator ChangeLights()
    {
        while(true)

        {
            Red.material = RedLightOn;
            redlightON = true;
            Yellow.material = YellowLightOff;
            yellowlightON = false;
            Green.material = GreenLightOff;
            greenlightON = false;
            boxCollider.enabled = true;
           
            yield return new WaitForSeconds(30);
            Red.material = RedLightOff;
            redlightON = false;
            Yellow.material = YellowLightOn;
            yellowlightON = true;
            Green.material = GreenLightOff;
            greenlightON = false;
            boxCollider.enabled = false;

            yield return new WaitForSeconds(4);
            Red.material = RedLightOff;
            redlightON = false;
            Yellow.material = YellowLightOff;
            yellowlightON = false;
            Green.material = GreenLightOn;
            greenlightON = true;
            boxCollider.enabled = false;

            yield return new WaitForSeconds(30);
            Red.material = RedLightOff;
            redlightON = false;
            Yellow.material = YellowLightOn;
            yellowlightON = true;
            Green.material = GreenLightOff;
            greenlightON = false;
            boxCollider.enabled = false;

            yield return new WaitForSeconds(4);
        }




    }
}


