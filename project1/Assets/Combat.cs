using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour {

    Camera cam;
    Vector3 rayOrigin = new Vector3(0.5f, 0.5f, 0);
    public LayerMask mask;
    float rayLength = 500f;
    public int irange = 5;
    RaycastHit hit;

    // Use this for initialization
    void Start () {
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) {

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> parent of b5fdcd8... dkd
=======
>>>>>>> parent of b5fdcd8... dkd
=======
>>>>>>> parent of b5fdcd8... dkd
    }
=======
            if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, rayLength)) {
>>>>>>> parent of b874951... Version 0.0.0.7

                Debug.Log("We hit " + hit.collider.name + " " + hit.point);
            }
           
        }
		
	}
}