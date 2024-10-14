using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    private Transform _transform;
    private Transform _cameraTransform;

    private void Awake()
    {
        _cameraTransform = Camera.main.transform;
        _transform = transform;
    }

    private void Update()
    {
        _transform.LookAt(_cameraTransform.position);
    }
}
