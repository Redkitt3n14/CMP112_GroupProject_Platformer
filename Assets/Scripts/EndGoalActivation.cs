using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoalActivation : MonoBehaviour
{
    // set up the hook to put next level into
    public Material materialInactive;
    public Material materialActive;

    public string nextScene;
    public bool goalActive = false;

    public void ActivateGoal()
    {
        //Destroy(gameObject); // testing effect
        goalActive = true; // allows the collision to take place
        GetComponent<MeshRenderer>().material = materialActive;

    }
    void OnCollisionEnter(Collision other) // borrowed this line of code from imogen's falling platform code
    {
        if (goalActive == true && other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextScene);
                    
        }
    }
}
