@Code
    ViewData("Title") = "marks_teacher"
    Layout = "~/Views/_LayoutPage2.vbhtml"
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
                            <div style="width: 80%; display: block; margin: 0% auto;">
                                <input type="submit" value="Search" style="background-color: rgb(70, 70, 70); color: white; font-size: 20px; padding: 10px 50px; border-radius: 10px;">
                                <input type="button" value="Update" style="background-color: rgb(70, 70, 70); color:  white; font-size: 20px; padding: 10px 50px; border-radius: 10px; ">
                            </div>
                            <div style=" background-color: #043927; width: 80%; display: block; margin: 3% auto; padding: 15px 10px 10px 10px;">
                                <label style="color: white; font-size: 15px;">
                                    Category:
                                    <input list="category" name="category" />
                                </label>
                                <datalist id="category">
                                    <option value="MID1">
                                    <option value="Assignment1">
                                    <option value="Quiz1">
                                    <option value="MID2">
                                    <option value="Assignment2">
                                    <option value="Quiz2">
                                    <option value="MID3">
                                    <option value="Assignment3">
                                    <option value="Quiz3">
                                </datalist>
                                <label style="color: white; font-size: 15px;">
                                    Section:
                                    <input list="section" name="section" />
                                </label>
                                <datalist id="section">
                                    <option value="A">
                                    <option value="B">
                                    <option value="C">
                                </datalist>
                                <label style="color: white; font-size: 15px;">
                                    Course:
                                    <input list="course" name="course" />
                                </label>
                                <datalist id="course">
                                    <option value="DLD">
                                    <option value="PF">
                                    <option value="PF-Lab">
                                    <option value="AP">
                                </datalist>
                            </div>
                        </form>
                        <table>

                            <tr>
                                <th>Umer</th>
                                <td><input type="text" value="10" name="marks"></td>
                            </tr>

                        </table>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
  </main>

