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
        
        if ((gameObject.transform.rotation.x >= -3f && gameObject.transform.rotation.x <= 3f) && (gameObject.transform.rotation.y >= -3f && gameObject.transform.rotation.y <= 3f) && (gameObject.transform.rotation.z >= -5f && gameObject.transform.rotation.z <= 5f))
            Debug.Log("Completed");
    }

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * 20f * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * 20f * Mathf.Deg2Rad;
        
        gameObject.transform.RotateAround(Vector3.up, -rotX);
        gameObject.transform.RotateAround(Vector3.right, -rotY);
    }
}
