//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public class SteamVR_Input_ActionSet_CarControl : Valve.VR.SteamVR_ActionSet
    {
        
        public virtual SteamVR_Action_Single Acceleration
        {
            get
            {
                return SteamVR_Actions.carControl_Acceleration;
            }
        }
        
        public virtual SteamVR_Action_Single Break
        {
            get
            {
                return SteamVR_Actions.carControl_Break;
            }
        }
        
        public virtual SteamVR_Action_Single TurningLeft
        {
            get
            {
                return SteamVR_Actions.carControl_TurningLeft;
            }
        }
        
        public virtual SteamVR_Action_Single TurningRight
        {
            get
            {
                return SteamVR_Actions.carControl_TurningRight;
            }
        }
    }
}
