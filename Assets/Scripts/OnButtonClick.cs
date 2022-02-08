using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnButtonClick : MonoBehaviour
{
    public Button playbutton;
    // Start is called before the first frame update
    void Start()
    {
        playbutton.onClick.AddListener(PlayButtonOnClick);
    }

    void PlayButtonOnClick()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
        Debug.Log("Button clicked");
    }

 
}
