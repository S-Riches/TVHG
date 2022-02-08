using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    public Button controls; 
    // Start is called before the first frame update
    void Start()
    {
        controls.onClick.AddListener(CButtonOnClick);
    }
    
    void CButtonOnClick()
    {
        SceneManager.LoadScene("Controls", LoadSceneMode.Single);
        Debug.Log("Buttonclicked");
            
    }
}
