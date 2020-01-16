using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            transform.Rotate(new Vector3(0, 45, 45) * Time.deltaTime);
        }
    }
}
