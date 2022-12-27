using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricsOnlineWebApp
{
    public partial class State
    {
        private ElectricsOnlineEntities _ctx = new ElectricsOnlineEntities();

        public List<State> All
        {
            get
            {
                return _ctx.States.ToList<State>();

            }
        }
    }
}