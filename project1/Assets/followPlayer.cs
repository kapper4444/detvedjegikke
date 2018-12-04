using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {
    public Transform player;
    public Vector3 offset;
    public float damping = 1;
    public float rotateSpeed = 5;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = player.position + offset;

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        //transform.rotation = player.transform.rotation;
        
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        player.transform.Rotate(0, horizontal, 0);
        
        float desiredAngle = player.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
        transform.position = player.transform.position - (rotation * offset);

        //transform.LookAt(player.transform);
        
    }

}
