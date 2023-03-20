using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lifePoints = 50;
    public float speed;
    public Rigidbody rb;
    public float jumpForce;

    public bool isWalking = false;
    public bool isJumping = false;
    public float rotationSpeed;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
       /* if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("Je vais tout droit");
            isWalking = true;
            isJumping = false;
            rb.velocity = new Vector3(0, 0, speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Je vais en arrière");
            rb.velocity = new Vector3(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Je vais à gauche");
            rb.velocity = new Vector3(-speed, rb.velocity.y, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Je vais à droite");
            rb.velocity = new Vector3(speed,  rb.velocity.y, 0);
        }*/

        if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("Je saute");
            isWalking = false;
            isJumping = true;
            rb.velocity = new Vector3(0, jumpForce, 0);
        }

       rb.AddForce((-transform.forward * Input.GetAxis("Vertical") +
                   transform.right * Input.GetAxis("Horizontal")) * speed);
        
       transform.localRotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X"), 0);

       

    }
}
