using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Experimental.UIElements;

public class Rotation : MonoBehaviour
{
    private bool click;
    private bool done;
    [SerializeField] private GameObject canvas;
    
    private void Update()
    {
        if (!done)
        {
            if (Input.GetMouseButtonDown(0))
                click = true;
            if (Input.GetMouseButtonUp(0))
                click = false;
            if (click)
                OnMouseDrag();
        }
        //Debug.Log("X: " + gameObject.transform.rotation.x + " Y: " + gameObject.transform.rotation.y + " Z: " + gameObject.transform.rotation.z + " W: " + gameObject.transform.rotation.w);
        Debug.Log(gameObject.tag);
        if (gameObject.tag.Equals("TeaPot"))
        {
            if (((gameObject.transform.rotation.x >= -0.1f && gameObject.transform.rotation.x <= 0.2f)
                 && (gameObject.transform.rotation.y >= 0.8f && gameObject.transform.rotation.y <= 1.0f)
                 && (gameObject.transform.rotation.z >= -0.2f && gameObject.transform.rotation.z <= 0.1f)
                 && (gameObject.transform.rotation.w >= 0.2f && gameObject.transform.rotation.w <= 0.3f)))
            {
                Debug.Log("Completed");
                done = true;
                canvas.gameObject.SetActive(true);
            }
        }
    }

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * 20f * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * 20f * Mathf.Deg2Rad;
        
        gameObject.transform.RotateAround(Vector3.up, -rotX);
        gameObject.transform.RotateAround(Vector3.right, -rotY);
    }

    public void BackToMenu() { Application.LoadLevel("LevelMenu"); }
}
