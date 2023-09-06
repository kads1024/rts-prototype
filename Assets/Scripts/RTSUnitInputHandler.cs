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
                if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
                {
                    // Bit shift to get the correct layer value
                    int mouseHitLayer = 1 << hit.collider.gameObject.layer;
                     
                    if(mouseHitLayer == movementLayer) 
                       OnMovementKeyPressed.Invoke();
                }
            }
        }
        
    }
}