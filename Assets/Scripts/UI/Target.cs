using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Target : MonoBehaviour
{

    Image img;
    public LayerMask targetLayer; // Слой, по которому будет стрелять луч
    public float maxDistance = 100f; // Максимальная дальность луча

    private RectTransform rectTransform;
    private Camera mainCamera;
    void Start()
    {
        img= GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        // --- ШАГ 1: Получаем позицию мыши ---
        Vector2 position = transform.position;

        // --- ШАГ 2: Проводим Raycast в мир ---
        Ray ray = mainCamera.ScreenPointToRay(position);
        RaycastHit hitInfo;

        bool isHit = Physics.Raycast(ray, out hitInfo, maxDistance, targetLayer);

        if (isHit)
        {
            img.color = Color.red; // Меняем цвет
        }
        else
        {
            img.color = Color.white;
        }
    }
}

