using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropener : MonoBehaviour {
    public GameObject Disactivating;
    public bool needsOtherActivated = false;
    // Use this for initialization
    public void Disactivate()
    {
        Disactivating.SetActive(false);
        PLayBob pLayBob = this.gameObject.GetComponent<PLayBob>();
        pLayBob.Launch();
    }
}
