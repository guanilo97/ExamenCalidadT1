using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidatT1Test
{
    internal class RomanoTest
    {
        [Test]
        public void caso1()
        {
            var algoritmos = new ();
            var max = algoritmos.ObtenerMaxDeCincoNumeros(1, 2, 3, 4, 5);
            Assert.AreEqual(5, max);
        }
    }
}
