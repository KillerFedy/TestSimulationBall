using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed;

    public float Speed => _speed;
    public Transform EndPoint => _endPoint;

    public float EndPointDistance { get; private set; }

    private void Awake()
    {
        EndPointDistance = Vector3.Distance(transform.position, _endPoint.position);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, _speed * Time.deltaTime);
    }
}
