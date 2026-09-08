using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulsePointMover : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    [SerializeField] private float _speed = 2f;

    private float _time;

    private void Update()
    {
        _time += Time.deltaTime * _speed;

        float value = Mathf.Repeat(_time, 1f);

        value = value < 0.5f ? 0f : 1f;

        transform.position = Vector3.Lerp(
            _startPoint.position,
            _endPoint.position,
            value);
    }
}
