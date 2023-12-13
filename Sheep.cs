using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_husbandry
{
    public class Sheep : Animal, IComparable<Sheep>,IEnumerable<Sheep>
    {
        public DateTime BirthDate { get; init; }
        static int MaxLife { get; }
        public List<Environment> Environments { get; set; }
        public static int Number { get; set; }
        public List<SheepParamete> SheepParams { get; set; }
        public override float StressFactor()
        {
            return 0.4f;
        }

        public override int Life()
        {
            return (DateTime.Now - BirthDate).Days; ;
        }

        public override int TimeToDie()
        {
            return Life() * 24;
        }

        public override float KillPriority()
        {
            return 0.8f;
        }

        public override int CostPerDay()
        {
            return 8;
        }

        public override int ValuePerDay()
        {
            return 15;
        }
        public override string ToString()
        {
            return $"Sheep:BirthDate={BirthDate}, MaxLife={MaxLife},Number={Number},Environments={string.Join("", Environments)}, SheepParams={string.Join("", SheepParams)}";
        }

        public int CompareTo(Sheep? other)
        {
            return 0;
        }

        public IEnumerator<Sheep> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public Sheep()
        {
            HealthParameter<int> TDS = new HealthParameter<int>("TDS", 110, 140);
            HealthParameter<int> Temp = new HealthParameter<int>("Temp", 30, 35);
            HealthParameter<int> DB = new HealthParameter<int>("DB", 85, 70);
            HealthParameter<int> Density = new HealthParameter<int>("Density", 1000, 990);
            HealthParameter<int> AQI = new HealthParameter<int>("AQI", 55, 45);
            HealthParameter<int> OX = new HealthParameter<int>("OX", 95, 90);
        }
    }
}
