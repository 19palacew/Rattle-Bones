using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Beat_Move : MonoBehaviour
{
    public float speed;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        Invoke("Death", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0,0,speed));
        time += Time.deltaTime;
    }

    private void Death()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Death();
    }
}
