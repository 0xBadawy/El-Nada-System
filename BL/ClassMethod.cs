using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FWD.BL
{
    class ClassMethod
    {
        public MemoryStream ma = new MemoryStream();
        public byte[] by;
        public byte[] convert_byte()
        {
            return ma.ToArray();
        }

        public MemoryStream convert_image()
        {
            ma = new MemoryStream(by);
            return ma;
        }
    }
}
