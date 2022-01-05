using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    [SerializeField] private int solverIterations;
    [SerializeField] private int solverVelocityIterations;
    [SerializeField] private float maxAngularVelocity;

    private Rigidbody[] _rigidbodies;

    private void Awake()
    {
        _rigidbodies = GetComponentsInChildren<Rigidbody>();
    }

    private void Start()
    {
        foreach (var rb in _rigidbodies)
        {
            rb.solverIterations = solverIterations;
            rb.solverVelocityIterations = solverVelocityIterations;
            rb.maxAngularVelocity = maxAngularVelocity;
        }
    }
}