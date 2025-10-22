using UnityEngine;

all cluusing UnityEngine;

public class CollectableHandling : MonoBehaviour
{
    // set up for scoring system
    int playerScore = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // function is currently being used to detect collisions with coins, likely will not be used for end goal but subject to change.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            playerScore++;
        }
        
    }
}
