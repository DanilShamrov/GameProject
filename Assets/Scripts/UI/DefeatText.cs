using TMPro;
using UnityEngine;

public class DefeatText : MonoBehaviour
{
    TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((CargoShipSpawner.instance!=null && CargoShipSpawner.instance.defeat) ||
            MainShip.instance.GetHealth()<=0)
        {
            text.enabled=true;
        }
        else
        {
            text.enabled = false;
        }
    }
}
