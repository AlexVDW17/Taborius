using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    public GameObject colorChanging;
    public Material mycolor;
    // Use this for initialization
    public void changeItscolor()
    {

        colorChanging.GetComponent<Renderer>().material.color = mycolor.color;


    }
}
