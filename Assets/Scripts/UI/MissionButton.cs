using UnityEngine;

public class MissionButton : MonoBehaviour
{
    public Animator animator;

    public void ShowSettingsMenu()
    {
        animator.SetTrigger("UIMenu2Missions");
        animator.ResetTrigger("Missions2UIMenu");
    }
    public void ReturnFromSettingsMenu()
    {
        animator.SetTrigger("Missions2UIMenu");
        animator.ResetTrigger("UIMenu2Missions");
    }
}
