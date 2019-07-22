using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GM = null;
    public bool[] AcceptSpheres;
    public bool TesterMode;

    private void Start()
    {
        if (GM == null)
            GM = this;
        else if (GM == this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        AcceptSpheres = new bool[4];
        if (PlayerPrefs.HasKey("lvl2"))
        {
            if (PlayerPrefs.GetString("lvl2").Equals("True"))
                AcceptSpheres[0] = true;
            else
                AcceptSpheres[0] = false;
            
            if (PlayerPrefs.GetString("lvl3").Equals("True"))
                AcceptSpheres[1] = true;
            else
                AcceptSpheres[1] = false;
            
            if (PlayerPrefs.GetString("lvl4").Equals("True"))
                AcceptSpheres[2] = true;
            else
                AcceptSpheres[2] = false;
            
            if (PlayerPrefs.GetString("lvl5").Equals("True"))
                AcceptSpheres[3] = true;
            else
                AcceptSpheres[3] = false;
        }
    }
}
