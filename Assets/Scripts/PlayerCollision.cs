using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    [SerializeField] AudioClip hitSound = null;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position);
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
