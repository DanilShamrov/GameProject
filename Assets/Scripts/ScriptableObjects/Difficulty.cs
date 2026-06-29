using UnityEngine;

[CreateAssetMenu(fileName = "Difficulty", menuName = "Scriptable Objects/Difficulty")]
public class Difficulty : ScriptableObject
{
    public static DifficultyMode currentDifficulty=DifficultyMode.Low;
    public enum DifficultyMode
    {
        Low=1, Medium, Hard
    }

    public void SetLowDifficulty() { currentDifficulty = DifficultyMode.Low; }
    public void SetMediumDifficulty() {currentDifficulty = DifficultyMode.Medium; }
    public void SetHardDifficulty() {currentDifficulty = DifficultyMode.Hard; }
}
