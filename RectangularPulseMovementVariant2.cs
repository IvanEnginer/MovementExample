using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangularPulseMovementVariant2 : MonoBehaviour
{
    [SerializeField] private Transform _startPoint;

    [SerializeField] private float _width = 3f;
    [SerializeField] private float _height = 1f;
    [SerializeField] private float _speed = 2f;

    private float _time;

    private void Update()
    {
        _time += Time.deltaTime * _speed;

        float position = Mathf.Repeat(_time, _width * 2f);

        Vector3 offset;

        if (position < _width)
        {
            offset = Vector3.up * _height;
        }
        else
        {
            offset = Vector3.zero;
        }

        offset += Vector3.right * position;

        transform.position = _startPoint.position + offset;
    }
}
