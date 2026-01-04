using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _spawnDelay;
    [SerializeField] private List<Transform> _spawnPoints;
    [SerializeField] private List<Transform> _targetPoints;
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
            
            Vector3 spawnPosition = _spawnPoints[Random.Range(0, _spawnPoints.Count)].position;
            Vector3 targetPosition = _targetPoints[Random.Range(0, _targetPoints.Count)].position;
            
            Enemy enemy = Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
            
            enemy.SetTarget(targetPosition);
        }
    }
}
