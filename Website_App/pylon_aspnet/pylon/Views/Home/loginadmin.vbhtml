@Code
    ViewData("Title") = "loginadmin"
    Layout = "~/Views/_Layoutindex.vbhtml"
End Code

<div style="width: 50%; border-radius: 15px; margin: 5% 25%;">
    <img style="margin: 10px auto 20px auto; display: block; border-radius: 10px;" src="~/img/admin.png" class="navbar-brand-img " width="25%" alt="main_logo">
    <h3 style="color: white; text-align: center;">LOGIN</h3>
    <form action="AdminLogin" method="post">
        <div style="border: solid 1px white; margin-bottom: 10px; border-radius: 10px;" class="input-group input-group-outline">
            <input name="id" style="padding: 10px; font-size: 20px; color: white;" placeholder="Enter ID" type="text" class="form-control">
        </div>
        <div style="border: solid 1px white; margin-bottom: 10px; border-radius: 10px;" class="input-group input-group-outline">
            <input name="password" style="padding: 10px; font-size: 20px; color: white;" placeholder="Enter Password" type="password" class="form-control">
        </div>
        <input style="border-radius: 10px; font-size: 20px; padding: 5px 20px; color: white; background-color: grey; margin: 5px auto; display: block;" name="loginstudent" type="submit" value="Sign in">
    </form>
</div>

