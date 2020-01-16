﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {

    public GameObject camera;
  

	// Use this for initialization
	void Start () {
     
	}
    
	// Update is called once per frame
	void Update () {
        Vector3 cameraPosition = camera.transform.position;
        transform.position = new Vector3(cameraPosition.x, 0.5f, cameraPosition.z);
       
	}
}
