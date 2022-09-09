using CalidadT1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadT1Test
{
    public class RomanoTest
    {
        [Test]
        public void Caso01()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(20);

            Assert.AreEqual("XX",resultado);
        }
        [Test]
        public void Caso02()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(10);

            Assert.AreEqual("X", resultado);
        }
        [Test]
        public void Caso03()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(75);

            Assert.AreEqual("LXXV", resultado);
        }
        [Test]
        public void Caso04()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(57);

            Assert.AreEqual("LVII", resultado);
        }
        [Test]
        public void Caso05()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(8);

            Assert.AreEqual("VIII", resultado);
        }
        [Test]
        public void Caso06()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(7);

            Assert.AreEqual("VII", resultado);
        }
        [Test]
        public void Caso07()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(88);

            Assert.AreEqual("LXXXVIII", resultado);
        }
        [Test]
        public void Caso08()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(22);

            Assert.AreEqual("XXII", resultado);
        }
        [Test]
        public void Caso09()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(13);

            Assert.AreEqual("XIII", resultado);
        }
        [Test]
        public void Caso010()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(22);

            Assert.AreEqual("XXII", resultado);
        }
        [Test]
        public void Caso11()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(18);

            Assert.AreEqual("XVIII", resultado);
        }
        [Test]
        public void Caso12()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(31);

            Assert.AreEqual("XXXI", resultado);
        }
        [Test]
        public void Caso13()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(3);

            Assert.AreEqual("III", resultado);
        }
        [Test]
        public void Caso14()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(10);

            Assert.AreEqual("X", resultado);
        }
        [Test]
        public void Caso15()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(15);

            Assert.AreEqual("XV", resultado);
        }
        [Test]
        public void Caso16()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(99);

            Assert.AreEqual("LXXXXVIIII", resultado);
        }
        [Test]
        public void Caso17()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(100);

            Assert.AreEqual("C", resultado);
        }
        [Test]
        public void Caso18()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(200);

            Assert.AreEqual("CC", resultado);
        }
        [Test]
        public void Caso19()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(300);

            Assert.AreEqual("CCC", resultado);
        }
        [Test]
        public void Caso20()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(400);

            Assert.AreEqual("CCCC", resultado);
        }
        [Test]
        public void Caso21()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(500);

            Assert.AreEqual("D", resultado);
        }
        [Test]
        public void Caso22()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(600);

            Assert.AreEqual("DC", resultado);
        }
        [Test]
        public void Caso23()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(700);

            Assert.AreEqual("DCC", resultado);
        }
        [Test]
        public void Caso24()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(800);

            Assert.AreEqual("DCCC", resultado);
        }
        [Test]
        public void Caso25()
        {
            var romano = new RomanoGenerator();
            var resultado = romano.GetRomano(1000);

            Assert.AreEqual("M", resultado);
        }
    }
}
