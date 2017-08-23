using UnityEngine;
using System.Collections;

public class VehicleSpawner : MonoBehaviour {

    public GameObject prefab; 
    float nextSpawnTime = 0;
    public float meanTime = 10;
    public float minTime = 1; 

    //public float spawnIntervalMin = 1;
    //public float spawnIntervalMax = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time > nextSpawnTime)
        {
            Spawn();
            nextSpawnTime = Time.time +  minTime -Mathf.Log(Random.value) * meanTime; 
        }
	}

    void Spawn()
    {
        var instance = Instantiate(prefab, transform.position, transform.rotation, transform); 
    }
}
