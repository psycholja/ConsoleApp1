using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Box
    {
        int width;
        int higth;
        int length;

        public void setWidth(int param)
        {
            this.width = param;

        }
        public void setHigth(int param)
        {
            this.higth = param;

        }
        public void setLength(int param)
        {
            this.length = param;

        }
        public int getVolume()
        {
            int c;
            c = this.width * this.higth * this.length;
            return c;
        }
    }
}
