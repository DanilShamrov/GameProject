using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    //[SerializeField] private Vector3 speed;
    [SerializeField] private int speed = 20;

    void Update()
    {
        transform.Translate((transform.worldToLocalMatrix * transform.forward) * Time.deltaTime * speed);

    }
    private void Start()
    {
        

    }
}
