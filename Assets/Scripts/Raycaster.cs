using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    public int gunDamage = 1;
    private float AxeDelay = 0.5f;
    private float delay = 0.25f;
    public float weaponRange = 50;
    public float hitForce = 100f;
    public Transform gunEnd;
    private float shotDuration;
    private LineRenderer laserLine;
    private float nextFire;
    private AudioSource gunAudio;
    public Camera fpscamera;
    public AudioSource shotSound;
    private bool TrueLaserFalseAxe = true;
    public GameObject axe;
    private bool swingingAxe = false;
    public GameObject axeRotateAround;
    // Use this for initialization
    private Quaternion AxeOGRot;
    public GameObject axeHaftReal;
    public GameObject axeHaftDesired;
    public GameObject AxeReturnHere;
	void Start ()
    {
        shotDuration = Time.fixedTime + 0.07f;
        laserLine = GetComponent<LineRenderer>();
        shotSound = GetComponent<AudioSource>();
        AxeOGRot = axe.transform.rotation;
	}
	
	// Update is called once per frame
	void Update ()
    {

        //these switch between your laser and your axe
        if (TrueLaserFalseAxe == true&& Input.GetKeyDown(KeyCode.Q))
        {
            axe.SetActive(true);
            TrueLaserFalseAxe = false;
        }
        else if (TrueLaserFalseAxe ==false&& Input.GetKeyDown(KeyCode.Q))
        {
            axe.SetActive(false);
            TrueLaserFalseAxe = true;
        }

        //swings the axe
        if (TrueLaserFalseAxe == false&& Time.time>nextFire&&Input.GetButton("Fire1"))
        {
            nextFire = Time.time + AxeDelay;
            //rotates the axe forwards to swing
            Vector3 endRotation = axe.transform.eulerAngles + new Vector3(0f, 90f, 90f);
            // SwingAxe(nextFire);

            swingingAxe = true;
            //axe.transform.Rotate(new Vector3(0,90,0)* Time.deltaTime);
            //axe.transform.eulerAngles = Vector3.Lerp(axe.transform.eulerAngles, endRotation, 10*Time.deltaTime);
            
        }
        if (swingingAxe)
        {
            //axe.transform.localRotation. = (new Vector3(10,0,0) * (Time.deltaTime*10));
            //axe.transform.RotateAround(axeRotateAround.transform.position, Vector3.forward, 10 * Time.deltaTime);
            axe.transform.rotation = Quaternion.Lerp(axe.transform.rotation, axeRotateAround.transform.rotation,0.1f*Time.deltaTime*90);

            float x = axe.transform.rotation.y;
            if (axe.transform.localRotation.eulerAngles.y >=87 )
            {
                swingingAxe = false;

                axe.transform.rotation = AxeReturnHere.transform.rotation;
                axeHaftReal.transform.position = axeHaftDesired.transform.position;
                axeHaftReal.transform.rotation = axeHaftDesired.transform.rotation;
            }
            
        }
        
        //shoots the laser
        if (Input.GetButton("Fire1") && Time.time>nextFire&&TrueLaserFalseAxe)
        {
            laserLine.enabled = true;
            nextFire = Time.time + delay;
            //StartCoroutine(ShotEffect());
            shotSound.Play();
            Vector3 rayOrigin = fpscamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            laserLine.SetPosition(0, gunEnd.transform.position);
            if (Physics.Raycast(rayOrigin, fpscamera.transform.forward, out hit, weaponRange))
            {
                laserLine.SetPosition(1, hit.point);
                Shootable health = hit.collider.GetComponent<Shootable>();
                if (health != null)
                {


                    if (health.tag == "enemy")
                    {
                        health.Damage(gunDamage);
                        if (hit.rigidbody != null)

                        {

                            hit.rigidbody.AddForce(-hit.normal * hitForce);

                        }
                    }
                }

            }
            else

            {
                laserLine.SetPosition(1, fpscamera.transform.forward * weaponRange);
            }
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Start();
       
            
            
        }

        if (Time.fixedTime > shotDuration)
        {
            shotDuration = Time.fixedTime + 0.2f;
            laserLine.enabled = false;
        }
    }

    /*private void FixedUpdate()
    {
        if (Time.fixedTime>shotDuration)
        {
            shotDuration = Time.fixedTime + 0.2f;
            laserLine.enabled = false;
        }
    }*/
    /* private IEnumerator ShotEffect()
     {
         gunAudio.Play();
         laserLine.enabled = true;

         yield return shotDuration;


     }*/
    
}
