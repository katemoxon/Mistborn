using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float jumpForce;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        walkSpeed = 5;
        jumpForce = 150;
    }

    void Update()
    {
        Walk();
        //Jump();
    }

    void Walk()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float forwardMovement = Input.GetAxis("Vertical");

        Vector3 moveHorizontal = transform.right * horizontalMovement * walkSpeed;
        Vector3 moveForward = transform.forward * forwardMovement * walkSpeed;

        controller.SimpleMove(moveHorizontal);
        controller.SimpleMove(moveForward);
    }

    //void Jump()
    //{
    //    if (Input.GetKeyDown("space"))
    //        transform.Translate(Vector3.up * jumpForce * Time.deltaTime, Space.World);
    //}
}