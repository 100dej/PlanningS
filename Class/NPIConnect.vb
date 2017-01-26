Imports System.Net
Module NPIConnect
    Public Uname As String = Environ("UserName")
    Public hostname As String = Dns.GetHostName()
    Public ipaddress As String = CType(Dns.GetHostByName(hostname).AddressList.GetValue(0), IPAddress).ToString

    Public CBIT60a As String = "Provider=SQLOLEDB;Server=172.20.76.29;Integrated Security=SSPI;Database=MISDB"
    Public CBIT60 As String = "Provider=SQLOLEDB;Server=172.20.76.29;UID=MISDB02;PWD=MISDB02RY;Database=MISDB"
    Public NPIRYSV62FootBall As String = "Provider=SQLOLEDB;Server=172.31.195.13;UID=sa;PWD=sqlrayong;Database=DBFootBallNPI"
    Public NPIRYSV62DWH As String = "Provider=SQLOLEDB;Server=172.31.195.13;UID=sa;PWD=sqlrayong;Database=DBWMS"
    Public NPIRYSV62PlanningS As String = "Provider=SQLOLEDB;Server=172.31.195.13;UID=sa;PWD=sqlrayong;Database=PlanningS"
    Public NPIRYSV62PlanningSa As String = "Provider=SQLOLEDB;Server=172.31.195.13;Integrated Security=SSPI;Database=PlanningS"
    Public LocalMe As String = "Provider=SQLOLEDB;Server=NPIR-08101-1107;UID=SA;PWD=passcon;Database=MISDB"
    Public NPIRYSqlConnection As String = "Server=172.31.195.13;Database=PlanningS;User Id=sa;Password=sqlrayong"
    Public Consoh As String = "Provider=SQLOLEDB;Server=172.18.8.188;UID=sa;PWD=Npicons2k12;Database=npiconsohpd"
    Public TBTest As String = "Provider=SQLOLEDB;Server=npiry-sv62;uid=sa;pwd=sqlrayong;Database=TBTest"
    Public Prefsuit As String = "Provider=SQLOLEDB;Server=172.18.8.84;Database=CO_NPI;UID=pongdejr;PWD=Nawa01"
    Public AccountBS As String = "Provider=SQLOLEDB;Server=172.30.171.12;UID=sa;PWD=Npisql2k8r2;Database=ACCDB"

End Module
