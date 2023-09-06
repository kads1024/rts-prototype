using UnityEngine;
using UnityEngine.Events;

namespace RTS.Input
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private InputSetting inputSetting;
        public UnityAction OnMovementKeyPressed;
        
        private void Update()
        {
            HandleRTSMovement();
        }

        private void HandleRTSMovement()
        {
            if (UnityEngine.Input.GetKeyDown(inputSetting.MovementKey))
            {
                OnMovementKeyPressed.Invoke();
            }
        }
        
    }
}