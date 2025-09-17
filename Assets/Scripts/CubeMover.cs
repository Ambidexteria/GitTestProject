using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private Transform _cubeTranform;
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _finish;
    [SerializeField] private bool _enableMoving;

    private Vector3 _startPosition;

    private void Awake()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if (_enableMoving == false)
            return;

        Move();

        if (TargetReached())
            ResetPosition();
    }

    private void ResetPosition()
    {
        _enableMoving = false;
        _cubeTranform.position = _startPosition;
    }

    private void Move()
    {
        Vector3 nextPosition = Vector3.MoveTowards(_cubeTranform.position, _finish, _speed * Time.deltaTime);
        _cubeTranform.position = nextPosition;
    }

    private bool TargetReached()
    {
        return _finish.sqrMagnitude - _cubeTranform.position.sqrMagnitude < 0.1f;
    }
}
