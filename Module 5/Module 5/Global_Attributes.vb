Module Global_Attributes
    ' This variable to be set
    Public banking_username As String = "admin"
    Public banking_recv_username As String = ""
    Public Go_Back_Form As Form
    Public Go_Back As Short = 0
    Public banking_payment_amount As Double = 0

    Public slqConnection_banking As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
    'Public slqConnection_banking As String = "server=172.16.114.244;userid=admin;Password=nimda;database=banking_database;sslmode=none;"
    Public slqConnection_newsletter As String = "server=localhost;userid=root;password=Aasneh18;database=newsdatabase;"
    'Public slqConnection_newsletter As String = "server=172.16.114.244;userid=admin;Password=nimda;database=newsdatabase;sslmode=none;"
    Public slqConnection_email As String = "server=localhost;userid=root;password=Aasneh18;database=emaildatabase;"
    'Public slqConnection_email As String = "server=172.16.114.244;userid=admin;Password=nimda;database=emaildatabase;sslmode=none;"
End Module
