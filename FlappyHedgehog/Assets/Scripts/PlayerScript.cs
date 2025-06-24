using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D RigidbodyPlayer;
    public float flapStrength;
    public Logic logic;
    public bool animalIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && animalIsAlive == true)
        {
            RigidbodyPlayer.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        animalIsAlive = false;
    }
}
