using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour {

    public Transform firePoint;
    public GameObject magicBallPrefab;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }

<<<<<<< HEAD

=======
>>>>>>> parent of b5fdcd8... dkd
    }

    void shoot()
    {
        Instantiate(magicBallPrefab, firePoint.position, firePoint.rotation);
    }
}