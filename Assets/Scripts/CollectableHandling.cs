using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollectableHandling : MonoBehaviour
{
    // set up for scoring system
    public int playerScore = 0; // 0 initial score
    public UI_ScoreUpdater scoreUpdater; // gives the player access to the script 
    public int collectCount = 0; // sets up the collectCount before unity can read the true count in start()


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collectCount = GameObject.FindGameObjectsWithTag("PickUp").Length;
        scoreUpdater.ScoreUI_Update(playerScore, collectCount); // calls the UI_ScoreText to give initial 0 score
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
            scoreUpdater.ScoreUI_Update(playerScore, collectCount); // calls the UI_ScoreText to update the score
        }
    }
}
