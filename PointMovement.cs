using System.Collections.Generic;
using UnityEngine;

public class PointMovement : MonoBehaviour
{
    [SerializeField] private List<Transform> _points;
    [SerializeField] private float _speed = 2f;

    private int _currentPoint;

    private void Update()
    {
        if (_points == null || _points.Count < 2)
        {
            return;
        }

        Transform targetPoint = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPoint.position,
            _speed * Time.deltaTime);

        if (transform.position == targetPoint.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Count)
            {
                _currentPoint = 0;
            }
        }
    }
}
