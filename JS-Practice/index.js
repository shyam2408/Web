function validate()
{
    var username = document.getElementById("uname").value;
    regx=/^([a-z A-Z 0-9 \.-]+)@([a-z A-Z 0-9 \.-]+).([a-z]{2,10})$/;
    if (regx.test(username)) {
        document.getElementById("show").style.visibility="visible";
        document.getElementById("show").style.color="green";
        document.getElementById('show').innerHTML="valid"
    }
    else {
        document.getElementById("show").style.visibility = "visible";
    }
}