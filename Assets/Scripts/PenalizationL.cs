 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PenalizationL : MonoBehaviour {


 void OnTriggerEnter(Collider other)
        {
            //other.name should equal the root of your Player object
            if (other.name == "Car")
            {
                //The scene number to load (in File->Build Settings)
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } 
            
        }
    
}



