using UnityEngine;

public class WoodenLogSpawn : MonoBehaviour
{
    public GameObject woodenlog;
    public float spawnRate = 2f;
    private float timer = 0f;
    public float heightOffset = 10f;

    void Start()
    {
        spawnWoodenLog();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            spawnWoodenLog();
            timer = 0f;
            Debug.Log("Rura!");
        }
    }
    void spawnWoodenLog()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(woodenlog, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
