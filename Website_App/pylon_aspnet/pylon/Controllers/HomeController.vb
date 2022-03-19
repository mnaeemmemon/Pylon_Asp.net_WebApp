Imports System.Web.Mvc
Imports System.Data.SqlClient
Imports pylon.Models


Namespace Controllers
    Public Class HomeController
        Inherits Controller

        Dim ConnectionString As String
        Dim con As SqlConnection
        Dim com As SqlCommand
        Dim dr As SqlDataReader
        Dim query As String


        ' GET: Home

        Function Index() As ActionResult
            Return View()
        End Function

        Function connectdb()
            ConnectionString = "Data Source=localhost\SQLEXPRESS; Initial Catalog=IPT_Project; Integrated Security = SSPI;"
            con = New SqlConnection(ConnectionString)

        End Function

        Function loginadmin() As ActionResult
            Return View()
        End Function

        Function AdminLogin(us As Users) As ActionResult
            connectdb()
            con.Open()
            query = "Select * from Users where id='" + us.id + "' and password='" + us.password + "'"
            com = New SqlCommand(query, con)
            dr = com.ExecuteReader()
            If (dr.Read()) Then
                Return View("admindashboard")
            Else
                Return View("loginadmin")
            End If
            dr.Close()
            com.Dispose()
            con.Close()
        End Function


        Function loginteacher() As ActionResult
            Return View()
        End Function

        Function TeacherLogin(t As Teacher) As ActionResult
            connectdb()
            con.Open()
            query = "Select * from Teacher where teacherID='" + t.teacherID + "' and password='" + t.password + "'"
            com = New SqlCommand(query, con)
            dr = com.ExecuteReader()
            If (dr.Read()) Then
                Return View("teacher_dashboard")
            Else
                Return View("loginteacher")
            End If
            dr.Close()
            com.Dispose()
            con.Close()
        End Function

        Function loginstudent() As ActionResult
            Return View()
        End Function

        Function StudentLogin(s As Student) As ActionResult
            connectdb()
            con.Open()
            query = "Select * from Student where email='" + s.email + "' and passWord='" + s.password + "'"
            com = New SqlCommand(query, con)
            dr = com.ExecuteReader()
            If (dr.Read()) Then
                Return View("student_dashboard")
            Else
                Return View("loginstudent")
            End If
            dr.Close()
            com.Dispose()
            con.Close()
        End Function

        Function admindashboard() As ActionResult
            Return View()
        End Function

        Function attendence_student() As ActionResult
            Return View()
        End Function

        Function attendence_teacher() As ActionResult
            Return View()
        End Function

        Function course_registration() As ActionResult
            Return View()
        End Function

        Function marks_student() As ActionResult
            Return View()
        End Function

        Function marks_teacher() As ActionResult
            Return View()
        End Function

        Function semester_freeze() As ActionResult
            Return View()
        End Function

        Function student_dashboard() As ActionResult
            Return View()
        End Function

        Function student_registration() As ActionResult
            Return View()
        End Function

        Function student_course_registration() As ActionResult
            Return View()
        End Function

        Function teacher_dashboard() As ActionResult
            Return View()
        End Function

        Function teacher_registration() As ActionResult
            Return View()
        End Function

        Function TeacherRegister(t As Teacher) As ActionResult
            connectdb()
            con.Open()
            query = "insert into Teacher(firstName, lastName, emailAddress, teacherID, cnic, dob, contactNo, homeAddress, nationality, qualification, position, degree, campus, password) VALUES ('" + t.firstName + "', '" + t.lastName + "', '" + t.emailAddress + "', '" + t.teacherID + "', '" + t.cnic + "', '" + Int32.Parse(t.dob) + "', '" + t.contactNo + "', '" + t.homeAddress + "', '" + t.nationality + "',' " + t.qualification + "', '" + t.position + "', '" + t.degree + "', '" + t.campus + "', '" + t.password + "');"
            com = New SqlCommand(query, con)
            dr = com.ExecuteReader()
            If (dr.Read()) Then
                Return View("admindashboard")
            Else
                Return View("teacher_registration")
            End If
            dr.Close()
            com.Dispose()
            con.Close()
        End Function

        Function transcript() As ActionResult
            Return View()
        End Function

    End Class
End Namespace