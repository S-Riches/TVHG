using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class Death_screen : MonoBehaviour
{
     void Start()
    {

        BoxCollider2D DeathBox;
        
        // sets deathbox as a game object with boxcollider 
        DeathBox = gameObject.GetComponent<BoxCollider2D>() as BoxCollider2D;
        DeathBox.size = new Vector2(1.0f, 1.0f);
        DeathBox.isTrigger = true;
    }

    // creates a bool called restart
    private bool restart = false;

    void FixedUpdate()
    {
        if (restart == true)
        {
            // loads the game again if killed
            SceneManager.LoadScene("lose screen", LoadSceneMode.Single);
            
            restart = false;
        }
    }
    // called when when game object collides with player

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("GameObject1 collided with player" + col.name);
        restart = true;
    }




}
