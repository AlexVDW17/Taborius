using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunColor : MonoBehaviour {

    void Start()
    {
        GetComponent<Renderer>().material.color = Storage.Gun;
    }
}
