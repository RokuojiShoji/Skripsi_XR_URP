using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Transform rightDoor;
    public Transform leftDoor;
    private Quaternion rightTargetRotation;
    private Quaternion leftTargetRotation;
    
    public float smooth = 1f;
    private bool doorOpened;

    void Start()
    {
        rightTargetRotation = rightDoor.rotation;
        leftTargetRotation = leftDoor.rotation;
    }

    public void OpenDoor()
    {
        if (doorOpened == false)
        {
            rightTargetRotation *= Quaternion.AngleAxis(90, Vector3.up);
            leftTargetRotation *= Quaternion.AngleAxis(-90, Vector3.up);
            doorOpened = true;
        } else {
            rightTargetRotation *= Quaternion.AngleAxis(-90, Vector3.up);
            leftTargetRotation *= Quaternion.AngleAxis(90, Vector3.up);
            doorOpened = false;
        }
        
    }

    void Update() 
    {
        leftDoor.rotation = Quaternion.Lerp(leftDoor.rotation, leftTargetRotation, smooth * Time.deltaTime);  
        rightDoor.rotation = Quaternion.Lerp(rightDoor.rotation, rightTargetRotation, smooth * Time.deltaTime);
    }
}
