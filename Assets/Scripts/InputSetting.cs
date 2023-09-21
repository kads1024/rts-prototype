using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace RTS.Input
{
    [CreateAssetMenu(menuName = "Input/Input Settings")]
    public class InputSetting : ScriptableObject
    {
       [SerializeField] private KeyCode movementKey;
       public KeyCode MovementKey => movementKey;
       
       [SerializeField] private KeyCode[] abilityKeys;
       public KeyCode[] AbilityKeys => abilityKeys;
       
       
       
    }
}