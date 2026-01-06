using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _target;
    
    public Enemy EnemyPrefab => _enemy;
    public Transform Target => _target;
}