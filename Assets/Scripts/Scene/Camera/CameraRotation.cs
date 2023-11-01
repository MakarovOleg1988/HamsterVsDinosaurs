using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    protected Quaternion _cameraRotation;

    [SerializeField]
    protected float _speedRotationCamera;

    private Transform _transformMainCharacter;

    private void Start()
    {
        _transformMainCharacter = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        CameraAutoRatation();
    }

    private void CameraAutoRatation()
    {
        if (_transformMainCharacter == null) return;

        this.transform.rotation = Quaternion.Lerp(_cameraRotation, _transformMainCharacter.transform.rotation, _speedRotationCamera * Time.deltaTime);
    }
}
