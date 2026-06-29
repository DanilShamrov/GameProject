using UnityEngine;

public class EnableWithDifficulty : MonoBehaviour
{
    public bool enableOnMedium;
    public bool enableOnHard;
    void Start()
    {
        if (enableOnMedium)
            if (Difficulty.currentDifficulty == Difficulty.DifficultyMode.Medium)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        if (enableOnHard)
            if(Difficulty.currentDifficulty == Difficulty.DifficultyMode.Hard)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
