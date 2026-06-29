using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDisplay : MonoBehaviour
{
    TextMeshProUGUI text;

    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        float a = MainShip.instance.speed/MainShip.MaxSpeed;
        text.text = $"{(MainShip.instance.BoostPressed?MainShip.boostEffect*a:a):F2}";
    }
}
