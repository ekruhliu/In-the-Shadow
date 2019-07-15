using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

public class Rotation : MonoBehaviour
{
    private bool click;
    private bool done;
    bool done4;
    bool done2;
    [SerializeField] private GameObject canvas;

    [SerializeField] private GameObject currentObj = null;
    
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
            Moves();
        }
        
        if (SceneManager.GetActiveScene().name.Equals("Level 1"))
        {
            currentObj = GameObject.Find("tea_pot");
            if (((currentObj.transform.rotation.x >= 0.0f && currentObj.transform.rotation.x <= 0.1f)
                 && (currentObj.transform.rotation.y >= 0.94f && currentObj.transform.rotation.y <= 0.98f)
                 && (currentObj.transform.rotation.z >= -0.07f && currentObj.transform.rotation.z <= 0.0f)
                 && (currentObj.transform.rotation.w >= 0.2f && currentObj.transform.rotation.w <= 0.3f)))
            {
                done = true;
                canvas.gameObject.SetActive(true);
                //GameManager.GM.AcceptSpheres[0] = true;
            }
        }

        if (SceneManager.GetActiveScene().name.Equals("Level 2"))
        {
            currentObj = GameObject.Find("elephant");
            if (((currentObj.transform.rotation.x >= -0.18f && currentObj.transform.rotation.x <= 0.18f)
                 && (currentObj.transform.rotation.y >= -0.69f && currentObj.transform.rotation.y <= 0.69f)
                 && (currentObj.transform.rotation.z >= -0.76f && currentObj.transform.rotation.z <= 0.76f)
                 && (currentObj.transform.rotation.w >= -0.17f && currentObj.transform.rotation.w <= 0.17f)))
            {
                done = true;
                canvas.gameObject.SetActive(true);
                //GameManager.GM.AcceptSpheres[1] = true;
            }
        }

        if (SceneManager.GetActiveScene().name.Equals("Level 3"))
        {
            GameObject logo2, logo4;
            logo4 = GameObject.Find("logo-4");
            logo2 = GameObject.Find("logo-2");
            if (!currentObj)
                currentObj = logo4;
            if (Input.GetKeyDown(KeyCode.Alpha1))
                currentObj = logo4;
            if (Input.GetKeyDown(KeyCode.Alpha2))
                currentObj = logo2;

            if (((logo4.transform.rotation.x >= -0.1f && logo4.transform.rotation.x <= 0.1f)
                 && (logo4.transform.rotation.y >= 0.8f && logo4.transform.rotation.y <= 1.0f)
                 && (logo4.transform.rotation.z >= -0.1f && logo4.transform.rotation.z <= 0.1f)
                 && (logo4.transform.rotation.w >= -0.31f && logo4.transform.rotation.w <= 0.31f)))
                done4 = true;
            else
                done4 = false;
            if (((logo2.transform.rotation.x >= -0.1f && logo2.transform.rotation.x <= 0.1f)
                 && (logo2.transform.rotation.y >= 0.8f && logo2.transform.rotation.y <= 1.0f)
                 && (logo2.transform.rotation.z >= -0.1f && logo2.transform.rotation.z <= 0.1f)
                 && (logo2.transform.rotation.w >= -0.31f && logo2.transform.rotation.w <= 0.31f)))
                done2 = true;
            else
                done2 = false;

            if (done4 && done2)
            {
                done = true;
                canvas.gameObject.SetActive(true);
                //GameManager.GM.AcceptSpheres[2] = true; 
            }
        }

        if (SceneManager.GetActiveScene().name.Equals("Level 4"))
        {
            
        }

        if (SceneManager.GetActiveScene().name.Equals("Level 5"))
        {
            
        }
        
        if (currentObj)
            Debug.Log("X: " + currentObj.transform.rotation.x + " Y: " + currentObj.transform.rotation.y + " Z: " + currentObj.transform.rotation.z + " W: " + currentObj.transform.rotation.w);
    }

    void OnMouseDrag()
    {
        if (currentObj)
        {
            float rotX = Input.GetAxis("Mouse X") * 20f * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * 20f * Mathf.Deg2Rad;
            currentObj.transform.RotateAround(Vector3.up, -rotX);
            currentObj.transform.RotateAround(Vector3.right, -rotY);
        }
    }

    void Moves()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            currentObj.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.DownArrow))
            currentObj.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.LeftArrow))
            currentObj.transform.Translate(Vector3.left * Time.deltaTime, Space.World);
        if (Input.GetKey(KeyCode.RightArrow))
            currentObj.transform.Translate(Vector3.right * Time.deltaTime, Space.World);
    }
    
    public void BackToMenu() { SceneManager.LoadScene("LevelMenu"); }
}
