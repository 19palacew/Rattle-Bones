using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick_Control : MonoBehaviour
{
    public float speed;
    public float whamSpeed;
    public float resetTime;
    public float animationTime;
    public bool isLeft;
    private Rigidbody rb;
    private Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 0);
        if (isLeft)
        {
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
                ani.SetBool("Attack", true);
            }
            else
            {
                ani.SetBool("Attack", false);
            }
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -6, -.5f), transform.position.y, transform.position.z);
        }
        else
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                movement += (Vector3.right * speed) * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                movement += (Vector3.left * speed) * Time.deltaTime;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                ani.SetBool("Attack", true);
            }
            else
            {
                ani.SetBool("Attack", false);
            }
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, .5f, 6), transform.position.y, transform.position.z);
        }
        rb.velocity = movement + new Vector3(0, rb.velocity.y, 0);         
    }
}
