using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //this is a reference to the rigidbody component called ""rb

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked this as "Fixed"Update because we
    //are using it to mess with physics
    void FixedUpdate()
    {
        // Add a Forward Force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("e")) // If the player is pressing  the "e" key
        {
            // Add a force to the right
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("i")) // If the player is pressing the "r" key
        {
            // Add a force to the left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
