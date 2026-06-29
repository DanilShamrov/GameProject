using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSelector : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    private readonly string Button1Description = "Стреляйте по космическому мусору, чтобы уничтожить его.\nСложность: Очень легко\nНаграда: 100₽",
                            Button2Description = "Расчистите минное поле. Осторожно, мины взрываются, если вы подлетите слишком близко.\nСложность: Легко\n\nНаграда: 500₽",
                            Button3Description = "Бой с несколькими кораблями противника. Не дайте им сесть вам на хвост.\nСложность: Средне\n\nНаграда: 1 000₽",
                            Button4Description = "Защитите грузовые корабли. Вы проиграете, если все грузовики будут уничтожены.\nСложность: Сложно\n\nНаграда: 2 000₽";
    public TextMeshProUGUI text;
    public Button selectedButton;
    void Start()
    {
        SelectButton1();
    }

    void Update()
    {
        
    }
    public void SelectButton1()
    {
        selectedButton=button1;
        text.text = Button1Description;
    }
    public void SelectButton2()
    {
        selectedButton = button2;
        text.text = Button2Description;
    }
    public void SelectButton3()
    {
        selectedButton = button3;
        text.text = Button3Description;
    }
    public void SelectButton4()
    {
        selectedButton = button4;
        text.text = Button4Description;
    }
    public void StartSelectedLevel()
    {
        if(selectedButton==button1) 
        {
            SceneManager.LoadScene("JunkCleaning");
        }
        if (selectedButton == button2)
        {
            SceneManager.LoadScene("Minefield");
        }
        if (selectedButton == button3)
        {
            SceneManager.LoadScene("DefaultFight");
        }
        if (selectedButton == button4)
        {
            SceneManager.LoadScene("CargoShipFight");
        }
    }
}
