
using System;
using RTS.Input;
using UnityEngine;

namespace RTS.General
{
    [RequireComponent(typeof(RTSUnitInputHandler))]
    public class UnitMovement : MonoBehaviour
    {
        private RTSUnitInputHandler inputHandler;

        private void Awake()
        {
            inputHandler = GetComponent<RTSUnitInputHandler>();
        }

        private void OnEnable()
        {
            inputHandler.OnMovementKeyPressed += MoveUnit;
        }
        
        private void OnDisable()
        {
            inputHandler.OnMovementKeyPressed -= MoveUnit;
        }

        private void MoveUnit()
        {
            Debug.Log("MOVING UNIT...");
        }
    }
}

