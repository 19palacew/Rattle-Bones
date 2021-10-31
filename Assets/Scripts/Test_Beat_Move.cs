using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Beat_Move : MonoBehaviour
{
    public float speed;
    public float time;
    public Score scoreScript;
    public TurboMode turboScript;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        Invoke("Death", 4f);
        scoreScript = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
        turboScript = GameObject.FindGameObjectWithTag("Turbo").GetComponent<TurboMode>();
    }

    // Update is called once per frame
    void FixedUpdate()
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
        if (!turboScript.overcharged)
        {
            scoreScript.score += 10;
        }
        else
        {
            scoreScript.score += 15;
        }
        turboScript.charge += .1f;
        Death();
    }
}
