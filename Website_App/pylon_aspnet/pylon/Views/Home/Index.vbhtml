@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/_Layoutindex.vbhtml"
End Code

<div style="width: 50%; border-radius: 15px; margin: 10% 25%;">
    <img style="margin: 10px auto 20px auto; display: block; border-radius: 10px;" src="~/img/logo2.png" class="navbar-brand-img " width="50%" alt="main_logo">
    <a style="text-align: center; border-radius: 15px; margin-bottom: 10px; padding: 10px; font-size: 20px; background-color: rgb(70, 70, 70)" class="nav-link text-white active shadow-success" href=@Url.Action("loginstudent")>
        <span class="nav-link-text ms-1">Login as a Student</span>
    </a>
    <a style="text-align: center; border-radius: 15px; margin-bottom: 10px; padding: 10px; font-size: 20px; background-color: rgb(70, 70, 70) " class="nav-link text-white active shadow-success" href=@Url.Action("loginteacher")>
        <span class="nav-link-text ms-1">Login as a Teacher</span>
    </a>
    <a style="text-align: center; border-radius: 15px; margin-bottom: 10px; padding: 10px; font-size: 20px; background-color: rgb(70, 70, 70) " class="nav-link text-white active shadow-success" href=@Url.Action("loginadmin")>
        <span class="nav-link-text ms-1">Login as a Admin</span>
    </a>
</div>



