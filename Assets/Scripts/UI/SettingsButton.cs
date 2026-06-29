using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public Animator animator;

    public void ShowSettingsMenu()
    {
        animator.SetTrigger("Menu2Settings");
        animator.ResetTrigger("Settings2Menu");
    }
    public void ReturnFromSettingsMenu()
    {
        animator.SetTrigger("Settings2Menu");
        animator.ResetTrigger("Menu2Settings");
    }
}
