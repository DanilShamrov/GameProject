using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBoostDisplay : MonoBehaviour
{
    TextMeshProUGUI text;
    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        int a = MainShip.instance.GetBoostCharge();
        text.text = a > 0 ? a.ToString() : "0";
    }
}
