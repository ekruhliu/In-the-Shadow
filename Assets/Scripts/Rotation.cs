using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Rotation : MonoBehaviour
{
    private bool click;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            click = true;
        if (Input.GetMouseButtonUp(0))
            click = false;
        if (click)
            OnMouseDrag();
        //Debug.Log("X: " + gameObject.transform.rotation.x + " Y: " + gameObject.transform.rotation.y + " Z: " + gameObject.transform.rotation.z + " W: " + gameObject.transform.rotation.w);
        if (((gameObject.transform.rotation.x >= 0.0f && gameObject.transform.rotation.x <= 0.2f)
            && (gameObject.transform.rotation.y >= 0.9f && gameObject.transform.rotation.y <= 1.0f)
            && (gameObject.transform.rotation.z >= -0.1f && gameObject.transform.rotation.z <= 0.0f)
            && (gameObject.transform.rotation.w >= 0.2f && gameObject.transform.rotation.w <= 0.3f)))
            Debug.Log("Completed");
        else if (((gameObject.transform.rotation.x >= -0.1f && gameObject.transform.rotation.x <= 0.0f)
                && (gameObject.transform.rotation.y >= -0.3f && gameObject.transform.rotation.y <= -0.2f)
                && (gameObject.transform.rotation.z >= -0.1f && gameObject.transform.rotation.z <= 0.0f)
                && (gameObject.transform.rotation.w >= 0.9f && gameObject.transform.rotation.w <= 1.0f)))
            Debug.Log("Completed");
        //right = 0.0-0.2, 0.9-1.0, 0.0- -0.1, 0.2-0.3
        //left = 0.0-0.1, 0.2-0.3, 0.0-0.1, -1.0- -0.9
        //transform.rotation.
    }

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * 20f * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * 20f * Mathf.Deg2Rad;
        
        gameObject.transform.RotateAround(Vector3.up, -rotX);
        gameObject.transform.RotateAround(Vector3.right, -rotY);
    }
}
