using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeByBloodyAlpha.Class
{
    public class Player
    {
        public string Name { get; set; }

        public bool Field1;
        public bool Field2;
        public bool Field3;
        public bool Field4;
        public bool Field5;
        public bool Field6;
        public bool Field7;
        public bool Field8;
        public bool Field9;

        public void Restart()
        {
            Field1 = false;
            Field2 = false;
            Field3 = false;
            Field4 = false;
            Field5 = false;
            Field6 = false;
            Field7 = false;
            Field8 = false;
            Field9 = false;
        }
    }
}
