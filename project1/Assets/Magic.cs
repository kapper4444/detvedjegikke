using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicBall : MonoBehaviour
{
    public float speed = 20;
    int damage = 5;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * speed;
    }


    private void OnTriggerEnter(Collider hitInfo)
    {
        enemyController enemy = hitInfo.GetComponent<enemyController>();
        if(enemy != null)
        {
            enemy.takeDamage(damage);
        }
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
