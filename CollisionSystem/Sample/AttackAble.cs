using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CP.CollSystem;

namespace CP.CollSystem
{
    public class AttackAble : MonoBehaviour, ICollisiomReceiverOwner<AttackAble, DamageAble>
    {
        public AttackAble Owner { get { return this; } }

        public void OnTargetEnter(ICollisionTriggerOwner<DamageAble, AttackAble> target)
        {
            Debug.Log(target);
        }

        public void OnTargetExit(ICollisionTriggerOwner<DamageAble, AttackAble> target)
        {
            
        }

        public void OnTargetStay(ICollisionTriggerOwner<DamageAble, AttackAble> target)
        {
            
        }
    }
}

