using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulsePoint : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed = 1f;

    private float _progress;

    private void Update()
    {
        _progress += _speed * Time.deltaTime;

        _progress = Mathf.Clamp01(_progress);

        transform.position = Vector3.Lerp(
            _startPoint.position,
            _endPoint.position,
            _progress
        );
    }
}
