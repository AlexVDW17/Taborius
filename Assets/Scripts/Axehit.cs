using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axehit : MonoBehaviour {
    public float speed;
    public GameObject returnToPos;
	// Use this for initialization
	
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Shootable health = collision.gameObject.GetComponent<Shootable>();
            if (health != null)
            {
                health.Damage(1);
                if (collision.rigidbody != null)

                {

                    collision.rigidbody.AddForce((collision.gameObject.transform.position-transform.position)*speed);

                }
            }
            
        }
        transform.position = returnToPos.transform.position;
        transform.rotation = returnToPos.transform.rotation;
    }
}
