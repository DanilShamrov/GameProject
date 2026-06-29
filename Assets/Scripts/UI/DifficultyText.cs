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
        if (Difficulty.currentDifficulty == Difficulty.DifficultyMode.Low)
            text.text = "Легко";
        if (Difficulty.currentDifficulty == Difficulty.DifficultyMode.Medium)
            text.text = "Средне";
        if (Difficulty.currentDifficulty == Difficulty.DifficultyMode.Hard)
            text.text = "Сложно";
    }
}
