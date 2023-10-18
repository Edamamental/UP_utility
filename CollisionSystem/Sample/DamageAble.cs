using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CP.CollSystem;

namespace CP.CollSystem
{
    public class DamageAble : BaseColTriggerOwner<DamageAble, AttackAble>
    {
        public override DamageAble Owner { get { return this; } }

        public override void OnSomethingEnter(Collider other)
        {
        }

        public override void OnSomethingExit(Collider other)
        {
        }

        public override void OnSomethingStay(Collider other)
        {
        }

        public override void OnTargetEnter(ICollisiomReceiverOwner<AttackAble, DamageAble> target, Collider other)
        {
            Debug.Log(target);
        }

        public override void OnTargetExit(ICollisiomReceiverOwner<AttackAble, DamageAble> target, Collider other)
        {
            Debug.Log(target);
        }

        public override void OnTargetStay(ICollisiomReceiverOwner<AttackAble, DamageAble> target, Collider other)
        {
            Debug.Log(target);
        }
    }
}

