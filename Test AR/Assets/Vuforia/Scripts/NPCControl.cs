using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCControl : MonoBehaviour {

	private UnityEngine.AI.NavMeshAgent agent;

	public Transform target;
	// Use this for initialization
	void Awake () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();	
	}
	
	// Update is called once per frame
	void Update () {

		agent.SetDestination (target.position);
	}
}
