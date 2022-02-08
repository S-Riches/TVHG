using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovement : MonoBehaviour
{
    public float speed = 300.0f;
    public GameObject character;

    private Rigidbody2D charbody;
    private float screenwidth;
    // Start is called before the first frame update
    void Start()
    {
        screenwidth = Screen.width;
        charbody = character.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        // for while loop

        while(i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > screenwidth / 2)
            {
                RunCharacter(1.0f);
            }
            if(Input.GetTouch(i).position.x < screenwidth / 2)
            {
                RunCharacter(-1.0f);
            }
            i++;
        }
    }
    private void RunCharacter(float horizontalInput)
    {
        charbody.AddForce(new Vector2(horizontalInput * speed * Time.deltaTime, 0.0f));

    }
}
