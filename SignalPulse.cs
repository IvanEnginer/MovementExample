using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalPulse : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    [SerializeField] private GameObject _pointPrefab;

    [SerializeField] private int _pointCount = 5;
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _distance = 0.2f;

    private Transform[] _points;

    private void Start()
    {
        CreatePoints();
    }

    private void Update()
    {
        MovePoints();
    }

    private void CreatePoints()
    {
        _points = new Transform[_pointCount];

        for (int i = 0; i < _pointCount; i++)
        {
            GameObject point = Instantiate(
                _pointPrefab,
                transform);

            _points[i] = point.transform;
        }
    }

    private void MovePoints()
    {
        for (int i = 0; i < _points.Length; i++)
        {
            float progress = Time.time * _speed;

            progress -= i * _distance;

            progress = Mathf.Repeat(progress, 1f);

            _points[i].position = Vector3.Lerp(
                _startPoint.position,
                _endPoint.position,
                progress);
        }
    }
}
