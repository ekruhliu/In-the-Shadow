using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public bool accept;

    private void Awake()
    {
        if (accept)
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        else
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
