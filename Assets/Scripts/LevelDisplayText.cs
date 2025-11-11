using TMPro; // for the text mesh
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;
using UnityEngine.Windows;

public class LevelDisplayText : MonoBehaviour
{

    public TMP_Text display;
    public string displayText;
    public float displayTime = 2.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
        display.SetText(displayText);

        Invoke("ClearDisplayText", displayTime);
    }

    void ClearDisplayText()
    {

        display.SetText("");

    }
}

/*
{
    // set up the text accessing
    


    // ScoreUI_Update is called when player gets a collectable
    public void ScoreUI_Update(int playerScore, int requiredScore)
    {
        score.SetText(playerScore + " / " + requiredScore);


        // calls for the level's endgoal to activate when all collectables gathered
        if (playerScore == requiredScore)
        {
            EndGoalActivation[] goals = FindObjectsByType<EndGoalActivation>(FindObjectsSortMode.None); // gets all objects in scene with an endgoalactivation script

            ScoreUI_TestText(playerScore + " / " + requiredScore + " - Objective Complete");

            foreach (EndGoalActivation goal in goals) // calls active goal for every goal in level
            {
                goal.ActivateGoal();
            }
        }
    }


    // this is a debug script just for quickly displaying text onscreen in GUI
    

} */
