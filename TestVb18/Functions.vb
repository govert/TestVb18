Imports ExcelDna.Integration

Public Module Functions
    <ExcelFunction("Adds two numbers")>
    Public Function AddThem(a As Integer, b As Integer) As Integer
        Return a + b
    End Function

End Module
