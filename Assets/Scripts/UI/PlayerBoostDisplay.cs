using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBoostDisplay : MonoBehaviour
{
    [SerializeField]GameObject player;
    TextMeshProUGUI text;
    MainShip playerComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerComponent = player.GetComponent<MainShip>();
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int a = playerComponent.GetBoostCharge();
        text.text = a > 0 ? a.ToString() : "0";
    }
}
