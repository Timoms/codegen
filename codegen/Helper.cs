using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codegen
{
    class Helper
    {
        public Register GetFreeRegister(Register[] reg)
        {
            for (int i = 0; i < reg.Length; i++)
            {
                if (reg[i].getValue() == null)
                    return reg[i];

            }
            return null;
        }

        public Register GetRegisterFromName(Register[] reg, String name) {
            for (int i = 0; i < reg.Length; i++)
            {
                if (reg[i].getVariable() == name)
                    return reg[i];

            }
            return null;
        }
        
        public bool RegisterFurtherUsage(StreamReader s, String var)
        {
            String line;
            int usage = 0;
            while ((line = s.ReadLine()) != null)
            {

            }
            //if(usage)

            return false;
        }

    }
}
