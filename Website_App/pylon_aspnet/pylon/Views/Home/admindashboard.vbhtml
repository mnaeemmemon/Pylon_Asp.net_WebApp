@Code
    ViewData("Title") = "admindashboard"
    Layout = "~/Views/_LayoutPage3.vbhtml"
End Code

<div class="container-fluid py-4">
    <form action="" method="post" style="width: 100%;">

        <div style=" background-color: #043927; width: 80%; display: block; margin: auto; padding: 15px 10px 10px 10px; text-align: center;">
            <label style="color: white; font-size: 25px;">
                Course:
                <input list="course" name="course" />
            </label>
            <datalist id="course">
                <option value="DLD">
                <option value="PF">
                <option value="PF-Lab">
                <option value="AP">
            </datalist>

            <input type="submit" value="Search" style="background-color: rgb(70, 70, 70); color: white; font-size: 20px; padding: 5px 20px; border-radius: 10px;">

        </div>
    </form>
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
                                <th>Semester</th>
                                <th>Course Name</th>
                                <th>Course Code</th>
                                <th>Credit Hour</th>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>DLD</td>
                                <td>CS102</td>
                                <td>4</td>
                            </tr>
                            
                            <tr>
                                <td>4</td>
                                <td>OOP</td>
                                <td>CS106</td>
                                <td>3</td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>DLD-Lab</td>
                                <td>CL102</td>
                                <td>1</td>
                            </tr>

                        </table>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
  </main>

