using UnityEngine;

public class CollectableAnim : MonoBehaviour
{
    public Vector3 position;

    // setting up for the sine wave based bob animation
    private float time = 0.0F;
    public float timeMult;
    public float sineMult;
    public int rotateSpeed;

    //testing
    public UI_ScoreUpdater scoreUpdater;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);
        scoreUpdater.ScoreUI_TestText(Mathf.Sin(time*timeMult).ToString()); // testing sine functions for animation
        transform.position += new Vector3(0, (Mathf.Sin(time*timeMult) * sineMult), 0);

        time += Time.deltaTime; // not great practice because of float imprecision but its just for anim so should be fine
    }
}
