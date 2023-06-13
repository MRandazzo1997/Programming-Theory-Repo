using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private float spawnFrequency = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.5f, spawnFrequency);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnEnemy()
    {
        if (GameManager.Instance.isGameRunning)
        {
            int randomIndex = Random.Range(0, enemies.Length);
            Instantiate(enemies[randomIndex], transform.position, enemies[randomIndex].transform.rotation);
        }
    }
}
