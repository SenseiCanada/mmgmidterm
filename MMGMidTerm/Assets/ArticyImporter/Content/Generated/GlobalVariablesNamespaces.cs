//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using UnityEngine;


namespace Articy.Mmgmidterm.GlobalVariables
{
    
    
    [Serializable()]
    public class TestConvoVariables : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public bool EnterDoor
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(0);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(0, value);
            }
        }
        
        // 
        public bool IntroComplete
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(1);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(1, value);
            }
        }
        
        // 
        public bool AnvilUnlocked
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(2);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(2, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("TestConvoVariables.EnterDoor", false);
            aStorage.RegisterVariable("TestConvoVariables.IntroComplete", false);
            aStorage.RegisterVariable("TestConvoVariables.AnvilUnlocked", false);
        }
    }
}
namespace Articy.Mmgmidterm.GlobalVariables
{
    
    
    [Serializable()]
    public class GargoyleDialogue : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public bool HasSword
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(3);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(3, value);
            }
        }
        
        // 
        public bool IntroComplete
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(4);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(4, value);
            }
        }
        
        // 
        public bool AnvilActive
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(5);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(5, value);
            }
        }
        
        // 
        public bool EnterDoor
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(6);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(6, value);
            }
        }
        
        // 
        public int Attempts
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueInt32(0);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueInt32(0, value);
            }
        }
        
        // 
        public int AttemptsWOMundane
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueInt32(1);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueInt32(1, value);
            }
        }
        
        // 
        public bool TalkedJunk
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(7);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(7, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("GargoyleDialogue.HasSword", false);
            aStorage.RegisterVariable("GargoyleDialogue.IntroComplete", false);
            aStorage.RegisterVariable("GargoyleDialogue.AnvilActive", false);
            aStorage.RegisterVariable("GargoyleDialogue.EnterDoor", false);
            aStorage.RegisterVariable("GargoyleDialogue.Attempts", 0);
            aStorage.RegisterVariable("GargoyleDialogue.AttemptsWOMundane", 0);
            aStorage.RegisterVariable("GargoyleDialogue.TalkedJunk", false);
        }
    }
}
