using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move vehicle forward

        //transform.Translate(Vector3.forward * Time.deltaTime * 20);

        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey("down"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 0, 5);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, -5);
        }

        if (Input.GetKey("w"))
        {
            transform.Rotate(5, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.Rotate(-5, 0, 0);
        }

    }
}
