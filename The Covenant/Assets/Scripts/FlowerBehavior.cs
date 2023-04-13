using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBehavior : MonoBehaviour
{
    public AnimationClip flower;
    public AnimationClip flowerout;
    public Animation anim;
    public GameObject fleur;
    public Transform target;

    private void Awake()
    {
        Debug.Log("yes");
    }

    // Start is called before the first frame update
    void Start()
    {
        anim.clip = flowerout;
        anim.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target);
    }

    private void OnTriggerEnter(Collider other)
    {
        anim.clip = flower;
        anim.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        anim.clip = flowerout;
        anim.Play();
    }
    
    
}
