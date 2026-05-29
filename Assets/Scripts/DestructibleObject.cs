using UnityEngine;

public class DestructibleObject : MonoBehaviour, IDamageable, ITracked
{
    [SerializeField] int maxHealth=100;
    public GameObject junk;
    private int currentHealth;
    private bool tracked = false;
    public void TakeHealthDamage(int damage)
    {
        currentHealth -= damage;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            if (tracked) 
            {
                RemoveRef();
            }
            if (junk != null)
            {
                Instantiate(junk).transform.position = transform.position;
            }
            foreach (Transform t in transform) {
                Destroy(t.gameObject);
            }
            Destroy(gameObject);

        }
    }
    public void SetTracked(bool tracked)
    {
        this.tracked = tracked;
    }

    public void RemoveRef()
    {
        Spawner.instance.spawnedCount--;
    }
}
