using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    public Enemy EnemyPrefab => _enemy;
}