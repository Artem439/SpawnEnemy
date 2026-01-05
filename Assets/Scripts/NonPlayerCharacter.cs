using System.Collections.Generic;
using UnityEngine;

public class NonPlayerCharacter : Enemy
{
    [SerializeField] private List<Transform> _targetPoints;
    [SerializeField] private float _reachDistance = 0.2f;
    [SerializeField] private Material _material;
    
    private int _currentPointIndex = 0;

    private void Start()
    {
        if (_targetPoints.Count > 0)
            Initialize(_targetPoints[0].position, _material);
    }
    
    private void Update()
    {
        CheckTargetReached();
        
        Move();
    }
    
    private void CheckTargetReached()
    {
        if (transform.position == _targetPoints[_currentPointIndex].position)
        {
            _currentPointIndex = (_currentPointIndex + 1) % _targetPoints.Count;

            Initialize(_targetPoints[_currentPointIndex].position, _material);
        }
    }
}