using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthDisplay : MonoBehaviour
{
    [SerializeField]GameObject player;
    TextMeshProUGUI text;
    DestructibleObject playerComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerComponent = player.GetComponent<DestructibleObject>();
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int a = playerComponent.GetHealth();
        text.text = a > 0 ? a.ToString() : "0";
    }
}
