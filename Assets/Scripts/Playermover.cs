using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermover : MonoBehaviour {



    private Rigidbody rb;
    public float speed;
    public float x, y, z;
    public GameObject camera;
    public GameObject floor;
    public float jumpPower;
    public UnityEngine.UI.Text EnemiesDefeated;
    public Dooropener myDoorOpener;
    private bool jumping;
    private bool pastPeak;
	// Use this for initialization
	void Start () {
     
        rb = GetComponent<Rigidbody>();
        jumping = false;
        pastPeak = false;
	}


    
    // Update is called once per frame
    void FixedUpdate () {
        Vector3 forwards = transform.position - camera.transform.position;
        Application.targetFrameRate = 30;
        if (Input.GetKey("p"))
        {
            Application.Quit();

        }
        if (Input.GetKey("k"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameLite");
        }
        if (Input.GetKey("w") && jumping == false)
        {
            transform.position = transform.position + forwards * speed*Time.deltaTime;
        }
        else if (Input.GetKey("s") && jumping == false)
        {
            transform.position = transform.position - forwards * (speed)*Time.deltaTime;
        }
        if (Input.GetKey("a") && jumping == false)
        {
            Vector3 side = Quaternion.Euler(0, 90, 0) * forwards;
            transform.position = transform.position - side * speed*Time.deltaTime;
        }
        else if (Input.GetKey("d") && jumping == false)
        {
            Vector3 side =  Quaternion.Euler(0, 90, 0)* forwards;
            transform.position = transform.position + side * speed*Time.deltaTime;
            
        }

        if(Input.GetKeyDown(KeyCode.Space) && transform.position.y < (floor.transform.position.y + 0.6f) && transform.position.y > (floor.transform.position.y ))
           
        {
            rb.AddForce(Vector3.up*1000*jumpPower);
            rb.AddForce(forwards * Time.deltaTime * speed*6000);
            jumping = true;
        }

        if (transform.position.y>1)
        {
            pastPeak = true;
        }
        if (jumping&&pastPeak  && transform.position.y<floor.transform.position.y+.5f)
        {
            jumping = false;
            pastPeak = false;
        }

        Vector3 v = transform.rotation.eulerAngles;

        //transform.rotation = Quaternion.Euler(0, v.y, 0);
        rb.angularVelocity = Vector3.zero;

      
        
    }
    public int enemiesKilled;
    public void CountUp()
    {
        enemiesKilled++;
        EnemiesDefeated.text = "Enemies Killed: " + enemiesKilled.ToString();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "OpenDoor")
        {
            myDoorOpener = collision.gameObject.GetComponentInParent<Dooropener>();

            myDoorOpener.Disactivate();
            
        }
    }

}
