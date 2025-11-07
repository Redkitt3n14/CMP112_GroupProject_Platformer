using TMPro; // for the text mesh
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;
using UnityEngine.Windows;

public class UI_ScoreUpdater : MonoBehaviour
{
    // set up the text accessing
    public TMP_Text score;


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
    public void ScoreUI_TestText(string input)
    {
        score.SetText(input);
    }

}
