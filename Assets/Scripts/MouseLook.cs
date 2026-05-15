using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    [Header("Объект для вращения")]
    public Transform target;

    [Header("Чувствительность")]
    public float sensitivityX = 2f;
    public float sensitivityY = 2f;

    [Header("Ограничения углов")]
    public float minVerticalAngle = -80f;
    public float maxVerticalAngle = 80f;

    [Header("Расстояние до цели")]
    public float distance = 6f;

    private float xRotation = 0f;
    private float yRotation = 0f;

    private PlayerInput playerInput;
    private Vector2 lookInput;

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnEnable()
    {
        if (playerInput != null)
        {
            playerInput.actions["Look"].performed += ctx => lookInput = ctx.ReadValue<Vector2>();
            playerInput.actions["Look"].canceled += ctx => lookInput = Vector2.zero;
        }
    }

    private void OnDisable()
    {
        if (playerInput != null)
        {
            playerInput.actions["Look"].performed -= ctx => lookInput = ctx.ReadValue<Vector2>();
            playerInput.actions["Look"].canceled -= ctx => lookInput = Vector2.zero;
        }
    }

    private void Update()
    {
        if (target == null) return;

        // Обработка ввода и расчёт углов
        yRotation += lookInput.x * sensitivityX;
        xRotation -= lookInput.y * sensitivityY;
        xRotation = Mathf.Clamp(xRotation, minVerticalAngle, maxVerticalAngle);

        // Расчёт новой позиции и поворота камеры
        Quaternion rotation = Quaternion.Euler(xRotation, yRotation, 0);
        Vector3 position = target.position - (rotation * Vector3.forward * distance);

        // Применение изменений
        transform.SetPositionAndRotation(position, rotation);
    }
}