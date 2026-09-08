using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangularPulseMovement : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;

    [SerializeField] private float _width = 3f;
    [SerializeField] private float _height = 1f;
    [SerializeField] private float _speed = 2f;

    private float _time;

    private void Update()
    {
        _time += Time.deltaTime * _speed;

        float x = _time;

        float y = 0f;

        // Период импульса
        float period = _width * 2f;

        float position = Mathf.Repeat(x, period);

        if (position < _width)
        {
            y = _height;
        }
        else
        {
            y = 0f;
        }

        transform.position = _startPoint.position
            + Vector3.right * x
            + Vector3.up * y;
    }
}
