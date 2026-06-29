using UnityEngine;

public class UpgradesButton : MonoBehaviour
{
    public Animator animator;

    public void ShowSettingsMenu()
    {
        animator.SetTrigger("UIMenu2Upgrades");
        animator.ResetTrigger("Upgrades2UIMenu");
    }
    public void ReturnFromSettingsMenu()
    {
        animator.SetTrigger("Upgrades2UIMenu");
        animator.ResetTrigger("UIMenu2Upgrades");
    }
}
