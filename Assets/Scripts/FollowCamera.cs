using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
	// Configuration parameters
	[SerializeField] Transform target;

	// Cached references

	// State


	void Start()
	{
		
	}

	void LateUpdate()
	{
		transform.position = target.position;
	}
}
