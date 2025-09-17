using UnityEngine;

public class CubeScaler : MonoBehaviour
{
    [SerializeField] private Transform _cubeTransform;
    [SerializeField] private float _scalingSpeed = 1.2f;
    [SerializeField] private float _maxScale = 3f;
    [SerializeField] private bool _enableScaling = false;

    private Vector3 _startScale;

    private void Awake()
    {
        _startScale = _cubeTransform.localScale;
    }

    private void Update()
    {
        if (_enableScaling)
            Scale();

        if (_cubeTransform.localScale.magnitude > _maxScale)
            ResetScale();
    }

    private void ResetScale()
    {
        _enableScaling = false;
        _cubeTransform.localScale = _startScale;
    }

    private void Scale()
    {
        _cubeTransform.localScale = _cubeTransform.localScale + Vector3.one * _scalingSpeed * Time.deltaTime;
    }
}
