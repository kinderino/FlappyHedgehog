using UnityEngine;

public class WoodenLogSpawnScript : MonoBehaviour
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
        }
    }
    void spawnWoodenLog()
    {
        float lowestPoint = transform.position.y - heightOffset;
        Instantiate(woodenlog, transform.position, Quaternion.identity);
    }
}
