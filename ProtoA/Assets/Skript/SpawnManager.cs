using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] balloonPrefabs;
    public int balloonIndex;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomBalloon()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-5, 5), 10.0);
        int balloonIndex = SpawnRandomBalloon().Range(0, balloonPrefabs.Length);
        
    }
}
