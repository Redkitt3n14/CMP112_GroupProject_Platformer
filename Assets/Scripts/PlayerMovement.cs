using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 0;
    public bool touchingPlatform = true;
    public float birdHopHeight = 0;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    
   

    // Update is called on once per fixed frame-rate frame
    void FixedUpdate()
    {
        
        // get the player input for movement
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");


        Vector3 moveVector = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        rb.AddForce(moveVector * speed);


        // ensure direction only changes while moving
        if (moveVector != Vector3.zero)
        {
            // get direction facing from the player input
            float angle = Mathf.Atan2(moveVertical, moveHorizontal) * Mathf.Rad2Deg;



            // ensure the direction the mesh is facing is the direction the player is going  
            Vector3 rotation = new Vector3(0, (90 - angle), 0); // Direction solution fixed by Ashleigh
            transform.eulerAngles = rotation;
        }



        // when moving and touching the ground do a bird hop
        if ((touchingPlatform == true) && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
        {
            rb.AddForce(Vector3.up * birdHopHeight, ForceMode.Impulse);

            touchingPlatform = false;
        }
    }

   


// set touchingPlatform to true after hitting the ground to reset bird hop
    private void OnCollisionEnter(Collision collision)
    {
        touchingPlatform = true;
    }
     
       
      

}
