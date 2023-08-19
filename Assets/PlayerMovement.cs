using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 300f;
    public float sideForce = 200f;

    // Update is called once per frame
    // FixedUpdate is used for physics
    void FixedUpdate()
    {
        // Object moves forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            // Object moves sideways
            rb.AddForce(sideForce * Time.deltaTime, 0, 0,
                ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            // Object moves sideways
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0,
                ForceMode.VelocityChange);
        }
    }
}
