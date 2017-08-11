''''''''''''''''''''''''' 
'                       '
'<Danny Hilario Suarez/>'
'                       '
'''''''''''''''''''''''''


Imports System.Reflection
Imports System.Runtime.CompilerServices

Public Module ToDictionary

    <Extension()>
    Public Function ToDictionary(obj As DataTable) As Dictionary(Of String, List(Of String))
        Dim dic As New Dictionary(Of String, List(Of String))

        For Each col As DataColumn In obj.Columns
            Dim list As New List(Of String)
            For Each ro As DataRow In obj.Rows
                list.Add(ro(col).ToString)
            Next
            dic.Add(col.ColumnName, list)
        Next
        Return dic
    End Function

End Module
