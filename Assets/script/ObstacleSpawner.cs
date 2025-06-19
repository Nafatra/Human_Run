using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [Header("Spawner Settings")]
    public GameObject[] obstaclePrefabs;
    public float spawnInterval = 2f;
    public float spawnRangeX = 8f;
    public float spawnY = 0f;

    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float destroyX = -15f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnObstacle();
            timer = 0f;
        }
    }

    void SpawnObstacle()
    {
        if (obstaclePrefabs.Length == 0)
        {
            Debug.LogWarning("Belum ada prefab batu di array!");
            return;
        }

        int index = Random.Range(0, obstaclePrefabs.Length);
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(randomX, spawnY, 0f);

        GameObject obstacle = Instantiate(obstaclePrefabs[index], spawnPos, Quaternion.identity);
        obstacle.AddComponent<MoveLeftTemp>().Initialize(moveSpeed, destroyX);
    }
}

public class MoveLeftTemp : MonoBehaviour
{
    float speed;
    float destroyX;

    public void Initialize(float spd, float destX)
    {
        speed = spd;
        destroyX = destX;
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}

