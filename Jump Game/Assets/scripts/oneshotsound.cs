using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneshotsound  : MonoBehaviour
{ 
    public AudioClip sound;
    private AudioSource source;

	void Start ()
    {
        source = GetComponent<AudioSource>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            source.PlayOneShot(sound);
        }
    }
}
