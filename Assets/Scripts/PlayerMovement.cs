using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 2f;
    private float y_angle = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 new_pos = rb.position;
        if(Input.GetKey(KeyCode.W))
        {
            new_pos.z += speed * Time.deltaTime;
            rb.position = new_pos;
        }

        if(Input.GetKey(KeyCode.S))
        {
            new_pos.z -= speed * Time.deltaTime;
            rb.position = new_pos;
        }


        if(Input.GetKey(KeyCode.A))
        {
            new_pos.x -= speed * Time.deltaTime;
            rb.position = new_pos;
        }

        if(Input.GetKey(KeyCode.D))
        {
            new_pos.x += speed * Time.deltaTime;
            rb.position = new_pos;
        }

        rb.position = new_pos;

    }
}
