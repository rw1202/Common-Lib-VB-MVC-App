Public Class CommonBase
    Public Property IsActive As Boolean
    Public Property ModifiedDate As DateTime
    Public Property CreatedBy As String 


    Protected Overridable Function GetClassData() As String
        Dim data As New Text.StringBuilder(1024)

        data.AppendLine("Is Active: " + IsActive.ToString())
        data.AppendLine("Modified Date: " + ModifiedDate.ToLongDateString())
        data.AppendLine("Created By: " + CreatedBy.ToString())
        Return data.ToString()
    End Function

    Public Overrides Function ToString() As String
        Return GetClassData()
    End Function

    Sub New ()
        IsActive= True
        ModifiedDate= DateTime.Now
        CreatedBy= Environment.UserName
    End Sub
End Class
