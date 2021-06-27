using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeLight : MonoBehaviour {

public Renderer brakelight;
public Material Rearlights;
public Material RearlightsON;

    // Update is called once per frame
    void Update () {
		if (Input.GetKey(KeyCode.DownArrow))
        {
            brakelight.material = RearlightsON;
        }
        else
        {
            brakelight.material = Rearlights;
        }
	}
}
