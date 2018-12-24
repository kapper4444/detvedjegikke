using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyController : MonoBehaviour {

    public float lookRadius = 10f;
    public int health = 50;

    Transform target;
    NavMeshAgent agentE;

	// Use this for initialization
	void Start () {

        target = PlayerManager.instance.player.transform;
        agentE = GetComponent<NavMeshAgent>();
		
	}
	
	// Update is called once per frame
	void Update () {

        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agentE.SetDestination(target.position);

            if (distance <= agentE.stoppingDistance)
            {
                //Attack the target
                //Face the taget
                faceTarget();
            }
        }

	}

    void faceTarget ()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected () {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    public void takeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            die();

        }
    }

    void die()
    {
        Destroy(gameObject);
    }
}