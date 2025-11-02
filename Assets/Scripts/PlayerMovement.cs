using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 0;
  

  
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // does not work properly must fix
   

    // Update is called on once per fixed frame-rate frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");


        Vector3 moveVector = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        rb.AddForce(moveVector * speed);
        
       // rb.linearVelocity = (moveVector * speed);


        
        float angle = Mathf.Atan2(moveVertical, moveHorizontal) * Mathf.Rad2Deg;
        


            // ensure the direction the mesh is facing is the direction the player is going  

        Vector3 rotation = new Vector3(0, angle, 0);
        //transform.eulerAngles = rotation;
        
        

        
    } 

   

    /*
    void OnMove(InputValue movementValue, Collision collision)
    {
        // check the player is on the ground
       if (onPlatform == true)
       {
            // when moving and on the ground get player to bird hop(currently doesn't work)
            Vector3 birdHop = new Vector3(0.0f, birdHopHeight, 0.0f);

            rb.AddForce(birdHop * birdHopHeight, ForceMode.Impulse);
            onPlatform = false;
        
       }
       

    }
    */

}
