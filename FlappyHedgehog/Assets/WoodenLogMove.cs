using System.Threading;
using UnityEngine;

public class WoodenLogMove : MonoBehaviour
{
    public float moveSpeed = 5;
    public float timeTilDeath = 10;
    public float timer = 0;
    public float deadZone = -20f;


    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x <= deadZone) 
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
