using UnityEngine;

public class EnemyShipControls : MonoBehaviour
{

    public GameObject Ship;
    public GameObject Target=null;
    IWeapon[] weapon;

    public float rotationSpeed;
    public float moveSpeed;
    public int aggressionRadius = 30;
    public bool isRequired = true;
    private void OnTriggerStay(Collider other)
    {
        if (Target == null)
        {
            Target = other.gameObject;
        }
        Vector3 dir = Target.transform.position - Ship.transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(dir);
        Ship.transform.rotation = Quaternion.Slerp(Ship.transform.rotation, targetRotation, rotationSpeed*Time.deltaTime);
        
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
        if (Difficulty.currentDifficulty == Difficulty.DifficultyMode.Low)
            rotationSpeed = 0.2f;
        if (Difficulty.currentDifficulty == Difficulty.DifficultyMode.Medium)
            rotationSpeed = 0.5f;
        if (Difficulty.currentDifficulty == Difficulty.DifficultyMode.Hard)
            rotationSpeed = 0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        Ship.transform.Translate((transform.worldToLocalMatrix * Ship.transform.forward) * moveSpeed * Time.deltaTime);
        if (Ship.transform.position.y < -75)
        {
            Ship.transform.Rotate(new Vector3(-rotationSpeed, 0, 0));
        }
        if (Ship.transform.position.y > 75)
        {
            Ship.transform.Rotate(new Vector3(rotationSpeed, 0, 0));
        }
    }
    private void OnDestroy()
    {
        if (isRequired)
            Spawner.instance.spawnedCount--;
    }
}
