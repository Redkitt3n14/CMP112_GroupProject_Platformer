using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    private Rigidbody rb;
    
    public float jumpForce = 0;
  
    public bool onPlatform = true;
    public float coyoteTime = 0.2f;
    private float coyoteTimer;

    public float inputBuffer = 0.2f;
    private float inputTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
         
    }

    // Update is called once per frame
    void Update()
    {
        
        // coyote time to allow player to jump up to 0.2 seconds after they leave the ground
        
        // reset timer when on the ground

        if (onPlatform == true) 
        {
            
            coyoteTimer = coyoteTime;

        }
        else if(onPlatform == false)
        {
            coyoteTimer -= Time.deltaTime;

        }


        // input buffering to allow the player to jump again immediately after touching the ground
        if(Input.GetKeyDown(KeyCode.Space))
        {
            inputTimer = inputBuffer;

        } 
        else
        {
            inputTimer -= Time.deltaTime;
        }



        
        if (inputTimer > 0 && coyoteTimer > 0)
        {
            // jump
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            coyoteTimer = 0;
            onPlatform = false;
        }

    }



    // set touchingPlatform to true after hitting the ground to reset jump
    private void OnCollisionEnter(Collision collision)
    {
        onPlatform = true;
    }
}

