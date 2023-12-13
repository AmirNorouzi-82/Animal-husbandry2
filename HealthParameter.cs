using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_husbandry
{
    public class HealthParameter<T>
    {
        public string Name { get; set; }
        public T Current { get; set; }
        public T Standard { get; set; }
        public HealthParameter(string name, T current,T standard) 
        {
            Name = name;
            Current = current;
            Standard = standard;
        }
        public override string ToString()
        {
            return $"{Name},Current={Current},Standard={Standard}";
        }
        public float StressFactor()
        {
            return 0.5f;
        }
    }
}
