using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour 
{
    public GameObject cubePrefab;
    public float spawnRate = 1f;
    public float spawnWidth = 2.3f;

    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            SpawnCube();
        }
	}

    private void SpawnCube()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnWidth, spawnWidth),
                                            transform.position.y, transform.position.z);
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);

        timer = 0;
    }
}
