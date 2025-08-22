using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_brown_jaylen
{   //Makes IBootUP interface
    internal interface IBootUp
    {
   
        //makes is on property
        public bool IsOn { get; set; }
        //makes th PowerOnOff methed
        public void PowerOnOff();
        
        
        
    
    }
}
