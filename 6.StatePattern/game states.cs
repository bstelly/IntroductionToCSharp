using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StatePattern
{
    public class GameStart : IState
    {
        public void OnEnter(IContext context)
        {
            //context.UpdateContext();
        }

        public void UpdateState(IContext context)
        {
            context.ChangeState(this);
        }

        public void OnExit(IContext context)
        {
            throw new NotImplementedException();
        }
    }

    public class GameRunning : IState
    {
        public void OnEnter(IContext context)
        {
            context.ChangeState(this);
        }

        public void UpdateState(IContext context)
        {
            throw new NotImplementedException();
        }

        public void OnExit(IContext context)
        {
            throw new NotImplementedException();
        }
    }

    public class GameExit : IState
    {
        public void OnEnter(IContext context)
        {
            throw new NotImplementedException();
        }

        public void UpdateState(IContext context)
        {
            context.ChangeState(this);
        }

        public void OnExit(IContext context)
        {
            throw new NotImplementedException();
        }
    }
}
