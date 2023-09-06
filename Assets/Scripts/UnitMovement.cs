
using System;
using RTS.Input;
using UnityEngine;

namespace RTS.General
{
    [RequireComponent(typeof(InputHandler))]
    public class UnitMovement : MonoBehaviour
    {
        private InputHandler inputHandler;

        private void Awake()
        {
            inputHandler = GetComponent<InputHandler>();
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

