using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnInterval = 2f;
    public float spawnRadius = 5f;
    public int maxSpawnCount = 10;

    public int spawnedCount = 0;
    protected float timer = 0f;

    public static Spawner instance;

    public bool enable = true;

    public bool victory = false;
    public int pointsOnVictory;
    public List<GameObject> spawnedObj;
    public Dictionary<GameObject, GameObject> targetValues;
    public void Awake()
    {
        instance = this;
        spawnedCount = 0;
    }
    protected void Start()
    {
        spawnedObj= new List<GameObject>();
        targetValues = new Dictionary<GameObject, GameObject>();
        maxSpawnCount *= (int)Difficulty.currentDifficulty;
        if (prefabToSpawn != null && CanSpawn())
        {
            SpawnObject();
        }
    }

    protected void Update()
    {
        if (spawnedCount <= 0 && !victory)
        {
            GameManager.Instance.points += pointsOnVictory;
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
        
        spawnedCount++;
        var obj = Instantiate(prefabToSpawn, spawnPosition, transform.rotation);
        var arrow = Instantiate(Tracker.instance.arrow, Tracker.instance.transform);
        spawnedObj.Add(obj);
        Tracker.instance.targets.Add(arrow);
        targetValues.Add(arrow, obj);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("UI");
    }
}