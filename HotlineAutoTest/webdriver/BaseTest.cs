using NUnit.Framework;
using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace AutoTest.webdriver
{
    public class BaseTest
    {
        protected static Browser Browser = Browser.Instance;

        [SetUp] // вызывается перед началом запуска всех тестов
        public virtual void SetUp()
        {
            Browser = Browser.Instance;
            Browser.WindowMaximize();            
        }

        [TearDown] //вызывается после завершения всех тестов
        public virtual void TearDown()
        {
           Browser.Quite();
        }
    }
}
