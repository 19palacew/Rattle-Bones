using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick_Control : MonoBehaviour
{
    public float speed;
    public float whamSpeed;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 0);
        if (Input.GetKey("d"))
        {
            movement += (Vector3.right * speed);
        }
        if (Input.GetKey("a"))
        {
            movement += (Vector3.left * speed);
        }
        if (Input.GetKey("w"))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(new Vector3(90,0,0)), whamSpeed);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(new Vector3(0, 0, 0)), whamSpeed);
        }
        rb.velocity = movement + new Vector3(0, rb.velocity.y, 0);
    }
}
