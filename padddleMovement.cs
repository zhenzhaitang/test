using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rScript : MonoBehaviour
{
    //variable for movement
    public float speed = 10f;
    public float yborder = 4.5f;
    
    public gameobject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.getkey(keycode.0) && transform.position.y < yborder) // when 0 is pressed
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed); //move up
        }

        if (Input.getkey)
    }
}
