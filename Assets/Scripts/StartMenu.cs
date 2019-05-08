using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;
using Image = UnityEngine.UI.Image;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Button _continue;
    private Text _contText;

    public bool canContinue;
    
    private void Awake()
    {
        canContinue = false;
        if (canContinue)
        {
            _continue.GetComponent<Button>().enabled = true;
            _continue.GetComponent<Image>().color = new Color(255,255,255, 255);
            _contText = _continue.GetComponentInChildren<Text>();
            _contText.color = new Color(255, 255, 255, 255);
        }
    }

    public void StartGameEvent() { Application.LoadLevel("LevelMenu"); }
    
    public void ExitEvent() { Application.Quit(); }
}
