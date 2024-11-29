using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    Vector3 value;

    public GameObject playerModel;

    public static PlayerMovement instance;

    public bool left = true;
    public bool up = false;

    public int speed;
    public float boost = 1;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // move forward always
        rb.linearVelocity = transform.forward * speed * boost;

        transform.rotation = Quaternion.Euler(value);
        if(left == true && up == false)
        {
            playerModel.transform.rotation = Quaternion.Euler(-90f, 90f, 90f);
        }
        else if(left == false && up == false)
        {
            playerModel.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        }
        else if (left == false && up == true)
        {
            playerModel.transform.rotation = Quaternion.Euler(90f, 180f, 270f);
        }
        else if (left == true && up == true)
        {
            playerModel.transform.rotation = Quaternion.Euler(90f, 180f, 90f);
        }
    }

    public void ChangeLeft()
    {
        speed = 4;
        value = new Vector3(0, -90, 0);
        left = true;
        up = false;
    }
    public void ChangeRight()
    {
        speed = 4;
        value = new Vector3(0, -270, 0);
        left = false;
        up = false;
    }
    public void ChangeUp()
    {
        speed = 4;
        value = new Vector3(0, -360, 0);
        left = false;
        up = true;
    }
    public void ChangeDown()
    {
        speed = 4;
        value = new Vector3(0, -180, 0);
        left = true;
        up = true;
    }
}


/*float x, z;
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(x, rb.velocity.y, z);*/