#Region "#ComparerImpl"
Imports System.Collections

Namespace CustomSortOrder

    Friend Class NumberComparer
        Implements IComparer

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            Dim iX As Integer = NumberConverter.ToInt(x)
            Dim iY As Integer = NumberConverter.ToInt(y)
            Return iX - iY
        End Function
    End Class

    Friend Class NumberConverter

        Public Shared Function ToInt(ByVal o As Object) As Integer
            Dim stringNumber As String = TryCast(o, String)
            Dim number As Integer = 0
            If Equals(stringNumber, Nothing) Then Return -1
            If Integer.TryParse(stringNumber, number) Then Return number
            Select Case stringNumber.ToLower()
                Case "one"
                    Return 1
                Case "two"
                    Return 2
                Case "three"
                    Return 3
            End Select

            Return number
        End Function
    End Class
End Namespace
#End Region  ' #ComparerImpl
