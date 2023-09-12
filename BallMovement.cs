using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    //variable for speed
    public float xspeed = 0; //variable for horizontal speed
    public float yspeed = 0; //varialbe for vertical speed

    //variable for borders
    private float xborder = 7.5f; //variable for horizontal border
    private float yborder = 4.5f; //varialbe for vertical border

    //variable for move state
    public bool xmove = true;
    public bool ymove = true;

    // Start is called before the first frame update
    void Start()
    {
        xspeed = 0.0125f; //declae value for horizontal speed
        yspeed = 0.0125f; //declae value for vertical speed
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal movement
        if (xmove == true)
        {
            transform.position = new Vector2(transform.position.x + xspeed, transform.position.y); //move right
        }
        else 
         {
            transform.position = new Vector2(transform.position.x - xspeed, transform.position.y); //move left
        }

        if (transform.position.x >= xborder)
        {
            xmove = false; ; //make it go left
        }

        if (transform.position.x <= -xborder)
        {
            xspeed *= -1;
        }

        //vertical movement

        transform.position = new Vector2(transform.position.x, transform.position.y + yspeed); //move up
        if (transform.position.y >= -yborder)
        {
            yspeed *= -1;
        }

        if (transform.position.y <= -yborder)
        {
            yspeed *= -1;
        }
    }

    void oncollisionenter2D(collision2D collision) //when a collision happen
    {
        debug.log("hit");
        if(collision.collider.comparetag("player"))
        {
            if (xmove == true)
            {
                xmove = false
            }
            else if (xmove == false)
            {
                xmove = true;
            }
        }
    }
}
