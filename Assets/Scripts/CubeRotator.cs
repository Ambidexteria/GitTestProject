using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private Transform _cubeTransform;
    [SerializeField] private float _angularSpeed = 90f;

    private void Update()
    {
        _cubeTransform.Rotate(Vector3.up, _angularSpeed *  Time.deltaTime);
    }
}
