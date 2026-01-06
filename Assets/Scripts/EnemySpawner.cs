using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _spawnDelay;
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private Enemy _enemyPrefab;

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }
    
    private IEnumerator SpawnRoutine()
    {
        WaitForSeconds delay = new WaitForSeconds(_spawnDelay);

        while (enabled)
        {
            yield return delay;
            
            SpawnPoint spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
            
            Spawn(spawnPoint);
        }
    }

    private void Spawn(SpawnPoint spawnPoint)
    {
        Vector3 spawnPosition = _spawnPoints[Random.Range(0, _spawnPoints.Count)].transform.position;
        Vector3 targetPosition = spawnPoint.Target.position;
        
        Enemy enemy = Instantiate(spawnPoint.EnemyPrefab, spawnPosition, Quaternion.identity);
        
        enemy.SetPosition(targetPosition);
    }
}
