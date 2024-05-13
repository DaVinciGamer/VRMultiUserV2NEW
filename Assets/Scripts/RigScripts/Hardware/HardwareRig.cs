using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardwareRig : MonoBehaviour
{
    public HardwareHand leftHand;
    public HardwareHand rightHand;
    public HardwareHead headSet;


    public Vector3 playerPosition;
    public Quaternion playerRotation;

    public Vector3 leftHandPosition;
    public Quaternion leftHandRotation;

    public Vector3 rightHandPosition;
    public Quaternion rightHandRotation;

    public Vector3 headSetPosition;
    public Quaternion headSetRotation;


    void Start() {
        Debug.Log("HEADSET " + headSet); 
        Debug.Log("LEFT HAND" + leftHand); 
        Debug.Log("RIGHT HAND" + rightHand); 
    }

    private void LateUpdate()
    {

        
        playerPosition = transform.position;
        playerRotation = transform.rotation;
        leftHandPosition = leftHand.transform.position;
        leftHandRotation = leftHand.transform.rotation;
        rightHandPosition = rightHand.transform.position;
        rightHandRotation = rightHand.transform.rotation;
        headSetPosition = headSet.transform.position;
        headSetRotation = headSet.transform.rotation;

       /*  Debug.Log("Headset Position: "+headSetPosition); 
        Debug.Log("Linke Hand Position: "+leftHandPosition); 
        Debug.Log("Rechte Hand Position: "+rightHandPosition);  */
    }
}
