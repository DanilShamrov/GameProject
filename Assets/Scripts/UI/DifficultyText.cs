using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyText : MonoBehaviour
{
    TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = Difficulty.currentDifficulty.ToString();
    }
}
