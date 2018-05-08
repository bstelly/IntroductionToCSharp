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
            Console.WriteLine("Now Entering: " + this + " state");
        }

        public void UpdateState(IContext context)
        {
            context.ChangeState(this);
        }

        public void OnExit(IContext context)
        {
            Console.WriteLine("Now Leaving: " + context.CurrentState + " state");
        }
    }

    public class GameRunning : IState
    {
        public void OnEnter(IContext context)
        {
            Console.WriteLine("Now Entering: " + this + " state");
        }

        public void UpdateState(IContext context)
        {
            context.ChangeState(this);
        }

        public void OnExit(IContext context)
        {
            Console.WriteLine("Now Leaving: " + context.CurrentState + " state");
        }
    }

    public class GameExit : IState
    {
        public void OnEnter(IContext context)
        {
            Console.WriteLine("Now Entering: " + this + " state");
        }

        public void UpdateState(IContext context)
        {
            context.ChangeState(this);
        }

        public void OnExit(IContext context)
        {
            Console.WriteLine("Now Leaving: " + context.CurrentState + " state");
        }
    }
}
