using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleFollow : MonoBehaviour {

	protected NavMeshAgent navMeshAgent;
	public Transform target;

	void Start () 
	{
		navMeshAgent = GetComponent<NavMeshAgent> ();

		InvokeRepeating ("UpdateTarget", 3f, 3f);
	}

	void UpdateTarget()
	{
		navMeshAgent.SetDestination (target.position);
	}
	
	void Update () 
	{
		
	}
}
