using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongPoint : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;
    [SerializeField] private Transform _endPoint;

    [SerializeField] private float _speed = 1f;

    private float _progress;

    private void Update()
    {
        _progress += _speed * Time.deltaTime;

        float value = Mathf.PingPong(_progress, 1f);

        transform.position = Vector3.Lerp(
            _startPoint.position,
            _endPoint.position,
            value);
    }
}
