using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Transform trans;
    public Rigidbody rb;
    Vector3 movementDirection;

    private Transform cameraOffset;

    // Use this for initialization
  
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        movementDirection = (horizontalMovement * trans.right + verticalMovement * trans.forward).normalized;

    }

    private void FixedUpdate()
    {
        
        Move();

    }

    void Move() {
        Vector3 yFix = new Vector3(0, rb.velocity.y, 0);
        rb.velocity = movementDirection * speed * Time.deltaTime;
        rb.velocity += yFix;
    }
}
