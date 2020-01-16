using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour {

    public float cursorSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxis("Mouse X");
        float moveVertical = Input.GetAxis("Mouse Y");
        transform.Rotate(-moveVertical *cursorSpeed, moveHorizontal* cursorSpeed,0);
        Vector3 v = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(v.x, v.y, 0);
        //Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
	}
}
