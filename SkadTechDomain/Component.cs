using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkadTechDomain
{
    public enum ComponentName
{
    Bk,Abr,Chops
}
    public class Component
    {
       public ComponentName NameProductComponent { get; set; }
       public string ZsNumber { get; set; }

        public Zs zspec
        {
            get;set;
        }
    }
}
