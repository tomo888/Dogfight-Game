using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;

public class Chase : MonoBehaviour {


	Foo pTracker;

	void Start()
	{
		pTracker = transform.parent.parent.GetComponent<Foo> ();
	}

	void OnTriggerEnter(Collider playerPlane)
	{
		Debug.Log ("trigger");

		if (playerPlane.tag == "PlayerCollider")
		{
			
			pTracker.circuit = GameObject.FindWithTag ("ChaseCircuit").GetComponent<WaypointCircuit>();
		}
	}

}
