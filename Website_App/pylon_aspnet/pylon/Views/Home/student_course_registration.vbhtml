@Code
    ViewData("Title") = "student_course_registration"
    Layout = "~/Views/_LayoutPage1.vbhtml"
End Code

<div class="container-fluid py-4">
    <div class="row">
        <div class="col-lg-12 col-md-10 mx-auto">
            <div class="card mt-4">
                <div style="background-color: #043927;" class="card-header p-3">
                    <h5 class="mb-0" style="color: white;">Course Registeration</h5>
                </div>
                <div class="card-body p-3 pb-0">
                    <div class="alert alert-dismissible text-black">
                        <form action="" method="post" style="width: 100%;">

                            <div style=" background-color: yellow; width: 80%; display: block; margin: 3% auto; padding: 15px 10px 10px 10px; text-align: center;">
                                <label style="color: black; font-size: 25px;"><b>Registeration is Open</b>  <input type="submit" value="Register" style="background-color: rgb(70, 70, 70); color: white; font-size: 20px; padding: 5px 20px; border-radius: 10px;">


                            </div>
                        </form>
                        <table>

                            <tr>
                                <th>Register</th>
                                <th>S.No. </th>
                                <th>Course Name</th>
                                <th>Course Code</th>
                                <th>Course Credit Hours</th>
                            </tr>

                            <tr>
                                <td><input type="checkbox" name="register"></td>
                                <td>1</td>  
                                <td>DLD</td>
                                <td>CS1023</td>
                                <td>3</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" name="register"></td>
                                <td>2</td>
                                <td>PF</td>
                                <td>CS1342</td>
                                <td>3</td>
                            </tr>
                            <tr>
                                <td><input type="checkbox" name="register"></td>
                                <td>3</td>
                                <td>Calculus</td>
                                <td>CS2345</td>
                                <td>3</td>
                            </tr>

                        </table>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
  </main>


