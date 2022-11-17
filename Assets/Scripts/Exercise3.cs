using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    private float xRange = 3;
    void Update()
    {
        //With this we move from cell to cell, both vertically and horizontally, and we limit the spaces so that it does not go out of the "board"
        if (transform.position.y <= 4)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(0, 2f, 0);
            }
        }
        if (transform.position.y >= -2)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.Translate(0, -2f, 0);
            }
        }
        
        if(transform.position.x >= -xRange)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(-2f, 0, 0);
            }
        }

        if(transform.position.x <= xRange)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(2f, 0, 0);
            }
        }
    }
}
