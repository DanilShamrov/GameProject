using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    public Color green = new Color(0.1254902f, 0.8196079f, 0.2901961f);
    public Color red = new Color(0.8f, 0, 0);

    public Button upgradeHealth2;
    public Button upgradeHealth3;

    public Button upgradeBoost2;
    public Button upgradeBoost3;

    public Button upgradeDamage2;
    public Button upgradeDamage3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.upgradeBoost2Unlocked)
        {
            upgradeBoost2.image.color = green;
        }
        else
        {
            upgradeBoost2.image.color = red;
        }
        if (GameManager.Instance.upgradeBoost3Unlocked)
        {
            upgradeBoost3.image.color = green;
        }
        else
        {
            upgradeBoost3.image.color = red;
        }
        if (GameManager.Instance.upgradeHealth2Unlocked)
        {
            upgradeHealth2.image.color = green;
        }
        else
        {
            upgradeHealth2.image.color = red;
        }
        if (GameManager.Instance.upgradeHealth3Unlocked)
        {
            upgradeHealth3.image.color = green;
        }
        else
        {
            upgradeHealth3.image.color = red;
        }
        if (GameManager.Instance.upgradeDamage2Unlocked)
        {
            upgradeDamage2.image.color = green;
        }
        else
        {
            upgradeDamage2.image.color = red;
        }
        if (GameManager.Instance.upgradeDamage3Unlocked)
        {
            upgradeDamage3.image.color = green;
        }
        else
        {
            upgradeDamage3.image.color = red;
        }
    }
}
