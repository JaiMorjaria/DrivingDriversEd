using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSignals : MonoBehaviour
{


    public Renderer turnsignalR;
    public Renderer turnsignalL;
    public Material turnsignalOFF;
    public Material turnsignalON;

    private bool rightSignalON = false;
    private bool leftSignalON = false;

    void Update()
    {


        if (Input.GetKey(KeyCode.X))
        {
            turnsignalR.material = turnsignalON;
            turnsignalL.material = turnsignalOFF;
            rightSignalON = true;
            leftSignalON = false;
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            turnsignalR.material = turnsignalOFF;
            turnsignalL.material = turnsignalON;
            rightSignalON = false;
            leftSignalON = true;
        }
        else
        {
            turnsignalL.material = turnsignalOFF;
            turnsignalR.material = turnsignalOFF;
            rightSignalON = false;
            leftSignalON = false;
        }

        if (leftSignalON)
        {
            float floor = 0f;
            float ceiling = 1f;
            float emission = floor + Mathf.PingPong(Time.time * 2f, ceiling - floor);
            turnsignalL.material.SetColor("_EmissionColor", new Color(0.6f, 0.6f, 0.6f) * emission);
        }
        if (rightSignalON)
        {
            float floor = 0f;
            float ceiling = 1f;
            float emission = floor + Mathf.PingPong(Time.time * 2f, ceiling - floor);
            turnsignalR.material.SetColor("_EmissionColor", new Color(0.6f, 0.6f, 0.6f) * emission);
        }


    }
}
