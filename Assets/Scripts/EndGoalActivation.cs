using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoalActivation : MonoBehaviour
{
    // set up the hook to put next level into
    //public UI_ScoreUpdater scoreUpdater;

    public bool goalActive = false;

    public void ActivateGoal()
    {
        Destroy(gameObject);
        // set self to be a trigger
        // change material to the opaque version
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene("LevelScene_2");
    }
}
