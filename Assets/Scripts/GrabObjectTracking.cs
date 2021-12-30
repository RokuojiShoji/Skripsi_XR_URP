using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class GrabObjectTracking : MonoBehaviour
{
    [SerializeField] private float range = 0.1f;
    //[SerializeField] private SphereCollider collider = null;
    [SerializeField] private LayerMask physicMask = 0;

    private XRGrabInteractable grabInteractable = null;

    
    // Start is called before the first frame update
    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        //collider = collider.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!ObjInRange()) 
        {
            //Debug.Log("Instantaneous");
            InstantaneousMove();
        }
        else 
        {
            //Debug.Log("physic");
            PhysicMove();
        }
    }

    
    private void InstantaneousMove()
    {
        grabInteractable.movementType = XRBaseInteractable.MovementType.Instantaneous;
    }

    private void PhysicMove()
    {
        grabInteractable.movementType = XRBaseInteractable.MovementType.VelocityTracking;
    }

    private bool ObjInRange()
    {
        return Physics.CheckSphere(transform.position, range, physicMask, QueryTriggerInteraction.Ignore);
    }
}
