using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codegen
{
    class Register
    {
        private readonly string name;
        private int? p;
        private string variablename;

        public Register(string v, int? p)
        {
            this.name = v;
            this.p = p;

        }

        public String getName()
        {
            return this.name;
        }

        public bool setVariable(String name)
        {
            this.variablename = name;
            return true;
        }

        public String getVariable()
        {
            return this.variablename;
        }

        public int? getValue()
        {
            return this.p;
        }

        public bool setValue(int? value)
        {
            this.p = value;
            return true;
        }



    }
}