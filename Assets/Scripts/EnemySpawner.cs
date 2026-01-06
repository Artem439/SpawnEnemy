using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _spawnDelay;
    [SerializeField] private List<SpawnPoint> _spawnPoints;
    [SerializeField] private Enemy _enemyPrefab;

    [SerializeField] private int _enemyCount;
    
    private int _counter = 0;

    private void OnValidate()
    {
        if (_enemyCount <= 0)
            _enemyCount = 1;
    }
    
    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }
    
    private IEnumerator SpawnRoutine()
    {
        WaitForSeconds delay = new WaitForSeconds(_spawnDelay);

        while (_counter < _enemyCount)
        {
            yield return delay;
            
            SpawnPoint spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
            
            Spawn(spawnPoint);
            
            _counter++;
        }
    }

    private void Spawn(SpawnPoint spawnPoint)
    {
        Vector3 spawnPosition = _spawnPoints[Random.Range(0, _spawnPoints.Count)].transform.position;
        NonPlayerCharacter target = spawnPoint.Target;
        
        Enemy enemy = Instantiate(spawnPoint.EnemyPrefab, spawnPosition, Quaternion.identity);
        
        enemy.SetTarget(target);
    }
}
