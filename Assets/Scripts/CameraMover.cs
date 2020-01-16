using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0f, 1f, 0f));
        }
        else if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0f, -1f, 0f));
            //transform.position = transform.position + new Vector3();
        }

    }
}
