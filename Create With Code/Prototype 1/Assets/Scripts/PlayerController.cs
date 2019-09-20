using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    public float speed = 20f;
    public float turnSpeed;

    public float horizontalInput;
    public float loopHor = 0;
    public float accelHor = 1;
    public float accelRate;

    public float verticalInput;
    public float loop = 1;
    public float accel = 0.025f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput * loop);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput* accelHor);

        if(verticalInput > 0)
        {
            loop += accel;
        }
        else
        {
            loop -= accel;
            if(loop < 1)
            {
                loop = 1;
            }
        }

        if(horizontalInput < 0 || horizontalInput > 0)
        {
            loopHor++;
        }
        else
        {
            loopHor = 0;
            accelHor = 1;
        }

        accelHor += loop / accelRate;


        //transform.Translate(0, accelHor, 0);



        //if (Input.GetKey("up"))
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //}

        //if (Input.GetKey("down"))
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        //}
        //if (Input.GetKey("left"))
        //{
        //    transform.Rotate(0, -1, 0);
        //}

        //if (Input.GetKey("right"))
        //{
        //    transform.Rotate(0, 1, 0);
        //}

        //if (Input.GetKey("a"))
        //{
        //    transform.Rotate(0, 0, 5);
        //}
        //if (Input.GetKey("d"))
        //{
        //    transform.Rotate(0, 0, -5);
        //}

        //if (Input.GetKey("w"))
        //{
        //    transform.Rotate(5, 0, 0);
        //}
        //if (Input.GetKey("s"))
        //{
        //    transform.Rotate(-5, 0, 0);
        //}

    }
}
