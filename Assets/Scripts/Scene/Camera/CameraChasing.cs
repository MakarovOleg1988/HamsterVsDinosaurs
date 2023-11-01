using UnityEngine;

public class CameraChasing : MonoBehaviour
{
    protected Vector3 _pivotPosition;

    [SerializeField]
    protected float _speedMovementCamera;

    [SerializeField, Range(-3f, 3f)]
    protected float _pivotPositionY;

    [SerializeField, Range(-3f, 3f)]
    protected float _pivotPositionZ;

    [SerializeField]
    private Transform _transformMainCharacter;

    private void Update()
    {
        Chase();
    }

    private void Chase()
    {
        if (_transformMainCharacter == null) return;

        _pivotPosition = new Vector3(_transformMainCharacter.position.x, _transformMainCharacter.position.y + _pivotPositionY, _transformMainCharacter.position.z - _pivotPositionZ);
        transform.position = Vector3.Lerp(transform.position, _pivotPosition, _speedMovementCamera * Time.deltaTime);
    }
}
