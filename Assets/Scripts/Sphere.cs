using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public int num;
    public bool accept;

    private void Awake()
    {
        if (gameObject.name == "Level 1")
            accept = true;
        else
            accept = GameManager.GM.AcceptSpheres[num];
        if (accept)
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        else
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
