using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour {
    private Rigidbody rb;
    // Use this for initialization
    public GameObject ball;
    public float speed;
	void Start () {
        rb = GetComponent<Rigidbody>();
       // transform.position = new Vector3(0.0f, -0.5f, 0.0f);

    }

    // Update is called once per frame
    void Update () {
        rb.AddForce(new Vector3(0.5f, 0.0f, 0.05f * speed));
        if (transform.position.x>=2)
        {
            Vector3 vector = new Vector3(0, 0, 0);
            
            Instantiate(ball,new Vector3(-2,0,0), new Quaternion(0,0,0,0));
            ball.transform.position = new Vector3(0.0f, 0.0f, 0.0f);


            Destroy(this.gameObject);
            //Destroy(gameObject);
            Vector3 startSpot = new Vector3(0f, 0.5f, 0f);
            
            
           
        }
	}
}
