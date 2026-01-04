using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private Vector3 _targetPosition;
    
    private void Update()
    {
        Move();
    }

    public void SetTarget(Vector3 targetPosition)
    {
        _targetPosition = targetPosition;
    }
    
    private void Move()
    {
        Vector3 currentPosition = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
        
        currentPosition.y = transform.position.y;
        transform.position =  currentPosition;
    }
}