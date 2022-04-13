using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class DeadBee : Bee
    {
        public override float CostPerShift { get { return 0f; } }
        public DeadBee() : base("Dead Bee") { }
        protected override void DoJob()
        {
            
        }
    }
}
