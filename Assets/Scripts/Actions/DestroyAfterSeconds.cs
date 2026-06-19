using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    [SerializeField] private int sec;
    void Start()
    {
        Destroy(gameObject, sec);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
