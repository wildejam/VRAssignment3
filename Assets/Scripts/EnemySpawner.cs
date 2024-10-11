using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float respawnTime = 5;
    [SerializeField]
    private GameObject enemy;

    private float respawnTimer = 0;

    private void Update()
    {
        if (respawnTimer >= respawnTime)
        {
            respawnTimer = 0;
            GameObject newEnemy = Instantiate(enemy, transform.position, transform.rotation);
        }
        respawnTimer += Time.deltaTime;
    }
}
