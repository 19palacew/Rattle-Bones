using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Notes : MonoBehaviour
{
    public int bpm;
    public float songDelay;
    public GameObject beat;
    public GameObject explosion;
    public AudioClip song;
    public bool[,] notes;
    private int cannonNum = 6;
    private int counter;
    public bool random;
    // Start is called before the first frame update
    void Start()
    {
        if (random)
        {
            InvokeRepeating("FireRandom", 0, 1 / (bpm / 60f));
        }
        else
        {
            InvokeRepeating("SpawnNoteCustom", 0, 1 / (bpm / 60f));
        }
        Invoke("PlaySong", songDelay);
        counter = 0;
        notes = new bool[3,cannonNum];
        notes[0 ,1] = true;
        notes[1, 2] = true;
        notes[2, 3] = true;
    }

    private void PlaySong()
    {
        AudioSource speaker = GetComponent<AudioSource>();
        speaker.clip = song;
        speaker.Play();
    }

    private void SpawnNoteCustom()
    {
        for (int currentNoteNum = 0; currentNoteNum < cannonNum; currentNoteNum++)
        {
            if (notes[counter, currentNoteNum])
            {
                Fire(currentNoteNum);
            }
        }
        if (counter<notes.GetLength(0)-1)
        {
            counter++;
        }
        else
        {
            CancelInvoke("SpawnNote");
        }
    }

    private void Fire(int theCannonNum)
    {
        GameObject cannon = Instantiate(beat, transform.GetChild(theCannonNum)).gameObject;
        Instantiate(explosion, cannon.transform).transform.parent = gameObject.transform;
    }

    private void FireRandom()
    {
        GameObject cannon = Instantiate(beat, transform.GetChild(Random.Range(0,7))).gameObject;
        Instantiate(explosion, cannon.transform).transform.parent = gameObject.transform;
    }
}
