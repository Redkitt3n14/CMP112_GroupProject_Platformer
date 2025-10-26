using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 0;
    public float birdHopHeight = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    // Update is called on once per fixed frame-rate frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        Vector3 moveVector = new Vector3(moveHorizontal, jump, moveVertical);
        rb.AddForce(moveVector * speed);
        float angle = Mathf.Atan2(moveVertical, moveHorizontal) * Mathf.Rad2Deg;
        Vector3 rotation = new Vector3(0, angle, 0);
        transform.eulerAngles = rotation;

        
    }

    void OnMove(InputValue movementValue, Collision collision)
    {
        // check the player is on the ground
       if (collision.gameObject.CompareTag("ground"))
       {
            // when moving and on the ground get player to bird hop(currently doesn't work)
            Vector2 movementVector = movementValue.Get<Vector2>();
            movementVector.y = birdHopHeight;
        
       }
       

    }

}
