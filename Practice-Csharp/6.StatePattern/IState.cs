using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StatePattern
{
    public interface IState
    {
        void OnEnter(IContext context);
        void UpdateState(IContext context);
        void OnExit(IContext context);
    }
}
