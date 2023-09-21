
using System;
using RTS.Input;
using UnityEngine;
using UnityEngine.AI;

namespace RTS.General
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class UnitMovement : MonoBehaviour
    {
        [SerializeField] private InputSetting inputSetting;
        [SerializeField] private LayerMask movementLayer;
        
        private Camera mainCamera;
        private NavMeshAgent navMeshAgent;
        private void Awake()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            mainCamera = Camera.main;
        }

        private void Update()
        {
            HandleRtsMovement();
        }

        private void HandleRtsMovement()
        {
            if (UnityEngine.Input.GetKeyDown(inputSetting.MovementKey))
            {
                Ray ray = mainCamera.ScreenPointToRay(UnityEngine.Input.mousePosition);
                if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
                {
                    // Bit shift to get the correct layer value
                    int mouseHitLayer = 1 << hit.collider.gameObject.layer;
                     
                    if(mouseHitLayer == movementLayer) 
                        navMeshAgent.SetDestination(hit.point);
                }
            }
        }
    }
}

