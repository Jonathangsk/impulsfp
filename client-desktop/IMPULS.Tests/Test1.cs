using IMPULS_Desktop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IMPULS.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestValidarUsuario_Admin()
        {
            var form = new Form1();
            string tipus;

            bool resultat = form.ValidarUsuario("admin", "1234", out tipus);

            Assert.IsTrue(resultat, "L'usuari admin hauria de ser vàlid");
            Assert.AreEqual("admin", tipus, "El tipus d'usuari hauria de ser 'admin'");
        }

        [TestMethod]
        public void TestValidarUsuario_Incorrecto()
        {
            var form = new Form1();
            string tipus;

            bool resultat = form.ValidarUsuario("alumneX", "0000", out tipus);

            Assert.IsFalse(resultat, "L'usuari incorrecte no hauria de validar");
            Assert.AreEqual("", tipus, "El tipus hauria d'estar buit");
        }

        [TestMethod]
        public void TestValidarUsuario_Empresa()
        {
            var form = new Form1();
            string tipus;

            bool resultat = form.ValidarUsuario("empresa1", "1234", out tipus);

            Assert.IsTrue(resultat, "L'usuari empresa1 hauria de ser vàlid");
            Assert.AreEqual("empresa", tipus, "El tipus d'usuari hauria de ser 'empresa'");
        }
    }
}