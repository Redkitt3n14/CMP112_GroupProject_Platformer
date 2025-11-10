using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // calculate how much the camera is offset from the player initially
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // use the initial offset to keep the same distance between the camera and the player for the entire game
        transform.position = player.transform.position + offset;
    }


}
