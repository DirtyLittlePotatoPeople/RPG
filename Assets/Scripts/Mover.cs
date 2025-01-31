﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
	// Configuration parameters
	[SerializeField] Transform target;

	// Cached references

	// State

	void Start()
	{
		
	}

	private void MoveToCursor()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		bool hasHit = Physics.Raycast(ray, out hit);
		
		if (hasHit)
		{
			GetComponent<NavMeshAgent>().destination = hit.point;
		}
		
	}

	void Update()
	{
		if (Input.GetMouseButton(0))
		{
			MoveToCursor();
		}
		UpdateAnimator();
	}

	private void UpdateAnimator()
	{
		Vector3 velocity = GetComponent<NavMeshAgent>().velocity;
		Vector3 localVelocity = transform.InverseTransformDirection(velocity);
		float speed = localVelocity.z;
		GetComponent<Animator>().SetFloat("forwardSpeed", speed);
	}
}
