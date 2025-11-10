using UnityEngine;
using UnityEngine.SceneManagement;

public class voidScript : MonoBehaviour
{
   
    // reset the level if the player falls into the void
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
        
}
