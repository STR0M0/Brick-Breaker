﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour {

    /// <summary>
    /// Basic way to move from intructions scene to first level 
    /// </summary>
	void Update()
    {
        bool keyPress = Input.anyKey;

        if (keyPress)
        {
            SceneManager.LoadScene("Level One");
        }
    }
}
    
