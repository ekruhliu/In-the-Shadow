using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player PlayerSaves = null;
    public static bool lvl1;
    public static bool lvl2;
    public static bool lvl3;
    public static bool lvl4;
    public static bool lvl5;

    private void Awake()
    {
        if (PlayerSaves == null)
            PlayerSaves = this;
        else if (PlayerSaves == this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
        
        Initialize();
        
    }

    private void Initialize()
    {
        lvl1 = true;
        if (PlayerPrefs.HasKey("lvl2"))
            lvl2 = System.Convert.ToBoolean(PlayerPrefs.GetString("lvl2", "true"));
        else
            lvl2 = false;
        if (PlayerPrefs.HasKey("lvl3"))
            lvl3 = System.Convert.ToBoolean(PlayerPrefs.GetString("lvl3", "true"));
        else
            lvl3 = false;
        if (PlayerPrefs.HasKey("lvl4"))
            lvl4 = System.Convert.ToBoolean(PlayerPrefs.GetString("lvl4", "true"));
        else
            lvl4 = false;
        if (PlayerPrefs.HasKey("lvl5"))
            lvl5 = System.Convert.ToBoolean(PlayerPrefs.GetString("lvl5", "true"));
        else
            lvl5 = false;
    }

    public static void saveLevels()
    {
        PlayerPrefs.SetString("lvl2", lvl2.ToString());
        PlayerPrefs.SetString("lvl3", lvl2.ToString());
        PlayerPrefs.SetString("lvl4", lvl2.ToString());
        PlayerPrefs.SetString("lvl5", lvl2.ToString());
        PlayerPrefs.Save();
    }
}
