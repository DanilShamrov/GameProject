using TMPro;
using UnityEngine;

public class VictoryText : MonoBehaviour
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
        if (Spawner.instance != null && Spawner.instance.victory)
        {
            text.enabled = true;
        }
        else
        {
            text.enabled = false;
        }
    }
}
