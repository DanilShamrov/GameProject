using UnityEngine;

public class RotateOnSpawn : MonoBehaviour
{
    public int rotationX, rotationY, rotationZ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.Rotate(rotationX, rotationY, rotationZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
