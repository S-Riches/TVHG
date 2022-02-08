using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Death_timer : MonoBehaviour
{

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Game", LoadSceneMode.Single);
        }
      
    }
}
