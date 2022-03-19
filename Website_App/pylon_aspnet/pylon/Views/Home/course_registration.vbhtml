@Code
    ViewData("Title") = "course_registration"
    Layout = "~/Views/_LayoutPage3.vbhtml"
End Code

<div class="container-fluid py-4">
    <form action="" method="post" style="width: 100%;">

        <div style=" background-color: #043927; width: 80%; display: block; margin: 20% auto; padding: 15px 10px 10px 10px; text-align: center;">
            <label style="color: white; font-size: 25px;">
                Course Registeration:
                <label style="color: white;">Open Registeration</label>
                <input type="radio" name="open" value="Open Registeration">
                <label style="color: white;">Close Registeration</label>
                <input type="radio" name="close" value="Close Registeration">
        </div>
    </form>

</div>
  </main>

