using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour {

    public Transform firePoint;
    public GameObject magicBallPrefab;
    private float timer;
    GameObject clone;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }

        Destroy(clone.gameObject, 2f);
    }

    void shoot()
    {   
        clone = Instantiate(magicBallPrefab, firePoint.position, firePoint.rotation);
    }
}