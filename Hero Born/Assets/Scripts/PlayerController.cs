using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    public float groundDrag;

    public float jumpForce;
    public float jumpCooldown;
    public float airMultiplier;
    bool jumpReady;
    bool pressingJump;
    //keybinds
    public KeyCode jumpKey = KeyCode.Space; 



    //ground check
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;
    bool groundedtf;
    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        jumpReady = true;
    }
    private void Update()
    {
        //ground check 2
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);

        //jumpcheck
        if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("jump is being pressed");
            pressingJump = true;
        }
        else
        {
            pressingJump = false;
        }
        MyInput();
        SpeedControl();
        //drag to not move like a penguin
        if (grounded)
        {
            rb.drag = groundDrag;
        }

        else
        {
            rb.drag = 0f;
        }
            
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //when to jump
        if (pressingJump == true && jumpReady == true && groundedtf == true)
        {
            jumpReady = false;
            //Debug.Log("we are trying to jump");
            Jump();

            Invoke(nameof(ResetJump), jumpCooldown);
        }
    
    }
    private void MovePlayer()
    {
        //movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;


        //on ground
        if (grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
            //Debug.Log("grounded");
            groundedtf = true;
        }
            

        //in air
        else if (!grounded)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
            groundedtf = false;
        }

    }        
    
    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //limit velocity so we dont go lightspeed
        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);


        }
    }

    private void Jump()
    {
        //Debug.Log("jumping?");
        //fix y vel
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    private void ResetJump()
    {
        jumpReady = true;
    }
}
