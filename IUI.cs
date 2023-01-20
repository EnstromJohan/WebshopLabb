using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopLabb
{
    internal interface IUI
    {
        public string UserInput();
        public void Print(string text);
        public void Exit();


    }
}
