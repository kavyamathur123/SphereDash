using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSphere : MonoBehaviour
{
    public float jumpForce = 10f; // Adjust this value to control the jump height
    private Rigidbody rb;
    public bool isGrounded = true;

    void Start()
    {
        // Ensure there is a Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody component not found on " + gameObject.name);
        }
    }

    void Update()
    {
        // Check for a jump input, for example, when the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        // Check if the Rigidbody component is present
        if (rb != null)
        {
            // Apply a vertical force to make the object jump
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            isGrounded = false;

    
        }
    }

    void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.CompareTag("ground")) {
            isGrounded = true;
        }
    }
}