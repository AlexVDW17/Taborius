using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour {

    private static Color body, head, gun, sphere;

    public static Color Body
    {
        get
        {
            return body;
        }
        set
        {
            body = value;
        }
    }
    public static Color Head
    {
        get
        {
            return head;
        }
        set
        {
            head = value;
        }
    }
    public static Color Gun
    {
        get
        {
            return gun;
        }
        set
        {
            gun = value;
        }
    }
    public static Color Sphere
    {
        get
        {
            return sphere;
        }
        set
        {
            sphere = value;
        }
    }
}
