using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMove : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _amplitude = 0.5f;
    [SerializeField] private float _frequency = 5f;

    private float _progress;

    private void Update()
    {
        _progress += _speed * Time.deltaTime;

        if (_progress > 1f)
        {
            _progress = 0f;
        }

        Vector3 position = Vector3.Lerp(
            _startPoint.position,
            _endPoint.position,
            _progress);

        position.y += Mathf.Sin(
            _progress * _frequency * Mathf.PI * 2f
        ) * _amplitude;

        transform.position = position;
    }
}
