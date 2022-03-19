@Code
    ViewData("Title") = "attendence_teacher"
    Layout = "~/Views/_LayoutPage2.vbhtml"
End Code

<div class="container-fluid py-4">
    <div class="row">
        <div class="col-lg-12 col-md-10 mx-auto">
            <div class="card mt-4">
                <div style="background-color: #043927;" class="card-header p-3">
                    <h5 class="mb-0" style="color: white;">Attendence</h5>
                </div>
                <div class="card-body p-3 pb-0">
                    <div class="alert alert-dismissible text-black">
                        <form action="" method="post" style="width: 100%;">
                            <div style="width: 80%; display: block; margin: 0% auto;">
                                <input type="submit" value="Create" style="background-color: rgb(70, 70, 70); color: white; font-size: 20px; padding: 10px 50px; border-radius: 10px;">
                                <input type="submit" value="Search" style="background-color: rgb(70, 70, 70); color:  white; font-size: 20px; padding: 10px 50px; border-radius: 10px; ">
                                <input type="submit" value="Add" style="background-color: rgb(70, 70, 70); color: white; font-size: 20px; padding: 10px 50px; border-radius: 10px;">
                                <input type="button" value="Update" style="background-color: rgb(70, 70, 70); color:  white; font-size: 20px; padding: 10px 50px; border-radius: 10px; ">
                            </div>
                            <div style=" background-color: #043927; width: 80%; display: block; margin: 3% auto; padding: 15px 10px 10px 10px;">
                                <label style="color: white; font-size: 15px;">
                                    Month:
                                    <input list="month" name="month" />
                                </label>
                                <datalist id="month">
                                    <option value="January">
                                    <option value="February">
                                    <option value="March">
                                </datalist>
                                <label style="color: white; font-size: 15px;">
                                    Date:
                                    <input list="date" name="date" />
                                </label>
                                <datalist id="date">
                                    <option value="January 10">
                                    <option value="January 20">
                                    <option value="January 30">
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
                                    <option value="AP">
                                </datalist>
                            </div>
                        </form>
                        <table>

                            <tr>
                                <th>Umer</th>
                                <td><input type="text" value="P" name="Attendence"></td>
                            </tr>

                        </table>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
  </main>

