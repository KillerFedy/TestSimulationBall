using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private List<Transform> _points;

    private float _timeToFinishWay;
    private float _speed;
    private Transform _currentPoint;
    private Transform _endPoint;
    private float _distanceWay;
    private int _indexCurrentPoint = 0;

    private void Start()
    {
        _endPoint = _points[_points.Count - 1];
        _currentPoint = _points[_indexCurrentPoint];
        _timeToFinishWay = _playerMovement.EndPointDistance / _playerMovement.Speed;
    }

    private void Update()
    {
        GetDistanceWay();
        _speed = _distanceWay / _timeToFinishWay;
        transform.position = Vector3.MoveTowards(transform.position, _currentPoint.position, Time.deltaTime * _speed);
        if(transform.position == _currentPoint.position)
        {
            if(_currentPoint == _endPoint)
            {
                _speed = 0;
                return;
            }
            _indexCurrentPoint++;
            _currentPoint = _points[_indexCurrentPoint];
        }
    }

    private void GetDistanceWay()
    {
        _distanceWay = 0;
        for (int i = 0; i < _points.Count - 1; i++)
        {
            _distanceWay += Vector3.Distance(_points[i].position, _points[i + 1].position);
        }
    }
}
