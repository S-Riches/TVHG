using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Winscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D WinBox;

        // sets deathbox as a game object with boxcollider 
        WinBox = gameObject.GetComponent<BoxCollider2D>() as BoxCollider2D;
        WinBox.size = new Vector2(1.0f, 1.0f);
        WinBox.isTrigger = true;
    }

    private bool Win = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Win == true)
        {
            SceneManager.LoadScene("win screen", LoadSceneMode.Single);
            Win = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Win box Colided with " + col.name);
        Win = true;
    }
}
