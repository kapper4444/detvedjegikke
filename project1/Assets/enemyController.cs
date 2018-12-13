using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyController : MonoBehaviour {

    public float lookRadius = 10f;

    Transform target;
    NavMeshAgent agentE;

	// Use this for initialization
	void Start () {

        target = PlayerManager.instance.player.transform;
        agentE = GetComponent<NavMeshAgent>();
		
	}
	
	// Update is called once per frame
	void Update () {
		


	}

    void OnDrawGizmosSelected () {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
