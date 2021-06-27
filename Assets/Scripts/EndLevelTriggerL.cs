using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelTriggerL : MonoBehaviour {
    int sceneIndex, levelPassed;

    private void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void OnTriggerEnter(Collider other)
    {
        //other.name should equal the root of your Player object
        if (other.name == "Car")
        {
            if (sceneIndex == 19)
            {
                Invoke("loadMainMenu", 1f);
            }
            else {
                if (levelPassed < sceneIndex) ;
                {
                    PlayerPrefs.SetInt("LevelPassed", sceneIndex);

                    Invoke("loadNextLevel", 1f);
                }
            }
        }

    }
    void loadNextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 2);
    }
    void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
    