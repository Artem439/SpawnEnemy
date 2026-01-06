using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private NonPlayerCharacter _target;
    
    public Enemy EnemyPrefab => _enemy;
    public NonPlayerCharacter Target => _target;
}