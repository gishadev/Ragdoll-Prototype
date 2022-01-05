using UnityEngine;

public class ActiveRagdollController : MonoBehaviour
{
    [Header("Ragdoll Options")] [SerializeField]
    private int solverIterations;

    [SerializeField] private int solverVelocityIterations;
    [SerializeField] private float maxAngularVelocity;

    [Header("Active Ragdoll Options")] [SerializeField]
    private Transform animatedRoot, physicalRoot;

    private Rigidbody[] _rigidbodies;
    private Transform[] animatedTransforms;
    
    
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