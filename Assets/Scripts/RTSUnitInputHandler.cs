using System;
using UnityEngine;
using UnityEngine.Events;


namespace RTS.Input
{
    
    public class RTSUnitInputHandler : MonoBehaviour
    {
        [SerializeField] private InputSetting inputSetting;
        public UnityAction OnMovementKeyPressed;

        [SerializeField] private LayerMask movementLayer;

        private Camera mainCamera;

        private void Awake()
        {
            mainCamera = Camera.main;
        }

        private void Update()
        {
            HandleRTSMovement();
        }

        private void HandleRTSMovement()
        {
            if (UnityEngine.Input.GetKeyDown(inputSetting.MovementKey))
            {
                Ray ray = mainCamera.ScreenPointToRay(UnityEngine.Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, movementLayer))
                {
                    Debug.Log(hit.collider.gameObject.layer);
                    OnMovementKeyPressed.Invoke();
                }
            }
        }
        
    }
}