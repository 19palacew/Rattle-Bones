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
    private Animator ani;
    private KeyCode right;
    private KeyCode left;
    private KeyCode up;
    private float upperBound;
    private float lowerBound;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
        if (isLeft)
        {
            right = KeyCode.D;
            left = KeyCode.A;
            up = KeyCode.W;
            upperBound = -1.75f;
            lowerBound = -9;
        }
        else
        {
            right = KeyCode.RightArrow;
            left = KeyCode.LeftArrow;
            up = KeyCode.UpArrow;
            upperBound = 9;
            lowerBound = 1.75f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3();
        if (Input.GetKey(right))
        {
            movement += (Vector3.right * -speed);
        }
        if (Input.GetKey(left))
        {
            movement += (Vector3.left * -speed);
        }
        if (Input.GetKeyDown(up))
        {
            ani.SetBool("Attack", true);
        }
        else
        {
            ani.SetBool("Attack", false);
        }
        transform.Translate(movement*Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, lowerBound, upperBound), transform.position.y, transform.position.z);
    }
}
