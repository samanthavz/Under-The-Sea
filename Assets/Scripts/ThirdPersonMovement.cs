using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 10f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    Vector3 moveDir; 
    bool check = false;

    //isgrounded
    float distToGround;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        // get the distance to ground
        distToGround = gameObject.GetComponent<Collider>().bounds.extents.y;
    }

    public bool IsGrounded() 
    {
        return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.2f);
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        // float fly = Input.GetAxisRaw("Fly");

        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        if (direction.magnitude >= 0.1f || check)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            if(Input.GetKey("space"))
                moveDir.y+=1;    
            if(Input.GetKey("left shift"))
                moveDir.y-=1;

            moveDir.y -= 0.01f;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            // controller.Move(transform.TransformDirection(direction.normalized * speed * Time.deltaTime));
        }

        if(Input.GetKey("space") || Input.GetKey("left shift")) {
            check = true;
        }
                
        if(Input.GetKeyUp("space") || Input.GetKeyUp("left shift")){
            check = false; 
        }

                   
        if (IsGrounded() == false)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 0.5f, Space.World);

        }

            // moveDir.y -= 0.01f;
        
        // controller.Move(moveDir.normalized * speed * Time.deltaTime);
    }
}
