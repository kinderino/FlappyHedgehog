using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D RigidbodyPlayer;
    public float flapStrength;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            RigidbodyPlayer.linearVelocity = Vector2.up * flapStrength;
        }
    }
}
