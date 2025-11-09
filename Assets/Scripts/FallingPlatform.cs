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
        //xPosition = position.x;
       // yPosition = position.y;
      //  zPosition = position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //enables the rigidbody physics after the player collides with the platform
    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))

        {
            
            Invoke("drop", 0.3f);

        }

        if (collision.gameObject.CompareTag("TheVoid"))
        {
            //Invoke("respawn", 0.3f);
            Destroy(gameObject);

        }
    }
    void drop()
    {

        rb.isKinematic = false;

    }

    void respawn()
    {

        //transform.position = new Vector3(xPosition, yPosition, zPosition);
        //rb.isKinematic = true;    
    }
}
