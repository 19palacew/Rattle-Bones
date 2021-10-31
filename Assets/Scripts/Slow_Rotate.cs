using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow_Rotate : MonoBehaviour
{
    public float rate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.eulerAngles.y + rate, transform.eulerAngles.z);
    }
}
