using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public Button BackButton;
    // Start is called before the first frame update
    void Start()
    {
        BackButton.onClick.AddListener(BackButtonOnClick);
    }

    void BackButtonOnClick()
    {
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
        Debug.Log("Buttonclicked");

    }
}
