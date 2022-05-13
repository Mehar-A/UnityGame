using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] stagesPrefabs;
    private float startDelay = 16;
    private float spawnPosY = 1.5f;
    private float spawninterval = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomStages", startDelay, spawninterval);
    }

    void SpawnRandomStages()
    {
        // change it later for position of your animals and the hitbox sizes
        int stageIndex = Random.Range(0, stagesPrefabs.Length);

        Vector3 spawnPos = new Vector3(0, spawnPosY, 0);

        Instantiate(stagesPrefabs[stageIndex], spawnPos, stagesPrefabs[stageIndex].transform.rotation);
    }
}
