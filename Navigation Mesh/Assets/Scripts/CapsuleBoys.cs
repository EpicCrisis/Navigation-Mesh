using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CapsuleBoys : MonoBehaviour
{

	NavMeshAgent navMeshAgent;

	public Transform target;

	void Start ()
	{
		navMeshAgent = this.GetComponent<NavMeshAgent> ();
	
		StartCoroutine (RepathRoutine ());
	}


	void Update ()
	{
		
	}

	IEnumerator RepathRoutine ()
	{
		while (true) {
			yield return new WaitForSeconds (0.5f);
			navMeshAgent.SetDestination (target.position);
		}
	}
}
