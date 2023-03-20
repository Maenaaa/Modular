using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public Animation open;
    public AudioSource audioSource;
    public AudioClip porte;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        open.Play();
        audioSource.PlayOneShot(porte);
        print("paf");
    }
}
