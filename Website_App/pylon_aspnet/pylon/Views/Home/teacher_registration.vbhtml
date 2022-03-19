@Code
    ViewData("Title") = "teacher_registration"
    Layout = "~/Views/_LayoutPage3.vbhtml"
End Code

<div class="container-fluid py-4">
    <form action="" method="post" style="width: 100%;">

        <div style=" background-color: #043927; width: 80%; display: block; margin: auto; padding: 15px 10px 10px 10px; text-align: center;">
            <label style="color: white; font-size: 25px;">
                Teacher Registeration
                <input type="submit" value="Register" style="background-color: white; color: black; font-size: 20px; padding: 5px 20px; border-radius: 10px;">

        </div>
    <div class="row">
        <div class="col-lg-12 col-md-10 mx-auto">
            <div class="card mt-4">
                <div style="background-color: #043927;" class="card-header p-3">
                    <h5 class="mb-0" style="color: white;">BIO</h5>
                </div>
                <div class="card-body p-3 pb-0">
                    
                    <div class="alert alert-dismissible text-black">
                        <table>
                            <tr>
                                <th>First Name</th>
                                <td><input type="text" name="firstName"></td>
                            </tr>
                            <tr>
                                <th>Last Name</th>
                                <td><input type="text" name="lastName"></td>
                            </tr>
                            <tr>
                                <th>Email</th>
                                <td><input type="text" name="emailAddress"></td>
                            </tr>
                            <tr>
                                <th>ID</th>
                                <td><input type="text" name="teacherID"></td>
                            </tr>
                            <tr>
                                <th>CNIC</th>
                                <td><input type="text" name="cnic"></td>
                            </tr>
                            <tr>
                                <th>DOB</th>
                                <td><input type=date" name="dob"></td>
                            </tr>
                            <tr>
                                <th>Contact No</th>
                                <td><input type="text" name="contactNo"></td>
                            </tr>
                            <tr>
                                <th>Home Address</th>
                                <td><input type="text" name="homeAddress"></td>
                            </tr>
                            <tr>
                                <th>Nationality</th>
                                <td><input type="text" name="nationality"></td>
                            </tr>
                            <tr>
                                <th>Qualification</th>
                                <td><input type="text" name="qualification"></td>
                            </tr>
                            <tr>
                                <th>Position</th>
                                <td><input type="text" name="position"></td>
                            </tr>
                            <tr>
                                <th>Campus</th>
                                <td><input type="text" name="campus"></td>
                            </tr>
                            <tr>
                                <th>Degree</th>
                                <td><input type="text" name="degree"></td>
                            </tr>
                            <tr>
                                <th>Password</th>
                                <td><input type="text" name="password"></td>
                            </tr>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</div>
  </main>

