using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;
    private float xPosition;
    private float yPosition;
    private float zPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // disables the rigidbody physics
        rb.isKinematic = true;

        // gets the initial position of the falling platform
        xPosition = transform.position.x;
        yPosition = transform.position.y;
        zPosition = transform.position.z;
        
    }

   

    
    void OnCollisionEnter(Collision collision)
    {
        
        
        if (collision.gameObject.CompareTag("Player"))

        {
            // delays the function code by 0.3 seconds
            Invoke("drop", 0.7f);

        }

        if (collision.gameObject.CompareTag("TheVoid"))
        {
            //respawns the falling platform after 0.7 seconds
            Invoke("respawn", 1f);
            
        }
    }
    void drop()
    {
        // enables the rigidbody physics
        rb.isKinematic = false;

    }

    void respawn()
    {
        //sets the falling platform back to its initial position
        transform.position = new Vector3(xPosition, yPosition, zPosition);
        // once again disables the rigidbody physics
        rb.isKinematic = true;    
    }
}
