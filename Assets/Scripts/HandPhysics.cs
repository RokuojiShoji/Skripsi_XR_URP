using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPhysics : MonoBehaviour
{
    [SerializeField] private GameObject followObject;
    [SerializeField] private float followSpeed = 30f;
    [SerializeField] private float rotateSpeed = 100f;
    [SerializeField] private float range = 0.1f;
    [SerializeField] private LayerMask physicsMask = 0;
    private Transform _followTarget;
    private Rigidbody _body;
    private string movementID;

    private void Start()
    {
        _followTarget = followObject.transform;
        _body = GetComponent<Rigidbody>();
        _body.collisionDetectionMode = CollisionDetectionMode.Continuous;
        _body.interpolation = RigidbodyInterpolation.Interpolate;
        _body.mass = 20f;

        _body.position = _followTarget.position;
        _body.rotation = _followTarget.rotation;

    }

    // Update is called once per frame
    private void Update()
    {
        if (!InRange())
            ImmediateMove();
        else
            PhysicsMove();
    }

    private void OnDrawGizmoz()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }

    public bool InRange()
    {
        return Physics.CheckSphere(transform.position, range, physicsMask, QueryTriggerInteraction.Ignore);
    }
    // private void OnCollisionEnter (Collision other)
    // {
    //     movementID = "physic";
    //     Debug.Log("change to physic");
    // }

    // private void OnCollisionExit (Collision other)
    // {
    //     movementID = "immediate";
    //     Debug.Log("change to immediate");
    // }

    private void PhysicsMove()
    {
        // position
        var distance = Vector3.Distance(_followTarget.position, transform.position);
        _body.velocity = (_followTarget.position - transform.position).normalized * (followSpeed * distance);

        // rotation
        var q = _followTarget.rotation * Quaternion.Inverse(_body.rotation);
        q.ToAngleAxis(out float angle, out Vector3 axis);
        _body.angularVelocity = angle * axis * Mathf.Deg2Rad * rotateSpeed;

    }

    private void ImmediateMove()
    {
        // position
        _body.velocity = Vector3.zero;
        transform.position = _followTarget.position;
        
        //rotation
        _body.angularVelocity = Vector3.zero;
        transform.rotation = _followTarget.rotation;
    }
}
