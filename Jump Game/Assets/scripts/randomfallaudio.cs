using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomfallaudio : MonoBehaviour
{
    [SerializeField]
    private AudioSource source;

    [SerializeField]
    private List<AudioClip> clips;


    private void Start()
    {
        GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            source.clip = clips[Random.Range(0, clips.Count)];
            source.Play();
        }
    }
}
