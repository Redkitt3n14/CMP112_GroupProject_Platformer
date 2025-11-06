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

    // does not work properly must fix
   

    // Update is called on once per fixed frame-rate frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");


        Vector3 moveVector = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        rb.AddForce(moveVector * speed);

        // currently hops even when the player stops inputting things - fix this
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)) && touchingPlatform)
       {
            // when moving and on the ground get player to bird hop(currently doesn't work)
           
            rb.AddForce(Vector3.up * birdHopHeight, ForceMode.Impulse);
            
            touchingPlatform = false;
            
        
        }
       
       // rb.linearVelocity = (moveVector * speed);


        
        float angle = Mathf.Atan2(moveVertical, moveHorizontal) * Mathf.Rad2Deg;
        


            // ensure the direction the mesh is facing is the direction the player is going  

        Vector3 rotation = new Vector3(0, angle, 0);
        //transform.eulerAngles = rotation;
        
        

        
    } 




    private void OnCollisionEnter(Collision collision)
    {
        touchingPlatform = true;
    }
    

}
