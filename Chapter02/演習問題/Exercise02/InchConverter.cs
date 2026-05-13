using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    internal class InchConverter {
        private static readonly double ratio = 0.0254; //定数 constを使う
        //インチからメートルを求める
        public static double FromInch(int inch) {
            return inch * ratio;
        }
    }
}
