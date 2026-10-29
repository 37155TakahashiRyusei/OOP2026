using Exercse03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise03 {
    public class Take20Service : ITextFileService {
        private int _count = 0;

        public void Initialize(string fname) {
            Console.WriteLine(fname);
            //_count = 0;
        }

        public bool Execute(string line) {
            Console.WriteLine(line);
            _count++;

            return _count < 20;
        }

        public void Terminate() {
            //Console.WriteLine("{0} 行", _count);
        }
    }
}
