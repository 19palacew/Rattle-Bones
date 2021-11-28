using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XylophoneKeyWack : MonoBehaviour
{
    private Quaternion retRot;
    private int offset;
    private XylophoneSound sound;
    void Start()
    {
        gameObject.AddComponent<BoxCollider>().isTrigger = true;
        offset = 2;
        retRot = transform.rotation;
        sound = transform.parent.GetComponent<XylophoneSound>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Displace();
    }

    private void OnTriggerExit(Collider other)
    {
        ResetKey();
    }

    private void Displace()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(Random.Range(-offset,offset), Random.Range(-offset, offset), Random.Range(-offset, offset)));
        sound.PlaySound(transform.GetSiblingIndex());
    }

    private void ResetKey()
    {
        transform.rotation = retRot;
    }
}
