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
    }
}
