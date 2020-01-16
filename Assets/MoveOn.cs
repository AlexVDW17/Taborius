using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveOn : MonoBehaviour {

    public GameObject Head, Body, Gun, Sphere;

   public void MovinOn()
    {
        Storage.Head = Head.GetComponent<Renderer>().material.color;
        Storage.Body = Body.GetComponent<Renderer>().material.color;
        Storage.Gun = Gun.GetComponent<Renderer>().material.color;
        Storage.Sphere = Sphere.GetComponent<Renderer>().material.color;
        UnityEngine.SceneManagement.SceneManager.LoadScene("WhoAreYou.unity");
    }
	
}
