using Lab_02.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Web;
using System.Web.Http;

namespace Lab_02.Controllers {
    public class SomePowerfullApiController : ApiController {
        static int _result = 0;
        [HttpGet]
        public string doGet() {
            int stackValue = MySuperStack._intStack.Count == 0 ? 0 : (int)MySuperStack._intStack.Peek();
            return JsonSerializer.Serialize(new {
                RESULT = _result + stackValue
            });
        }

        [HttpPost]
        public string doPost(int result) {
            _result = result;
            return JsonSerializer.Serialize(new {
                RESULT = _result
            });
        }

        [HttpDelete]
        public string doDelete() {
            if (MySuperStack._intStack.Count != 0)
                MySuperStack._intStack.Pop();
            return JsonSerializer.Serialize(new {
                RESULT = MySuperStack._intStack
            });
        }

        [HttpPut]
        public string doPut(int newItem) {
            MySuperStack._intStack.Push(newItem);
            return JsonSerializer.Serialize(new {
                RESULT = MySuperStack._intStack
            });
        }
    }
}
