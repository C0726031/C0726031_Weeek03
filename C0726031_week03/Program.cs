using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0726031_week03
{
    class Program
    {
        static void Main(string[] args)
        { }
        class Countryside
        {
            Village Alst;
            Village Maeland;
            Village Scheing;

            public void InitializeMap()
            {
                Alst = new Village();
                Maeland = new Village();
                Maeland.isAstrildeHere = true;
                Scheing = new Village();

                Alst.NextVillage = Maeland;
                Maeland.NextVillage = Scheing;
                Scheing.NextVillage = Alst;
            }
            public void WalkAround()
            {
                Village InitialVillage = this.Maeland;


            }



            class Village

            {
                public Village PreviousVillage;
                public Village NextVillage;
                public String villageName;
                public bool isAstrildeHere = false;
                bool isScheingHere = false;
                public Village() { }
            }

        }
    }
}

