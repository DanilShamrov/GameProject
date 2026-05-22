using UnityEngine;

public class EnemyShipControls : MonoBehaviour
{

    public GameObject Ship;
    public GameObject Target;
    IWeapon[] weapon;

    public float rotationSpeed;
    public float moveSpeed;

    private void OnTriggerStay(Collider other)
    {
        
        Vector3 dir = other.transform.position - Ship.transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(dir);
        Ship.transform.rotation = Quaternion.Slerp(Ship.transform.rotation, targetRotation, rotationSpeed*Time.deltaTime);
        Target = other.gameObject;
        if (dir.magnitude < 30)
        {
            if (dir.magnitude < 20) moveSpeed = 5;
            else moveSpeed = 10;
            if (Target != null)
            {
                foreach (var weapon in weapon)
                {
                    weapon.Shoot();
                }
            }
        }
        else { Target=null; }

    }
    void Start()
    {
        weapon = transform.parent.GetComponentsInChildren<IWeapon>();
        Ship = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Ship.transform.Translate((transform.worldToLocalMatrix * Ship.transform.forward) * moveSpeed * Time.deltaTime);
        
    }
    private void OnDestroy()
    {
        Spawner.instance.spawnedCount--;
    }
}
