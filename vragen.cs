using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Desktop_089667
{

    public class Vragen
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Vraag { get; set; }
        public string AntwoordA { get; set; }
        public string AntwoordB { get; set; }
        public string AntwoordC { get; set; }
        public string GoedeAntwoord { get; set; }
    
        public Vragen(int ID, string Vraag, string AntwoordA, string AntwoordB, string AntwoordC, string Goedeantwoord)
        {
            this.Id = ID;
            this.Vraag = Vraag;
            this.AntwoordC= AntwoordC;
            this.AntwoordB = AntwoordB;
            this.AntwoordA  = AntwoordA;
            this.GoedeAntwoord = Goedeantwoord;
        }
        //public Vragen() { }

    }
}
