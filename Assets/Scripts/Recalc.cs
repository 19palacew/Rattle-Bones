using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recalc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       transform.GetComponent<MeshFilter>().mesh.RecalculateNormals();
    }
}
