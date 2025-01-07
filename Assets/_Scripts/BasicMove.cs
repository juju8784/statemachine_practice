using System;
using UnityEngine;

public class BasicMove : BaseState<SMBasic.EBasic>
{


    public BasicMove(SMBasic.EBasic key) : base(key)
    {
    }

    public override void EnterState()
    {
        
        return;
    }

    public override void ExitState()
    {
        throw new NotImplementedException();
    }

    public override void UpdateState()
    {
        
    }

    public override SMBasic.EBasic GetNextState()
    {
        throw new NotImplementedException();
    }

    public override void OnTriggerEnter(Collider other)
    {
        throw new NotImplementedException();
    }

    public override void OnTriggerExit(Collider other)
    {
        throw new NotImplementedException();
    }

    public override void OnTriggerStay(Collider other)
    {
        throw new NotImplementedException();
    }
}
