using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea005.Class
{
    public class Question
    {
        public int num;
        public string header;
        public string ans1;
        public string ans2;
        public string ans3;
        public string ans4;

        public string answer;
        
        public Question(int n)
        {
            this.num = n;
            this.header = "Pregunta " + this.num;
            this.ans1 = "Respuesta 1";
            this.ans2 = "Respuesta 2";
        }
    }
}
