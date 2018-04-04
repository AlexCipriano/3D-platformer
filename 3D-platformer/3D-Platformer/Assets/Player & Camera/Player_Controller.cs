using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public float moveSpeed;

    public float jumpForce;
    public float maxTurnSpeed = 100.0f;
    public CharacterController controller;

    private Vector3 moveDirection;
    public float gravityScale;

    // Use this for initialization
    void Start()
    {

        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        // Animation anim = GetComponent<Animation>();

        // moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);

        float yStore = moveDirection.y;

        moveDirection = (transform.forward * Input.GetAxis("Vertical") * moveSpeed) + (transform.right * Input.GetAxis("Horizontal") * moveSpeed) ;
        moveDirection = moveDirection.normalized * moveSpeed;
        moveDirection.y = yStore;
        if (controller.isGrounded)
        {

            if (Input.GetButtonDown("Jump"))
            {
                moveDirection.y = 0f;
                moveDirection.y = jumpForce;
                // anim.Play("jump");
            }

        }
        //  float turnSpeed = Input.GetAxis("Horizontal") * maxTurnSpeed;
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        //  transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        //  transform.Rotate(0, turnSpeed * Time.deltaTime, 0);
        controller.Move(moveDirection * Time.deltaTime);

        /*   if (moveSpeed > 5)
           {
               anim.Play("Walk");



           }
           else
           {
               anim.Play("dle");
           }
         */

    }
}
