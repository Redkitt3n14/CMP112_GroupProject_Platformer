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

       


        
        float angle = Mathf.Atan2(moveVertical, moveHorizontal) * Mathf.Rad2Deg;
        


            // ensure the direction the mesh is facing is the direction the player is going  

        Vector3 rotation = new Vector3(0, (90-angle), 0); // Direction solution fixed by Ashleigh
        transform.eulerAngles = rotation;
        
        

        
    } 




    private void OnCollisionEnter(Collision collision)
    {
        touchingPlatform = true;
    }
     
       
       // rb.linearVelocity = (moveVector * speed);

}
