using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayBob : MonoBehaviour {
    public AudioSource bob;
    private bool isplay = false;
     void Update()
    {
        if (isplay)
        {
            if (bob.isPlaying == false)
            {
                bob.Play();
            }
            
        }  
    }
    // Use this for initialization
    public void Launch()
    {
        bob.Play();
        isplay = true;
    }
}
