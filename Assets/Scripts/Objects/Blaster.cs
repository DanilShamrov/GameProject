using UnityEngine;

public class Blaster:MonoBehaviour, IWeapon
{
    [SerializeField] private float _reloadTime = .5f;
    [SerializeField] private GameObject _projectile;

    private float currentTime = 0;

    private void Start()
    {
        
    }
    public void Shoot()
    {
        if(currentTime > 0) return;
        currentTime = _reloadTime;
        Instantiate(_projectile, transform.position, transform.rotation);
    }

    private void Update()
    {
        if(currentTime < 0) return;
        currentTime -= Time.deltaTime;
    }
}