using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ColaSimpleTests
{
    [TestMethod]
    public void TestAgregarYVerPrimero()
    {
        var cola = new ColaSimple(3);
        cola.Agregar(1);
        cola.Agregar(2);

        Assert.AreEqual(1, cola.VerPrimero());
    }

    [TestMethod]
    public void TestEliminar()
    {
        var cola = new ColaSimple(3);
        cola.Agregar(1);
        cola.Agregar(2);

        int eliminado = cola.Eliminar();

        Assert.AreEqual(1, eliminado);
        Assert.AreEqual(2, cola.VerPrimero());
    }

    [TestMethod]
    public void TestEliminarUltimoElemento()
    {
        var cola = new ColaSimple(3);
        cola.Agregar(1);
        cola.Agregar(2);
        cola.Agregar(3);

        cola.Eliminar();
        cola.Eliminar();
        int eliminado = cola.Eliminar();

        Assert.AreEqual(3, eliminado);
        Assert.AreEqual(-1, cola.VerPrimero());
    }

    [TestMethod]
    public void TestDesbordamiento()
    {
        var cola = new ColaSimple(2);
        cola.Agregar(1);
        cola.Agregar(2);

        cola.Agregar(3);

        Assert.AreEqual(1, cola.VerPrimero());
    }

    [TestMethod]
    public void TestSubdesbordamiento()
    {
        var cola = new ColaSimple(3);

        int eliminado = cola.Eliminar();

        Assert.AreEqual(-1, eliminado);
    }

    [TestMethod]
    public void TestVerPrimeroConColaVacia()
    {
        var cola = new ColaSimple(3);

        int primero = cola.VerPrimero();

        Assert.AreEqual(-1, primero);
    }
}

[TestClass]
public class ColaCircularTests
{
    [TestMethod]
    public void TestAgregarYVerPrimeroCircular()
    {
        var cola = new ColaCircular(3);
        cola.Agregar(1);
        cola.Agregar(2);

        Assert.AreEqual(1, cola.VerPrimero());
    }

    [TestMethod]
    public void TestEliminarCircular()
    {
        var cola = new ColaCircular(3);
        cola.Agregar(1);
        cola.Agregar(2);

        int eliminado = cola.Eliminar();

        Assert.AreEqual(1, eliminado);
        Assert.AreEqual(2, cola.VerPrimero());
    }

    [TestMethod]
    public void TestEliminarUltimoElementoCircular()
    {
        var cola = new ColaCircular(3);
        cola.Agregar(1);
        cola.Agregar(2);
        cola.Agregar(3);

        cola.Eliminar();
        cola.Eliminar();
        int eliminado = cola.Eliminar();

        Assert.AreEqual(3, eliminado);
        Assert.AreEqual(-1, cola.VerPrimero());
    }

    [TestMethod]
    public void TestDesbordamientoCircular()
    {
        var cola = new ColaCircular(2);
        cola.Agregar(1);
        cola.Agregar(2);

        cola.Agregar(3);

        Assert.AreEqual(1, cola.VerPrimero());
    }

    [TestMethod]
    public void TestSubdesbordamientoCircular()
    {
        var cola = new ColaCircular(3);

        int eliminado = cola.Eliminar();

        Assert.AreEqual(-1, eliminado);
    }

    [TestMethod]
    public void TestCircularidad()
    {
        var cola = new ColaCircular(3);
        cola.Agregar(1);
        cola.Agregar(2);
        cola.Eliminar();
        cola.Agregar(3);
        cola.Agregar(4);

        Assert.AreEqual(2, cola.VerPrimero());
    }

    [TestMethod]
    public void TestAgregarConColaLlenaCircular()
    {
        var cola = new ColaCircular(3);
        cola.Agregar(1);
        cola.Agregar(2);
        cola.Agregar(3);

        cola.Agregar(4);

        Assert.AreEqual(1, cola.VerPrimero());
    }

    [TestMethod]
    public void TestVerPrimeroConColaVaciaCircular()
    {
        var cola = new ColaCircular(3);

        int primero = cola.VerPrimero();

        Assert.AreEqual(-1, primero);
    }
}



