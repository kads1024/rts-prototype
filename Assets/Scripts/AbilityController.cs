using System;
using System.Collections;
using System.Collections.Generic;
using RTS.Input;
using UnityEngine;

namespace RTS.Ability
{
    public class AbilityController : MonoBehaviour
    {
        [SerializeField] private InputSetting inputSetting;
        private AbilityBase[] abilities;

        private void Awake()
        {
            abilities = GetComponents<AbilityBase>();
        }

        private void Update()
        {
            for (int i = 0; i < abilities.Length; i++)
            {
                if (UnityEngine.Input.GetKeyDown(inputSetting.AbilityKeys[abilities[i].AbilityIndex]))
                {
                    abilities[i].TriggerAbility();
                    break;
                }
            }
        }
    }
}

