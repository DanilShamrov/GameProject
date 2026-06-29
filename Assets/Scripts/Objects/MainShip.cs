using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MainShip : MonoBehaviour, IDamageable
{
    InputAction Up, Down, Left, Right, Boost, Fire, RollLeft, RollRight, SpeedAdjust;
    IWeapon[] weapon;
    float rotationSpeed = 1f;
    public bool BoostPressed;
    public float speed = 10;
    public const float MaxSpeed = 10;
    public const float boostEffect = 2.5f;
    [SerializeField] int boostCharge = 100;
    int maxBoostCharge = (int)Upgrades.currentBoostLevel;
    int maxHealth = (int)Upgrades.currentHealthLevel;
    public GameObject junk;
    private int currentHealth;
    public int GetBoostCharge() => boostCharge;
    public static MainShip instance;
    public void TakeHealthDamage(int damage)
    {
        currentHealth -= damage;
    }
    public int GetHealth() => currentHealth;
    void Start()
    {
        if (instance == null)
            instance = this;
        weapon = GetComponentsInChildren<IWeapon>();

        Up = InputSystem.actions.FindAction("Up");
        Down = InputSystem.actions.FindAction("Down");
        Left = InputSystem.actions.FindAction("Left");
        Right = InputSystem.actions.FindAction("Right");
        Boost = InputSystem.actions.FindAction("Boost");
        Fire = InputSystem.actions.FindAction("Shoot");
        RollLeft = InputSystem.actions.FindAction("RollLeft");
        RollRight = InputSystem.actions.FindAction("RollRight");
        SpeedAdjust = InputSystem.actions.FindAction("SpeedAdjust");
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            if (junk != null)
            {
                var j = Instantiate(junk);
                j.transform.position = transform.position;
                j.SetActive(true);
            }
            foreach (Transform t in transform)
            {
                Destroy(t.gameObject);
            }
            gameObject.SetActive(false);
            Invoke("LoadMenu", 4);
            GameManager.Instance.ResetProgress();

            
        }
        

        if (Fire.IsPressed())
        {
            foreach (var weapon in weapon)
            {
                weapon.Shoot();
            }
        }

        if (Boost.IsPressed() && boostCharge>0)
        {
            transform.Translate(boostEffect * speed * Time.deltaTime * 
                (transform.worldToLocalMatrix * transform.forward));
            if (boostCharge > 0) 
            { 
                boostCharge--;
                BoostPressed = true;
            }
            else BoostPressed = false;
        }
        else 
        {
            BoostPressed = false;
            transform.Translate(speed * Time.deltaTime * (transform.worldToLocalMatrix*transform.forward));
            if(boostCharge<maxBoostCharge) boostCharge++;
        }

        if (Up.IsPressed())
        {
            transform.Rotate(new Vector3(-rotationSpeed, 0, 0));
        }
        if (Down.IsPressed())
        {
            transform.Rotate(new Vector3(rotationSpeed, 0, 0));
        }
        if (Left.IsPressed())
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0));
        }
        if (Right.IsPressed())
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0));
        }
        if (RollLeft.IsPressed())
        {
            transform.Rotate(new Vector3(0, 0, rotationSpeed));
        }
        if (RollRight.IsPressed())
        {
            transform.Rotate(new Vector3(0, 0, -rotationSpeed));
        }
        if (SpeedAdjust.inProgress)
        {
            float nSpeed = speed+SpeedAdjust.ReadValue<Vector2>().y;
            if (nSpeed >= 0 && nSpeed <= MaxSpeed)speed = nSpeed;
            
        }
        if (transform.position.y < -75)
        {
            transform.Rotate(new Vector3(-rotationSpeed, 0, 0));
        }
        if (transform.position.y > 75)
        {
            transform.Rotate(new Vector3(rotationSpeed, 0, 0));
        }
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("UI");
    }
}
