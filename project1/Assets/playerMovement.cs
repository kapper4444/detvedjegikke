using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float movementForce = 750f;
    public float moveSpeed = 3.0f;
    public float shiftSpeed = 300.0f;
    public float currentSpeed;
    public float jumpForce = 7f;
    public bool isgrounded = true;
    public bool playerRun = false;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    float max = -90f;
    float minimum = 90f;
    private float pitch = 0.0f;
    //public BoxCollider col;
    //public LayerMask groundLayers;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {

        //This makes the player move forward, left and so on
        var x1 = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var z1 = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(x1, 0, 0);
        transform.Translate(0, 0, z1);

        //Making player jump

        if (isgrounded == true)
        {
            if (Input.GetKeyDown("space"))
            {

                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            }
        }



        //This makes the player sprint

        if (/*playerRun == true &&*/ Input.GetKeyDown("left shift"))
        {
            currentSpeed = moveSpeed;
            moveSpeed = shiftSpeed;
            Debug.Log("You Are in the if statement");
        }
        if (playerRun == false && Input.GetKeyUp("left shift"))
        {
            moveSpeed = currentSpeed;
            Debug.Log("You are also here");
        }

        
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(0, yaw, 0.0f);
        
    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Ground")
        {
            isgrounded = true;
        }
    }
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Ground")
        {
            isgrounded = false;
        }
    }
}