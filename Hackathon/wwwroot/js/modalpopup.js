//On Clicking the new user hyperlink
$("#newuserhref").click(function () {
    
    //User Name
    $("#lblUserNumber").show()
    $("#usr").show();
    //Password
    $("#lblPassword").show();
    $("#pwd").show();
    //Confirm Password
    $("#lblConfirmpassword").show();
    $("#confirmpwd").show();

    //Hiding the New User Hyper Link
    $("#newuserhref").hide();
    //Showing the exisiting user Hyperlink
    $("#existinguserhref").show();
    
    //Changing the text of submit button
    $("#btnRegister").show();
    $("#btnLogin").hide();
    document.getElementById("registermsg").style = "display:none;"

    document.getElementById("UserNameRequired").style = "display:none;"
    document.getElementById("PasswordRequired").style = "display:none;"
    document.getElementById("ConfirmPasswordSame").style = "display:none;"
});

//On Clicking the exsiting user hyperlink
$("#existinguserhref").click(function () {
    

    $("#lblConfirmpassword").hide();
    $("#confirmpwd").hide();

    //Showing User Name and Password
    $("#lblUserNumber").show()
    $("#usr").show();

    $("#lblPassword").show();
    $("#pwd").show();

    //Showing the New User Hyper Link
    $("#newuserhref").show();
    //Hide the exisiting user Hyperlink
    $("#existinguserhref").hide();

    //Changing the text of submit button
    
    $("#btnRegister").hide();
    $("#btnLogin").show();
    document.getElementById("registermsg").style = "display:none;"
    document.getElementById("UserNameRequired").style = "display:none;"
    document.getElementById("PasswordRequired").style = "display:none;"
    document.getElementById("ConfirmPasswordSame").style = "display:none;"


});

$("#modalclosed").click(function () {
    document.getElementById("registermsg").style = "display:none;"
    document.getElementById("UserNameRequired").style = "display:none;"
    document.getElementById("PasswordRequired").style = "display:none;"
    document.getElementById("ConfirmPasswordSame").style = "display:none;"

});



  



