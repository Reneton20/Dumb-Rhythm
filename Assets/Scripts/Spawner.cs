using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab1;
    public float spawnrate = 2f;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = new Vector3(Random.Range(-9.0f, 9.0f), 0, Random.Range(-9.0f, 9.0f));
        Instantiate(prefab1, position, Quaternion.identity);
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObject()
    {
        Vector3 position = new Vector3(Random.Range(-9.0f, 9.0f), Random.Range(-3f,4.5f), Random.Range(-9.0f, 9.0f));
       // Instantiate(prefab1, position, Quaternion.identity);
        Instantiate(prefab1, position, Quaternion.identity);
        if (stopSpawning)
        {
          
            CancelInvoke("SpawnObject");
        }
    }

}
