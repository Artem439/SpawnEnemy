using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : MonoBehaviour
{
    [SerializeField] private List<Transform> _targetPoints;
    [SerializeField] private float _speed;
    [SerializeField] private float _reachDistance = 0.2f;
    
    private Vector3 _targetPosition;

    private int _targetPositionIndex = 0;

    private void Start()
    {
        _targetPosition = _targetPoints[_targetPositionIndex].position;
    }
    
    private void Update()
    {
        UpdateTarget();
        Move();
    }
    
    private void Move()
    {
        Vector3 targetPosition = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
        
        targetPosition.y = transform.position.y;
        transform.position =  targetPosition;
    }
    
    private void UpdateTarget()
    {
        Vector3 currentPosition = transform.position;

        if (currentPosition ==  _targetPosition)
            _targetPosition = _targetPoints[_targetPositionIndex++].position;
    }
}