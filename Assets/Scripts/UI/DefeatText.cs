using TMPro;
using UnityEngine;

public class DefeatText : MonoBehaviour
{
    TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

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
