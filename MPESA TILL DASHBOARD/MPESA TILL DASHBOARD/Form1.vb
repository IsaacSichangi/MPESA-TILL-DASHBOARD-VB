Imports System
Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Public Class Form1

    Dim today As Date
    Dim month As String
    Dim day As String
    Dim year As String
    Dim strDate As String
    Dim yearMonth As String
    Dim curDate As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        today = Date.Today()

        strDate = today.ToString("dd MMM yyyy")
        yearMonth = today.ToString("yyyy-MM")
        day = today.ToString("dd")
        month = today.ToString("MMM")
        year = today.ToString("yyyy")
        curDate = today.ToString("yyy-MM-dd")



        Me.Text = "MPESA TILL DASHBOARD " + strDate
        accountbalance_title.Text = "TRANSACTION VALUE"
        dailyrevenue_title.Text = "DAILY REVENUE " + day + " " + month.ToUpper
        monthlyrevenue_title.Text = "MONTHLY REVENUE " + month.ToUpper + " " + year
        yearlyrevenue_title.Text = "YEARLY REVENUE " + year

        from_date.Format = DateTimePickerFormat.Custom
        from_date.CustomFormat = "yyyy-MM-dd"

        to_date.Format = DateTimePickerFormat.Custom
        to_date.CustomFormat = "yyyy-MM-dd"

        transactions_listview.Columns.Add("NAME", 180)
        transactions_listview.Columns.Add("AMOUNT", 100)
        transactions_listview.Columns.Add("PHONENUMBER", 100)
        transactions_listview.Columns.Add("TRANSACTION-NUMBER", 140)
        transactions_listview.Columns.Add("DATE", 70)
        transactions_listview.Columns.Add("DATETIME", 120)



        getTransactions("http://zorowtech.com/test.php", "refresh", "yes", "none", "none")

        



    End Sub


    Private Sub searchtransactions_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchtransactions_btn.Click



        getTransactions("http://zorowtech.com/test.php", "from", from_date.Text, "to", to_date.Text)


    End Sub

    Private Sub getTransactions(ByVal url As String, ByVal a As String, ByVal aValue As String, ByVal b As String, ByVal bValue As String)

      

        Try
            Dim request As WebRequest = WebRequest.Create(url)
            request.Method = "POST"
            Dim postData As String
            postData = a & "=" & aValue & "&" & b & "=" & bValue
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
            dataStream = response.GetResponseStream()
            Dim reader As New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            If responseFromServer.Contains("]") Then

                transactions_listview.Items.Clear()

                Dim jlist As JArray = JArray.Parse(responseFromServer)
                Dim name As String
                Dim firstname As String
                Dim middlename As String
                Dim lastname As String
                Dim amount As Single = 0
                Dim yearly_amount As Single = 0
                Dim monthly_amount As Single = 0
                Dim daily_amount As Single = 0
                Dim phonenumber As String
                Dim transaction_number As String
                Dim gotDate As String
                Dim gotDateTime As String
                Dim total As Single = 0

                Dim arr(6) As String
                Dim itm As ListViewItem
                Dim jb As JObject = Nothing
                For i As Integer = 0 To jlist.Count - 1
                    jb = JObject.Parse(jlist(i).ToString())
                    'Do what you want to take value from jb("Attribute1")
                    firstname = jb("FIRSTNAME")
                    middlename = jb("MIDDLENAME")
                    lastname = jb("LASTNAME")

                    name = firstname + " " + middlename + " " + lastname

                    amount = jb("AMOUNT")

                    total += amount

                    phonenumber = jb("SENDERPHONE")

                    transaction_number = jb("TRANSACTION_REFERENCE")

                    gotDate = jb("DATE")

                    If gotDate.Contains(year) Then

                        yearly_amount += amount

                    End If

                    If gotDate.Contains(yearMonth) Then

                        monthly_amount += amount
                    End If

                    If gotDate.Contains(curDate) Then

                        daily_amount += amount

                    End If

                    gotDateTime = jb("DATETIME")


                    arr(0) = name.ToUpper
                    arr(1) = amount
                    arr(2) = phonenumber
                    arr(3) = transaction_number
                    arr(4) = gotDate
                    arr(5) = gotDateTime

                    itm = New ListViewItem(arr)
                    transactions_listview.Items.Add(itm)


                Next





                yearlyrevenue.Text = "Ksh " + yearly_amount.ToString

                monthlyrevenue.Text = "Ksh " + monthly_amount.ToString

                dailyrevenue.Text = "Ksh " + daily_amount.ToString

                account_amount.Text = "Ksh " + total.ToString


            Else
                MsgBox(responseFromServer)


            End If
            reader.Close()
            dataStream.Close()
            response.Close()


        Catch msg As SystemException

            MsgBox(msg.Message)
        End Try




    End Sub

    Private Sub refresh_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refresh_btn.Click



        getTransactions("http://zorowtech.com/test.php", "refresh", "yes", "none", "none")





    End Sub

    Private Sub searchphonenumber_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchphonenumber_btn.Click
        Dim gotphonenumber As String
        Dim gotlength As Single

        gotphonenumber = phonenumber.Text

        gotlength = gotphonenumber.Length()


        If gotlength.Equals(13) Then



            getTransactions("http://zorowtech.com/test.php", "phonenumber", gotphonenumber, "none", "none")


        Else

            MsgBox("Input a valid phonenumber")

        End If












    End Sub
End Class
