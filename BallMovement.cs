using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    //variable for speed
    public float xSpeed = 0; //variable for horizontal speed
    public float ySpeed = 0; //variable for vertical speed
    //variable for borders
    private float xBorder = 7.5f; //variable for horizontal border
    private float yBorder = 4.5f; //variable for vertical border

    //variable for move state
    public bool xMove = true;
    public bool yMove = true;

    //variable for score
    int playerOneScore;
    public Text ScoreTextp1;

    int playerTwoScore;
    public Text ScoreTextp2;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.0125f;   //declare value for horizontal speed
        ySpeed = 0.0125f;   //declare value for vertical speed
    }
    // Update is called once per frame
    void Update()
    {
        //horizontal movement
        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); //move right
        }
        else
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y); //move left
        }


        if (transform.position.x >= xBorder)
        {
            //xSpeed = -xSpeed; //make it go left
            xMove = false; //make it go left
            playerOneScore += 1;
        }

        if (transform.position.x <= -xBorder)
        {
            //xSpeed *= -1;
            xMove = true;
            playerTwoScore += 1;
        }

        //vertical movement
        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //move up
        }

        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed);   //move down
        }
        if (transform.position.y >= yBorder)
        {
            //ySpeed *= -1;
            yMove = false;
        }

        if (transform.position.y <= -yBorder)
        {
            //ySpeed *= -1;
            yMove = true;
        }

        ScoreTextp1.text = playerOneScore.ToString();

        ScoreTextp2.text = playerTwoScore.ToString();

    }

    void OnCollisionEnter2D(Collision2D collision) //when a collision happens
    {
        Debug.Log("hit");
        if (collision.collider.CompareTag("Player"))
        {
            if (xMove == true)
            {
                xMove = false;
            }
            else if (xMove == false)
            {
                xMove = true;
            }
        }
    }
}