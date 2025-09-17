using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private Transform _cubeTransform;
    [SerializeField] private float _angularSpeed = 90f;
    [SerializeField] private bool _enableRotation = false;

    private void Update()
    {
        if (_enableRotation)
            _cubeTransform.Rotate(Vector3.up, _angularSpeed * Time.deltaTime);
    }
}
