Module Global_Attributes
    ' This variable to be set
    Public banking_username As String = "admin"
    Public banking_recv_username As String = ""
    Public banking_recv_name As String = ""
    Public Go_Back_Form As Form
    Public Go_Back As Short = 0
    Public banking_payment_amount As Double = 0
    Public banking_payment_done As Double = 0

    Public HistoryItem As HistoryItem

    'Public slqConnection_banking As String = "server=localhost;userid=root;password=Aasneh18;database=bankingdatabase;"
    Public slqConnection_banking As String = GlobalConnString.str
    'Public slqConnection_newsletter As String = "server=localhost;userid=root;password=Aasneh18;database=newsdatabase;"
    Public slqConnection_newsletter As String = GlobalConnString.str
    'Public slqConnection_email As String = "server=localhost;userid=root;password=Aasneh18;database=emaildatabase;"
    Public slqConnection_email As String = GlobalConnString.str
End Module
