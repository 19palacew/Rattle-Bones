using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Notes : MonoBehaviour
{
    public int bpm;
    public float songDelay;
    public GameObject beat;
    public AudioClip song;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNote", 0, 1/(bpm/60f));
        Invoke("PlaySong", songDelay);
    }

    private void PlaySong()
    {
        AudioSource speaker = GetComponent<AudioSource>();
        speaker.clip = song;
        speaker.Play();
    }

    private void SpawnNote()
    {
        Instantiate(beat, transform.GetChild(Random.Range(0,6)));
    }
}
