using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{

    public GameObject ballPrefab;
    public float ballSpeed = 2.0f;
    public float incrementSpeed = 0.0f;
    // bool isHeld = true; 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject instance = Instantiate(ballPrefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            Camera camera = GetComponentInChildren<Camera>();
            rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
            Destroy(instance, 6); 
        }

    }

    /*
    //isHeld = true; 
    while (Input.GetMouseButton(0))
    {
        ballSpeed += incrementSpeed; 
        if (!Input.GetMouseButton(0) || ballSpeed > 20)
        {
            GameObject instance = Instantiate(ballPrefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            Camera camera = GetComponentInChildren<Camera>();
            rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
        }
        ballSpeed = 2.0f; 

    }
    */

}
 
    
