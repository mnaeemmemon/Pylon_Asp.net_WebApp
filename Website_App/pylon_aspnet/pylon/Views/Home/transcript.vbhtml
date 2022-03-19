@Code
    ViewData("Title") = "transcript"
    Layout = "~/Views/_LayoutPage1.vbhtml"
End Code

<div class="container-fluid py-4">
    <div class="row">
        <div class="col-lg-12 col-md-10 mx-auto">
            <div class="card mt-4">
                <div style="background-color: #043927;" class="card-header p-3">
                    <h5 class="mb-0" style="color: white;">Marks</h5>
                </div>
                <div class="card-body p-3 pb-0">
                    <div class="alert alert-dismissible text-black">
                        <form action="" method="post" style="width: 100%;">
                            <!-- <div style="width: 80%; display: block; margin: 0% auto;">
                                <input type="submit" value="Search" style="background-color: rgb(70, 70, 70); color: white; font-size: 20px; padding: 10px 50px; border-radius: 10px;">
                                <input type="submit" value="Update" style="background-color: rgb(70, 70, 70); color:  white; font-size: 20px; padding: 10px 50px; border-radius: 10px; ">
                            </div> -->
                            <div style=" background-color: #043927; width: 80%; display: block; margin: auto; padding: 15px 10px 10px 10px; text-align: center;">
                                <label style="color: white; font-size: 25px;">
                                    Course:
                                    <input list="course" name="course" />
                                </label>
                                <datalist id="course">
                                    <option value="DLD">
                                    <option value="PF">
                                    <option value="AP">
                                </datalist>

                                <input type="submit" value="Search" style="background-color: rgb(70, 70, 70); color: white; font-size: 20px; padding: 5px 20px; border-radius: 10px;">

                            </div>
                        </form>

                        <table>
                            <tr>
                                <th>Category</th>
                                <th>Total Marks </th>
                                <th>Marks Obtained</th>

                            </tr>

                            <tr>
                                <th>Mid 01</th>
                                <td><input type="text" value="Marks" name="Marks">   </td>
                                <td><input type="text" value="Marks" name="Marks">   </td>

                            </tr>
                            <tr>
                                <th>Quiz 02</th>
                                <td><input type="text" value="Marks" name="Marks">   </td>
                                <td><input type="text" value="Marks" name="Marks">   </td>

                            </tr>
                            <tr>
                                <th>Assignment 02</th>
                                <td><input type="text" value="Marks" name="Marks">  </td>
                                <td><input type="text" value="Marks" name="Marks">   </td>

                            </tr>
                            <tr>
                                <th>Mid 02</th>
                                <td><input type="text" value="Marks" name="Marks">  </td>
                                <td><input type="text" value="Marks" name="Marks">   </td>

                            </tr>
                            <tr>
                                <th>Project</th>
                                <td><input type="text" value="Marks" name="Marks">   </td>
                                <td><input type="text" value="Marks" name="Marks">   </td>

                            </tr>
                            <tr>
                                <th>Final</th>
                                <td><input type="text" value="Marks" name="Marks">   </td>
                                <td><input type="text" value="Marks" name="Marks">   </td>

                            </tr>
                            <tr>
                                <th>Grand Total</th>
                                <td><input type="text" value="Marks" name="Marks">  </td>
                                <td><input type="text" value="Marks" name="Marks">   </td>

                            </tr>

                        </table>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
  </main>

