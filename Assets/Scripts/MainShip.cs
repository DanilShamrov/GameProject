using UnityEngine;
using UnityEngine.InputSystem;

public class MainShip : MonoBehaviour
{
    InputAction Up, Down, Left, Right, Boost, Fire;
    IWeapon[] weapon;
    float rotationSpeed = 1f;

    [SerializeField] int speed = 10;
    [SerializeField] const float boostEffect = 2.5f;
    [SerializeField] int boostCharge = 100;
    [SerializeField] int maxBoostCharge = 100;

    public int GetBoostCharge() => boostCharge;
    void Start()
    {
        weapon = GetComponentsInChildren<IWeapon>();

        Up = InputSystem.actions.FindAction("Up");
        Down = InputSystem.actions.FindAction("Down");
        Left = InputSystem.actions.FindAction("Left");
        Right = InputSystem.actions.FindAction("Right");
        Boost = InputSystem.actions.FindAction("Boost");
        Fire = InputSystem.actions.FindAction("Shoot");
        
    }

    // Update is called once per frame
    void Update()
    {
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
            if(boostCharge>0) boostCharge--;

        }
        else { transform.Translate(speed * Time.deltaTime * (transform.worldToLocalMatrix*transform.forward));
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
        if (transform.position.y < -75)
        {
            transform.Rotate(new Vector3(-rotationSpeed, 0, 0));
        }
        if (transform.position.y > 75)
        {
            transform.Rotate(new Vector3(rotationSpeed, 0, 0));
        }
    }
    private void OnDestroy()
    {
        
        transform.DetachChildren();

    }
}
