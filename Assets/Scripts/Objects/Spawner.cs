using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    [Header("Префаб для спавна")]
    public GameObject prefabToSpawn;

    [Header("Параметры спавна")]
    public float spawnInterval = 2f;

    [Header("Радиус области спавна")]
    [Tooltip("Максимальное расстояние от центра спавнера")]
    public float spawnRadius = 5f;

    [Header("Ограничение количества")]
    [Tooltip("Сколько всего объектов создать (0 — без ограничений)")]
    public int maxSpawnCount = 10;

    public int spawnedCount = 0;
    protected float timer = 0f;

    public static Spawner instance;

    public bool enable = true;

    public bool victory = false;

    public void Awake()
    {
        instance = this;
        spawnedCount = 0;
    }
    protected void Start()
    {
        if (prefabToSpawn != null && CanSpawn())
        {
            SpawnObject();
        }
    }

    protected void Update()
    {
        if (spawnedCount <= 0 && !victory)
        {
            GameManager.Instance.points += 1;
            Invoke(nameof(LoadMenu), 4);
            victory=true;
            
            Debug.Log("Victory");
        }
        if (prefabToSpawn == null || !CanSpawn())
        {
            enable = false;
            return;
        }

        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }

        
    }

    protected bool CanSpawn()
    {
        return enable&&(maxSpawnCount == 0 || spawnedCount < maxSpawnCount);
    }


    protected void SpawnObject()
    {
        Vector3 randomOffset = Random.insideUnitSphere * spawnRadius;
        Vector3 spawnPosition = new Vector3(
            transform.position.x + randomOffset.x,
            transform.position.y + randomOffset.y,
            transform.position.z + randomOffset.z
        );

        Instantiate(prefabToSpawn, spawnPosition, transform.rotation);
        
        spawnedCount++;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("UI");
    }
}