using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController characterController;
    public FloatVariable speed;
    public PlayerPosition playerPosition;
    Vector3 velocity;
    float gravity = -9.8f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    float groundDistance = 0.4f;
    bool isGrounded;
    public FloatVariable jumpHeight;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        else
        {
            Gravity();
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        characterController.Move(move * speed.Value * Time.deltaTime);
        playerPosition.position = transform.position;


        if(isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }

    }

    void Gravity()
    {
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }

    void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight.Value * -2f * gravity);
    }
}
