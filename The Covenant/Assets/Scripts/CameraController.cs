using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //transform.Rotate(new Vector3(0, 1,0), Input.GetAxis("Horizontal"));
       
       transform.localRotation *= Quaternion.Euler(-Input.GetAxis("Mouse Y"),0 , 0);
    }
}
