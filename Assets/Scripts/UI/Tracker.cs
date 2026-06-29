using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{
    public List<GameObject> targets;
    public GameObject arrow;
    public static Tracker instance;
    void Start()
    {
        targets = new List<GameObject>();
        instance = this;
    }

    void Update()
    {
        for(int i=0; i<Spawner.instance.spawnedObj.Count; i++)
        {
            Plane[] p = GeometryUtility.CalculateFrustumPlanes(Camera.main);
            if (Spawner.instance.targetValues.TryGetValue(targets[i], out var v))
            {
                if (v == null)
                {
                    Destroy(targets[i]);
                    continue;
                }
            }
            else
            {
                Destroy(targets[i]);
                continue;
            }
            Bounds r = Spawner.instance.spawnedObj[i].GetComponent<Renderer>().bounds;
            if(GeometryUtility.TestPlanesAABB(p, r))
            {
                targets[i].SetActive(false);
            }
            else
            {
                targets[i].SetActive(true);
                targets[i].transform.LookAt(Camera.main.WorldToScreenPoint(Spawner.instance.spawnedObj[i].transform.position));
            }
        }
    }
}
