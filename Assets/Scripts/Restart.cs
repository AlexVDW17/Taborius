﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Restarting()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameLite.unity");
    }
}
