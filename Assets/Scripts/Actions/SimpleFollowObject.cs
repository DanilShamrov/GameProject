using UnityEngine;

public class SimpleFollowObject : MonoBehaviour
{
    public GameObject other;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = other.transform.position;
        transform.rotation = other.transform.rotation;
    }
}
