using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    private Rigidbody rb;
    
    public float birdHopHeight = 0;

    public float jumpForce = 0;
    public float gravityMod = 0;
    public bool onPlatform = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMod; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onPlatform)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onPlatform = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        onPlatform = true;
    }
}
