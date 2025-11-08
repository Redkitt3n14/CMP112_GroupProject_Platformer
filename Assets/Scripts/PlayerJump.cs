using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    private Rigidbody rb;
    
    public float birdHopHeight = 0;

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
        

        if (onPlatform == true) 
        {
            // reset timer when on the ground
            coyoteTimer = coyoteTime;

        }
        else if(onPlatform == false)
        {
            coyoteTimer -= Time.deltaTime;

        }

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
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            coyoteTimer = 0;
            onPlatform = false;
        }

    }


    


    private void OnCollisionEnter(Collision collision)
    {
        onPlatform = true;
    }
}

