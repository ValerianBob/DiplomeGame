using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 50f;
    private float rotationSpeed = 3f;

    public GameObject Gun;
    public GameObject bullet;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       // Open fire by left mouse :
       if (Input.GetMouseButtonDown(0))
       {
            Fire();
       }
    }

    private void FixedUpdate()
    {
        MovementPlayer();
        RotatePlayer();
    }

    // Move player on WASD
    private void MovementPlayer()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        rb.AddForce(Vector3.forward * inputZ * speed);
        rb.AddForce(Vector3.right * inputX * speed);
    }

    // Rotate player on Mouse 
    private void RotatePlayer()
    {
        float mouseX = Input.GetAxis("Mouse X");

        transform.Rotate(Vector3.up, mouseX * rotationSpeed);
    }

    private void Fire()
    {
        Instantiate(bullet, new Vector3(Gun.transform.position.x, Gun.transform.position.y, Gun.transform.position.z), bullet.transform.rotation);
    }
}
