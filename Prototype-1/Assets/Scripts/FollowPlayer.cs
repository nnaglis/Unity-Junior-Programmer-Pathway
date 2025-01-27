using UnityEngine;
using UnityEngine.PlayerLoop;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector3 initialCameraPosition;
    void Start()
    {
        initialCameraPosition = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // we'll move the camera to follow the player
        // with an offset of initial camera position
        transform.position = player.transform.position + initialCameraPosition;
    }
}
