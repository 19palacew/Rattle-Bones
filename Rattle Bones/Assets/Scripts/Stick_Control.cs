using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick_Control : MonoBehaviour
{
    public float speed;
    public float whamSpeed;
    public float resetTime;
    public float animationTime;
    private Rigidbody rb;
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
        ani.StopPlayback();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 0);
        if (Input.GetKey("d"))
        {
            movement += (Vector3.right * speed) * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            movement += (Vector3.left * speed) * Time.deltaTime;
        }
        if (Input.GetKeyDown("w"))
        {
            ani.Play("Attack");
        }
        rb.velocity = movement + new Vector3(0, rb.velocity.y, 0);
        
    }
}
