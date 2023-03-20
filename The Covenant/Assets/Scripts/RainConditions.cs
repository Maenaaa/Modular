using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RainConditions : MonoBehaviour
{
    public ParticleSystem rain;
    public ParticleSystem fog;
    public GameObject buttonR;
    public AudioSource audioSource2;
    public AudioClip pluie;
    

    // Start is called before the first frame update
    void Start()
    {
        buttonR.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            rain.Play();
            fog.Play();
            print("Il pleut!");
            audioSource2.PlayOneShot(pluie);
        }
    }

    private void OnTriggerStay(Collider player)
    {
        buttonR.SetActive(true);
    }

    void OnTriggerExit(Collider player)
    {
        buttonR.SetActive(false);
    }
}
