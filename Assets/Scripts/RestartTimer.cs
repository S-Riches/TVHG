using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTimer : MonoBehaviour
{
  
    private bool Restart = false;


    // Update is called once per frame
    void FixedUpdate()
    {
        int i = 0;
        if (Restart == true)
        {
            SceneManager.LoadScene("Title", LoadSceneMode.Single);
            Restart = false;
        }

        if(Input.GetKeyDown("space"))
        {
            Restart = true;
        }
       while(i > Input.touchCount)
        {
            if(Input.GetTouch(i).position.x > 0)
            {
                Restart = true;
            }
        }
       
    }

    
}
