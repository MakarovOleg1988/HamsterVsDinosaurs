using UnityEngine;

namespace HamsterVsDinosaurs
{
    public class MovementMainCharacter : MainDataCharacters
    {
        public NewControls _controller;

        private void Awake()
        {
            _controller = new NewControls();
        }

        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void OnEnable()
        {
            _controller.NewActionMap.Enable();
            _controller.NewActionMap.MovementUp.Enable();
            _controller.NewActionMap.MovementRight.Enable();
        }

        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            float valueUp = _controller.NewActionMap.MovementUp.ReadValue<float>();
            float valueRight = _controller.NewActionMap.MovementRight.ReadValue<float>();

            Vector3 movement = new Vector3(valueRight * _moveSpeed, _rb.velocity.y, valueUp * _moveSpeed);

            _rb.AddForce(movement);

        }

            private void OnDestroy()
        {
            _controller.NewActionMap.Disable();
            _controller.NewActionMap.MovementUp.Disable();
            _controller.NewActionMap.MovementRight.Disable();
        }
    }
}
