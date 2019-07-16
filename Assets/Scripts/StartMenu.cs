using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Button _continue;
    private Text _contText;

    
    private void Awake()
    {
        if (PlayerPrefs.HasKey("lvl2"))
        {
            _continue.GetComponent<Button>().enabled = true;
            _continue.GetComponent<Image>().color = new Color(255,255,255, 255);
            _contText = _continue.GetComponentInChildren<Text>();
            _contText.color = new Color(255, 255, 255, 255);
        }
    }

    public void StartGameEvent() { SceneManager.LoadScene("LevelMenu"); }

    public void StartTestMode()
    {
        SceneManager.LoadScene("LevelMenu");
        GameManager.GM.TesterMode = true;
        for (int i = 0; i < GameManager.GM.AcceptSpheres.Length; i++)
            GameManager.GM.AcceptSpheres[i] = true;
    }
    
    public void ExitEvent() { Application.Quit(); }
}
