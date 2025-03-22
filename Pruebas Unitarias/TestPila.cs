namespace Pruebas_Unitarias;

[TestClass]
public class StackTests
{
    // Pruebas para ArrayStack
    [TestMethod]
    public void ArrayStack_Push_ShouldAddElement()
    {
        ArrayStack stack = new ArrayStack(3);
        stack.Push(1);
        Assert.AreEqual(1, stack.Top());
    }

    [TestMethod]
    public void ArrayStack_Pop_ShouldRemoveAndReturnElement()
    {
        ArrayStack stack = new ArrayStack(3);
        stack.Push(1);
        stack.Push(2);
        Assert.AreEqual(2, stack.Pop());
        Assert.AreEqual(1, stack.Top());
    }

    [TestMethod]
    public void ArrayStack_Top_ShouldReturnTopElement()
    {
        ArrayStack stack = new ArrayStack(3);
        stack.Push(1);
        stack.Push(2);
        Assert.AreEqual(2, stack.Top());
    }

    [TestMethod]
    public void ArrayStack_Pop_ShouldHandleUnderflow()
    {
        ArrayStack stack = new ArrayStack(3);
        Assert.AreEqual(-1, stack.Pop());
    }

    [TestMethod]
    public void ArrayStack_Top_ShouldHandleUnderflow()
    {
        ArrayStack stack = new ArrayStack(3);
        Assert.AreEqual(-1, stack.Top());
    }

    [TestMethod]
    public void ArrayStack_Push_ShouldHandleOverflow()
    {
        ArrayStack stack = new ArrayStack(2);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3); // Esto debería imprimir "Stack Overflow" en la consola.
        Assert.AreEqual(2, stack.Top());
    }

    // Pruebas para LinkedListStack
    [TestMethod]
    public void LinkedListStack_Push_ShouldAddElement()
    {
        LinkedListStack stack = new LinkedListStack();
        stack.Push(1);
        Assert.AreEqual(1, stack.Top());
    }

    [TestMethod]
    public void LinkedListStack_Pop_ShouldRemoveAndReturnElement()
    {
        LinkedListStack stack = new LinkedListStack();
        stack.Push(1);
        stack.Push(2);
        Assert.AreEqual(2, stack.Pop());
        Assert.AreEqual(1, stack.Top());
    }

    [TestMethod]
    public void LinkedListStack_Top_ShouldReturnTopElement()
    {
        LinkedListStack stack = new LinkedListStack();
        stack.Push(1);
        stack.Push(2);
        Assert.AreEqual(2, stack.Top());
    }

    [TestMethod]
    public void LinkedListStack_Pop_ShouldHandleUnderflow()
    {
        LinkedListStack stack = new LinkedListStack();
        Assert.AreEqual(-1, stack.Pop());
    }

    [TestMethod]
    public void LinkedListStack_Top_ShouldHandleUnderflow()
    {
        LinkedListStack stack = new LinkedListStack();
        Assert.AreEqual(-1, stack.Top());
    }
}
