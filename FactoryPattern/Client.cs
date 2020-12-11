/*using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Client
    {
        private Calculator _calculator = new Calculator();
        private List<Comand> _comand = new List<Comand>();
        private int __current = 0;
        public void Redo(int levels)
        {
            Console.WriteLine("\n----- Redo {0} levels ", levels);
            for (int i = 0; i < levels; i++)
            {
                if (__current < _comand.Count - 1)
                {
                    Comand comand = _comand[_comand++];
                    comand.Execute();
                }
            }       
        }
        public void Undo (int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            for (int i = 0; i < levels; i++)
            {
                if (__current > 0)
                {
                    Comand comand = _comand[--__current] as Comand;
                    comand.UnExecute();
                }
            }
        }
        public void Compute (char @operator, int operand)
        {
            Comand comand
        }
        
    }
}*/
