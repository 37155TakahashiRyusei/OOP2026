using Exercse03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class TextFileProcessor {
        private ITextFileService _service;

        public TextFileProcessor(ITextFileService service) {
            _service = service;
        }

        public void Run(string fileName) {


            _service.Initialize(fileName);
            var lines = File.ReadLines(fileName);
            //int cnt = 0;

            //if (cnt < 20) {
            //    cnt++;
            //    _service.Execute(lines);
            //} else {
            //    foreach (var line in lines) {
            //        _service.Execute(line);
            //    }
            //}

            foreach (var line in lines) {
                _service.Execute(line);
            }

            _service.Terminate();

        }
    }
}
