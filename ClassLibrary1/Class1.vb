Public Class Class1
    Private Declare Function Totik Lib "xGatDll.DLL" (ByVal dest As Long, ByVal ndest As Long, ByVal inireg As Long, ByVal fireg As Long, ByVal buf As String, ByVal borrado As Long) As Long

    Private Declare Function opensocket Lib “xGatdll.DLL” (ByVal ipremota As String, ByVal portlocal As Long, ByVal portdesti As Long, ByVal ingredientes As Long) As Long
    'Função para a abertura da porta de comunicações.

    Private Declare Function closesocket Lib “xGatdll.DLL” () As Long
    'Função para o fecho da porta de comunicações.
End Class
