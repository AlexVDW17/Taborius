using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChaser : MonoBehaviour
{
    public AudioSource hiyah;
    public UnityEngine.UI.Text loseText;
    public GameObject player;
    private Rigidbody rb;
    public float speed;
    // Use this for initiahttps://www.amazon.ca/CORSAIR-Wireless-Headset-HEADPHONE-Surround/dp/B0748N6796lization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hiyah = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player.transform.position.x > this.transform.position.x)
        {
            rb.AddForce(Vector3.right * speed);
        }
        else if (player.transform.position.x < this.transform.position.x)
        {
            rb.AddForce(Vector3.left * speed);
        }
        if (player.transform.position.z < this.transform.position.z)
        {
            rb.AddForce(Vector3.back * speed);
        }
        else if (player.transform.position.z > this.transform.position.z)
        {
            rb.AddForce(Vector3.forward * speed);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "player") 
        {
            hiyah.Play();
            loseText.text = "YOU LOSE"; 
        }
    }
}
