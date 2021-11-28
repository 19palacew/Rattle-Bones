using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XylophoneSound : MonoBehaviour
{
    private AudioSource audioSrc;
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void PlaySound(float pitch)
    {
        pitch /= 14;
        pitch += .5f;
        audioSrc.outputAudioMixerGroup.audioMixer.SetFloat("Pitch", pitch);
        audioSrc.Play();
    }
}
