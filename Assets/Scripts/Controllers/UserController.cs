using UnityEngine;
using GameSE.BHunt.Input;
using UnityEngine.InputSystem;
using System;
using Cinemachine;

namespace GameSE.BHunt.Controllers
{
    public class UserController : MonoBehaviour
    {
        private float _movementSpeed = 10f;
        private float _turnSmoothTime = 0.1f;

        private CharacterController _controller;
        private MainBHuntControls _playerInput;
        private MainBHuntControls.MainActions _playerActions;
        public CinemachineFreeLook MovementCamera;
        public GameObject AimCamera;
        public Transform MainCamera;
        private Vector2 _lookDirection;
        private float _turnSmoothVelocity;

        void Awake()
        {
            _playerInput = new MainBHuntControls();
        }
        void Start()
        {
            _controller = GetComponent<CharacterController>();
            _playerActions = _playerInput.Main;
            _playerActions.Aim.performed += ChangeCameras;
        }
        void Update()
        {
            _lookDirection = _playerActions.Look.ReadValue<Vector2>().normalized;
            if (_lookDirection.magnitude > 0.1f)
            {

                MovementCamera.m_XAxis.Value += _lookDirection.x * 2;
                MovementCamera.m_YAxis.Value = Mathf.Clamp(((_lookDirection.y * -1) / 50) + MovementCamera.m_YAxis.Value, 0, 1);
            }
        }

        void FixedUpdate()
        {
            var direction = _playerActions.Move.ReadValue<Vector2>();
            if (direction.magnitude > .01f)
            {
                Move(direction);
            }
        }

        private void ChangeCameras(InputAction.CallbackContext ctx)
        {
            var isMovementCameraActive = MovementCamera?.gameObject.activeSelf ?? false;
            MovementCamera?.gameObject.SetActive(!isMovementCameraActive);
            AimCamera?.SetActive(isMovementCameraActive);
        }

        private void Move(Vector2 direction)
        {
            var targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + MainCamera.transform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _turnSmoothVelocity, _turnSmoothTime);
            transform.rotation = Quaternion.Euler(0, angle, 0);

            var movementDirection = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
            _controller.SimpleMove(movementDirection.normalized * _movementSpeed);
        }

        private void OnEnable()
        {
            _playerInput.Main.Enable();
        }

        private void OnDisable()
        {
            _playerInput.Main.Disable();
        }
    }
}