using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;

    // Update is called once per frame
    void Update()
    {
        var delta = _direction.x * _speed * Time.deltaTime;
        var newXPosition = transform.position.x + delta;
        var newYPosition = transform.position.y + delta;

        transform.position = new Vector3(newXPosition, newYPosition, transform.position.z);
    }
    public void SetDirection(Vector3 direction)
    {
        _direction = new Vector3(direction.x, direction.y, transform.position.z);
    }
}
