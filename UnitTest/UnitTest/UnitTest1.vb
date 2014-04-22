Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()
        Dim c1 As VB6_1.CClass

        c1 = New VB6_1.CClass
        Assert.AreEqual(42, c1.return42)
    End Sub

End Class