﻿@Code
    ViewData("Title") = "attendence_student"
    Layout = "~/Views/_LayoutPage1.vbhtml"
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

                            <div style=" background-color: #043927; width: 80%; display: block; margin: auto; padding: 15px 10px 10px 10px; text-align: center;">
                                <label style="color: white; font-size: 25px;">
                                    Course:
                                    <input list="course" name="course" />
                                </label>
                                <datalist id="course">
                                    <option value="PF">
                                    <option value="PF-Lab">
                                    <option value="Islamiyat">
                                    <option value="AP">
                                    <option value="English">
                                </datalist>

                                <input type="submit" value="Search" style="background-color: rgb(70, 70, 70); color: white; font-size: 20px; padding: 5px 20px; border-radius: 10px;">

                            </div>
                        </form>
                        <table>

                            <tr>
                                <th>January / 01 / 19</th>
                                <td>Present</td>
                            </tr>
                            

                        </table>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
  </main>

