using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Explode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", 0.8f);
    }
    private void DestroyObject()
    {
        Destroy(gameObject);
    }
        
}
