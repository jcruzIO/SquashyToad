using UnityEngine;
using System.Collections;

public class FrogMovement : MonoBehaviour {

    //public float thrust;
    //public Rigidbody rb;

    public float jumpElevationInDegrees = 45;
    public float jumpSpeedInMPS = 5;
    public float jumpGroundClearance = 2;
    public float jumpSpeedTolerance = 5; 

	// Use this for initialization
	void Start () {
        //rb = GetComponent<Rigidbody>(); 
	}
	
	// Update is called once per frame
	void Update () {
        bool isOnGround = Physics.Raycast(transform.position, -transform.up, jumpGroundClearance);
        Debug.DrawRay(transform.position, -transform.up * jumpGroundClearance);
        var speed = GetComponent<Rigidbody>().velocity.magnitude;
        bool isNearStationery = speed < jumpSpeedTolerance; 
        if (GvrViewer.Instance.Triggered && isOnGround && isNearStationery)
        {
            //rb.AddForce(0, 1, 2, ForceMode.VelocityChange);
            var camera = GetComponentInChildren<Camera>();
            var projectedLookDirection = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
            var radiansToRotate = Mathf.Deg2Rad * jumpElevationInDegrees;
            var unnormalizedJumpDirection = Vector3.RotateTowards(projectedLookDirection, Vector3.up, radiansToRotate, 0);
            var jumpVector = unnormalizedJumpDirection.normalized * jumpSpeedInMPS;
            GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange); 
        }
	}
}
