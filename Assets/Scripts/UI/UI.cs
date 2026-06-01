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
    
}
