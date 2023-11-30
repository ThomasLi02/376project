using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // The player's transform
    public Vector3 offset; // Offset of the camera from the player

    void LateUpdate() // Using LateUpdate because it runs after all Update functions
    {
        // Set the position of the camera's transform to be the same as the player's,
        // but offset by the calculated offset distance.
        transform.position = player.position + offset;

        // Optional: If you want the camera to always look at the player
        transform.LookAt(player);
    }
}
