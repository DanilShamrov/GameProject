using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void LoadSceneDefaultFight() {
        SceneManager.LoadScene("DefaultFight");
    }
    public void LoadSceneJunkCleaning()
    {
        SceneManager.LoadScene("JunkCleaning");
    }
    public void LoadSceneMinefield()
    {
        SceneManager.LoadScene("Minefield");
    }
    public void LoadSceneCargoShipFight()
    {
        SceneManager.LoadScene("CargoShipFight");
    }
    public void LoadSceneMainScene()
    {
        SceneManager.LoadScene("UI");
    }
    public void LoadSceneMainMenu() { 
        SceneManager.LoadScene("MainMenu");
    }
    public void StartNewGame()
    {
        GameManager.Instance.ResetProgress();
        SceneManager.LoadScene("UI");
    }
    public void Quit()
    {
        Destroy(GameManager.Instance);
        Application.Quit();
    }
    
}
