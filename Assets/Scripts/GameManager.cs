using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public int points;

    public bool upgradeHealth2Unlocked=false;
    public bool upgradeHealth3Unlocked=false;

    public bool upgradeDamage2Unlocked = false;
    public bool upgradeDamage3Unlocked = false;

    public bool upgradeBoost2Unlocked = false;
    public bool upgradeBoost3Unlocked = false;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
