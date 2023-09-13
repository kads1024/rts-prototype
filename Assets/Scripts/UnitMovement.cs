
using System;
using RTS.Input;
using UnityEngine;
using UnityEngine.AI;

namespace RTS.General
{
    [RequireComponent(typeof(RTSUnitInputHandler), typeof(NavMeshAgent))]
    public class UnitMovement : MonoBehaviour
    {
        private RTSUnitInputHandler inputHandler;
        private NavMeshAgent navMeshAgent;
        
        private void Awake()
        {
            inputHandler = GetComponent<RTSUnitInputHandler>();
            navMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void OnEnable()
        {
            inputHandler.OnMovementKeyPressed += MoveUnit;
        }
        
        private void OnDisable()
        {
            inputHandler.OnMovementKeyPressed -= MoveUnit;
        }

        private void MoveUnit(Vector3 destination)
        {
            Debug.Log("MOVING UNIT...");
            navMeshAgent.SetDestination(destination);
        }
    }
}

