using UnityEngine;

public class WoodenLogMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
