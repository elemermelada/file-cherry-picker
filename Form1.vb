Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'basically put the desired root directory in "root", so its deleted from every file's path
        '"path" is the var to the json file containing the array of file paths
        '"files" is just that same array
        'files are saved inside of the same directory structure they were inside "root" but in the same folder as the program is executed

        Dim root As String = "C:\Users\elemer"
        Dim n As Integer = root.Length
        Dim path As String = "C:\Users\elemer\Desktop\save.json"
        Dim files As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(System.IO.File.ReadAllText(path))

        Dim newpath As String
        Dim newdir As String

        For Each file As String In files

            If Not System.IO.File.Exists(file) Then
                MsgBox("File " + file + "not found")
                Continue For
            End If

            newpath = file.Substring(n + 1)
            newdir = newpath.Substring(0, newpath.LastIndexOf("\"))
            'Me.Text = newdir
            System.IO.Directory.CreateDirectory(newdir)

            System.IO.File.Copy(file, newpath)

        Next

        Me.Close()

    End Sub
End Class
