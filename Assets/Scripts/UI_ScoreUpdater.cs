using TMPro; // for the text mesh
using UnityEngine;
using UnityEngine.UI;

public class UI_ScoreUpdater : MonoBehaviour
{
    // set up the text accessing
    public TMP_Text score;


    // ScoreUI_Update is called when player gets a collectable
    public void ScoreUI_Update(int playerScore, int requiredScore)
    {
        score.SetText(playerScore + " / " + requiredScore);
    }

}
