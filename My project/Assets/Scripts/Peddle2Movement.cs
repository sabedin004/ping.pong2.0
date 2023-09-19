using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peddle2Movement : MonoBehaviour
{
    //variable for movement
    public float speed = 0.1f;
    public float yBorder = 4.5f;

    public GameObject right;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < yBorder)    //when W is pressed
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);   //move up
        }

        if (Input.GetKey(KeyCode.S) && transform.position.y > -yBorder)    //when S is pressed
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed); //move down
        }
    }
}