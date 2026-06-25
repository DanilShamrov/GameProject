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
        else
        {
            Destroy(this);
        }
            points = PlayerPrefs.GetInt("Points");
        upgradeBoost2Unlocked = PlayerPrefs.GetInt("Boost2")==1;
        upgradeBoost3Unlocked = PlayerPrefs.GetInt("Boost3") == 1;

        upgradeDamage2Unlocked = PlayerPrefs.GetInt("Damage2") == 1;
        upgradeDamage3Unlocked = PlayerPrefs.GetInt("Damage3") == 1;

        upgradeHealth2Unlocked = PlayerPrefs.GetInt("Health2") == 1;
        upgradeHealth3Unlocked = PlayerPrefs.GetInt("Health3") == 1;

        Upgrades.currentBoostLevel = (Upgrades.Boost)PlayerPrefs.GetInt("CurrentBoost");
        Upgrades.currentHealthLevel = (Upgrades.Health)PlayerPrefs.GetInt("CurrentHealth");
        Upgrades.currentDamageLevel = (Upgrades.Damage)PlayerPrefs.GetInt("CurrentDamage");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        PlayerPrefs.SetInt("Points", points);

        PlayerPrefs.SetInt("Boost2", upgradeBoost2Unlocked ? 1 : 0);
        PlayerPrefs.SetInt("Boost3", upgradeBoost3Unlocked ? 1 : 0);

        PlayerPrefs.SetInt("Damage2", upgradeDamage2Unlocked ? 1 : 0);
        PlayerPrefs.SetInt("Damage3", upgradeDamage3Unlocked ? 1 : 0);

        PlayerPrefs.SetInt("Health2", upgradeHealth2Unlocked ? 1 : 0);
        PlayerPrefs.SetInt("Health3", upgradeHealth3Unlocked ? 1 : 0);

        PlayerPrefs.SetInt("CurrentDamage", (int)Upgrades.currentDamageLevel);
        PlayerPrefs.SetInt("CurrentBoost", (int)Upgrades.currentBoostLevel);
        PlayerPrefs.SetInt("CurrentHealth", (int)Upgrades.currentHealthLevel);

        PlayerPrefs.Save();
    }
    public void ResetProgress()
    {
        PlayerPrefs.DeleteAll();
        upgradeHealth2Unlocked = false;
        upgradeHealth3Unlocked = false;
        upgradeDamage2Unlocked = false;
        upgradeDamage3Unlocked = false;
        upgradeBoost2Unlocked = false;
        upgradeBoost3Unlocked = false;

        Upgrades.currentBoostLevel = Upgrades.Boost.Level1;
        Upgrades.currentDamageLevel = Upgrades.Damage.Level1;
        Upgrades.currentHealthLevel = Upgrades.Health.Level1;

        points = 0;
}
}
