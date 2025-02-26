document.getElementById("permanentcheckbox").addEventListener("change", function () {
    let presentaddress = document.getElementById("presentaddress");
    let permanentaddress = document.getElementById("permanentaddress");
    let presentpincode = document.getElementById("presentpincode");
    let permanentpincode = document.getElementById("permanentpincode");
    let presentstate = document.getElementById("presentstate");
    let permanentstate = document.getElementById("permanentstate");
    if (this.checked) {permanentaddress.value = presentaddress.value.trim();
        permanentpincode.value = presentpincode.value.trim();
        permanentstate.value = presentstate.value.trim();
        document.getElementById("permanentaddress").disabled = true;
        document.getElementById("permanentpincode").disabled = true;
        document.getElementById("permanentstate").disabled = true;}
    else {permanentaddress = "";
        permanentpincode = "";
        permanentstate = "";
        document.getElementById("permanentaddress").disabled = false;
        document.getElementById("permanentpincode").disabled = false;
        document.getElementById("permanentstate").disabled = false;}})
function validateName() {
    let firstname = document.getElementById("firstname").value.trim();
    if (firstname == "") {document.getElementById("firstnameerror").innerText = "Firstname is required";
        document.getElementById("firstname").style.border = "2px solid red";
        isValid = false;}
    else if (firstname != "" && !/^[A-Za-z]+$/.test(firstname)) {document.getElementById("firstnameerror").innerText = "Firstname name must contain only letters";
        document.getElementById("firstname").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("firstnameerror").innerText = "";
        document.getElementById("firstname").style.border = "";}}
function validatelastName() {
    let lastname = document.getElementById("lastname").value.trim();
    if (lastname == "") {document.getElementById("lastnameerror").innerText = "Lastname is required";
        document.getElementById("lastname").style.border = "2px solid red";
        isValid = false;}
    else if (lastname != "" && !/^[A-Za-z]+$/.test(lastname)) {document.getElementById("lastnameerror").innerText = "lastname name must contain only letters";
        document.getElementById("lastname").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("lastnameerror").innerText = "";
        document.getElementById("lastname").style.border = "";}}
function validateEmail() {
    let email = document.getElementById("email").value.trim();
    if (email == "") {document.getElementById("emailerror").innerText = "Email is required";
        document.getElementById("email").style.border = "2px solid red";
        isValid = false;}
    else if (email != "" && !/^\S+@\S+\.+\S/.test(email)) {document.getElementById("emailerror").innerText = "enter a valid email id";
        document.getElementById("email").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("emailerror").innerText = "";
        document.getElementById("email").style.border = "";}}
function validatePhone() {let phone = document.getElementById("phone").value.trim();
    if (phone == "") {document.getElementById("phoneerror").innerText = "phone is required";
        document.getElementById("phone").style.border = "2px solid red";
        isValid = false;}
    else if (phone != "" && !/^[\d]{10}$/.test(phone)) { document.getElementById("phoneerror").innerText = "enter a valid phone";
        document.getElementById("phone").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("phoneerror").innerText = "";
        document.getElementById("phone").style.border = "";}}
function validatePassword() {
    let password = document.getElementById("password").value.trim();
    if (password == "") {document.getElementById("passworderror").innerText = "password is required";
        document.getElementById("password").style.border = "2px solid red";
        isValid = false;}
    else if (password != "" && !/^[\S+\d]+$/.test(password)) {document.getElementById("passworderror").innerText = "enter a valid password";
        document.getElementById("password").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("passworderror").innerText = "";
        document.getElementById("password").style.border = "";}}
function validateConfirmPassword() {
    let password = document.getElementById("password").value.trim();
    let confirmpassword = document.getElementById("confirmpassword").value.trim();
    if (confirmpassword == "") {document.getElementById("confirmpassworderror").innerText = "Confirm password is required";
        document.getElementById("confirmpassword").style.border = "2px solid red";
        isValid = false;}
    else if (confirmpassword != "" && !/^[\S+\d]+$/.test(confirmpassword)) {document.getElementById("confirmpassworderror").innerText = "enter a valid Confirm password";
        document.getElementById("confirmpassword").style.border = "2px solid red";
        isValid = false;}
    else if (confirmpassword !== password) {document.getElementById("confirmpassworderror").innerText = "Confirm password be same as password";
        document.getElementById("confirmpassword").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("confirmpassworderror").innerText = "";
        document.getElementById("confirmpassword").style.border = "";}}
function validateGender() {let gender = document.getElementsByName("gender");
    let gendervalue = "";
    gender.forEach((gen) => {if (gen.checked) {gendervalue = gen.value;}})
    if (gendervalue == "") {document.getElementById("gendererror").innerText = "gender is required";
        isValid = false;}
    else {document.getElementById("gendererror").innerText = "";}}
function validatePresentaddress() {
    let presentaddress = document.getElementById("presentaddress").value.trim();
    if (presentaddress == "") {document.getElementById("presentaddresserror").innerText = "present address is required";
        document.getElementById("presentaddress").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("presentaddresserror").innerText = "";
        document.getElementById("presentaddress").style.border = "";}}
function validpermanentaddress() {let permanentaddress = document.getElementById("permanentaddress").value.trim();
    if (permanentaddress == "") {document.getElementById("permanentaddresserror").innerText = "permanent address is required";
        document.getElementById("permanentaddress").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("permanentaddresserror").innerText = "";
        document.getElementById("permanentaddress").style.border = "";}}
function validatePresentPin() {
    let presentpincode = document.getElementById("presentpincode").value.trim();
    if (presentpincode == "") { document.getElementById("presentpincodeerror").innerText = "present pincode is required";
        document.getElementById("presentpincode").style.border = "2px solid red";
        isValid = false;}
    else if (presentpincode != "" && !/^[\d]{6}$/.test(presentpincode)) {document.getElementById("presentpincodeerror").innerText = "enter a valid pincode";
        document.getElementById("presentpincode").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("presentpincodeerror").innerText = "";
        document.getElementById("presentpincode").style.border = "";}}
function validatePermanentPin() {
    let permanentpincode = document.getElementById("permanentpincode").value.trim();
    if (permanentpincode == "") {
        document.getElementById("permanentpincodeerror").innerText = "permanent pincode is required";
        document.getElementById("permanentpincode").style.border = "2px solid red";
        isValid = false;}
    else if (permanentpincode != "" && !/^[\d]{6}$/.test(permanentpincode)) {document.getElementById("permanentpincodeerror").innerText = "enter a valid pincode";
        document.getElementById("permanentpincode").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("permanentpincodeerror").innerText = "";
        document.getElementById("permanentpincode").style.border = "";}}
function validatePresenstate() {
    let presentstate = document.getElementById("presentstate").value.trim();
    if (presentstate == "") {document.getElementById("presentstateerror").innerText = "present state is required";
        document.getElementById("presentstate").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("presentstateerror").innerText = "";
        document.getElementById("presentstate").style.border = "";}}
function validatePermanentstate() {
    let permanentstate = document.getElementById("permanentstate").value.trim();
    if (permanentstate == "") { document.getElementById("permanentstateerror").innerText = "permanent state is required";
        document.getElementById("permanentstate").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("permanentstateerror").innerText = "";
        document.getElementById("permanentstate").style.border = "";}}
function validatedob() {
    let dob = document.getElementById("dob").value.trim();
    if (dob == "") {document.getElementById("doberror").innerText = "dob is required";
        document.getElementById("dob").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("doberror").innerText = "";
        document.getElementById("dob").style.border = "";}}
function validatetime() {
    let time = document.getElementById("time").value.trim();
    if (time == "") {document.getElementById("timeerror").innerText = "time is required";
        document.getElementById("time").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("timeerror").innerText = "";
        document.getElementById("time").style.border = "";}}
function validatelanguage() {var languageslist = []
    languages.forEach((language) => {
        if (language.checked) {languageslist.push(language.value);}})
    let languages = document.getElementsByName("languages");
    if (languageslist.length < 1) {document.getElementById("languageerror").innerText = "select atleast one language";
        isValid = false;}
    else {document.getElementById("languageerror").innerText = "";}}
function validateinterst() {
    var interestslist = []
    interests.forEach((interest) => {
        if (interest.checked) {interestslist.push(interest.value);}})
    let interests = document.getElementsByName("interest");
    if (interestslist.length < 1) {
        document.getElementById("interesterror").innerText = "interest is required";
        isValid = false;}
    else {document.getElementById("interesterror").innerText = "";}}
function validatephoto() {
    let photo = document.getElementById("photo").files[0];
    if (!photo) {document.getElementById("photoerror").innerText = "photo is required";
        isValid = false;}
    else {let imageextensions = ["image/jpeg", "image/jpg", "image/png"];
        if (!imageextensions.includes(photo.type)) {document.getElementById("photoerror").innerText = "Image only allowed PNG,JPEG,JPG";
            isValid = false;}
        else {document.getElementById("photoerror").innerText = "";}}}
function validateresume() {
    let resume = document.getElementById("resume").files[0];
    if (!resume) {document.getElementById("resumeerror").innerText = "resume is required";
        isValid = false;}
    else {document.getElementById("resumeerror").innerText = "";}}
document.getElementById("firstname").addEventListener("mouseout", validateName);
document.getElementById("lastname").addEventListener("mouseout", validatelastName);
document.getElementById("email").addEventListener("mouseout", validateEmail);
document.getElementById("phone").addEventListener("mouseout", validatePhone);
document.getElementById("password").addEventListener("mouseout", validatePassword);
document.getElementById("confirmpassword").addEventListener("mouseout", validateConfirmPassword);
let radiobuttons = document.querySelectorAll('input[type="radio"][name="gender"]');
console.log(radiobuttons);
radiobuttons.forEach(radio => {radio.addEventListener("mouseover", function () {const selectedradio = document.querySelector('input[name="gender"]:checked');
        if (!selectedradio) {document.getElementById("gendererror").innerText = "gender is required";
            isValid = false;}
        else {document.getElementById("gendererror").innerText = "";}})})
document.getElementById("presentaddress").addEventListener("mouseout", validatePresentaddress);
document.getElementById("permanentaddress").addEventListener("mouseout", validpermanentaddress);
document.getElementById("presentpincode").addEventListener("mouseout", validatePresentPin);
document.getElementById("permanentpincode").addEventListener("mouseout", validatePermanentPin);
document.getElementById("presentstate").addEventListener("mouseout", validatePresenstate);
document.getElementById("permanentstate").addEventListener("mouseout", validatePermanentstate);
document.getElementById("dob").addEventListener("mouseout", validatedob);
document.getElementById("time").addEventListener("mouseout", validatetime);
let languagebuttons = document.querySelectorAll('input[type="checkbox"][name="languages"]');
console.log(languagebuttons);
languagebuttons.forEach(radio => {radio.addEventListener("mouseover", function () {const selectedradio = document.querySelector('input[name="languages"]:checked');
        if (!selectedradio) {document.getElementById("languageerror").innerText = "Language is required";
            isValid = false;}
        else {document.getElementById("languageerror").innerText = "";}})})
let interstbuttons = document.querySelectorAll('input[type="checkbox"][name="interest"]');
console.log(interstbuttons);
interstbuttons.forEach(radio => {radio.addEventListener("mouseover", function () {const selectedradio = document.querySelector('input[name="interest"]:checked');
        if (!selectedradio) {document.getElementById("interesterror").innerText = "Interest is required";
            isValid = false;}
        else {document.getElementById("interesterror").innerText = ""; }})})
document.getElementById("photo").addEventListener("mouseout", validatephoto);
document.getElementById("resume").addEventListener("mouseout", validateresume);
document.getElementById("myform").addEventListener("submit", function (event) {event.preventDefault();
    let isValid = true;
    let firstname = document.getElementById("firstname").value.trim();
    let lastname = document.getElementById("lastname").value.trim();
    let email = document.getElementById("email").value.trim();
    let phone = document.getElementById("phone").value.trim();
    let password = document.getElementById("password").value.trim();
    let confirmpassword = document.getElementById("confirmpassword").value.trim();
    let gender = document.getElementsByName("gender");
    let presentaddress = document.getElementById("presentaddress").value.trim();
    let permanentaddress = document.getElementById("permanentaddress").value.trim();
    let presentpincode = document.getElementById("presentpincode").value.trim();
    let permanentpincode = document.getElementById("permanentpincode").value.trim();
    let presentstate = document.getElementById("presentstate").value.trim();
    let permanentstate = document.getElementById("permanentstate").value.trim();
    let dob = document.getElementById("dob").value.trim();
    let time = document.getElementById("time").value.trim();
    let languages = document.getElementsByName("languages");
    let interests = document.getElementsByName("interest");
    let photo = document.getElementById("photo").files[0];
    let resume = document.getElementById("resume").files[0];
    let gendervalue = "";
    gender.forEach((gen1) => {if (gen1.checked) {gendervalue = gen1.value;}})
    var languageslist = []
    languages.forEach((language) => {if (language.checked) {languageslist.push(language.value);}})
    var interestslist = []
    interests.forEach((interest) => {
        if (interest.checked) {interestslist.push(interest.value);}})
    if (firstname == "") {document.getElementById("firstnameerror").innerText = "Enter your Firstname";
        document.getElementById("firstname").style.border = "2px solid red";
        isValid = false;}
    else if (firstname != "" && !/^[A-Za-z]+$/.test(firstname)) {document.getElementById("firstnameerror").innerText = "Only letters are allowed";
        document.getElementById("firstname").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("firstnameerror").innerText = "";
        document.getElementById("firstname").style.border = "";}
    if (lastname == "") {document.getElementById("lastnameerror").innerText = "Enter your Lastname ";
        document.getElementById("lastname").style.border = "2px solid red";
        isValid = false;}
    else if (lastname != "" && !/^[A-Za-z]+$/.test(lastname)) {document.getElementById("lastnameerror").innerText = "Only letters are allowed";
        document.getElementById("lastname").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("lastnameerror").innerText = "";
        document.getElementById("lastname").style.border = "";}
    if (email == "") {document.getElementById("emailerror").innerText = "Enter your Email";
        document.getElementById("email").style.border = "2px solid red";
        isValid = false;}
    else if (email != "" && !/^\S+@\S+\.+\S/.test(email)) {document.getElementById("emailerror").innerText = "enter a valid email id";
        document.getElementById("email").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("emailerror").innerText = "";
        document.getElementById("email").style.border = "";}
    if (phone == "") {document.getElementById("phoneerror").innerText = "phone is required";
        document.getElementById("phone").style.border = "2px solid red";
        isValid = false;}
    else if (phone != "" && !/^[\d]{10}$/.test(phone)) {document.getElementById("phoneerror").innerText = "enter a valid Number";
        document.getElementById("phone").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("phoneerror").innerText = "";
        document.getElementById("phone").style.border = "";}
    if (password == "") {document.getElementById("passworderror").innerText = "password is required";
        document.getElementById("password").style.border = "2px solid red";
        isValid = false;}
    else if (password != "" && !/^[\S+\d]+$/.test(password)) {document.getElementById("passworderror").innerText = "enter a valid password";
        document.getElementById("password").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("passworderror").innerText = "";
        document.getElementById("password").style.border = "";}
    if (confirmpassword == "") {document.getElementById("confirmpassworderror").innerText = "Confirm password is required";
        document.getElementById("confirmpassword").style.border = "2px solid red";
        isValid = false;}
    else if (confirmpassword != password) {document.getElementById("confirmpassworderror").innerText = "password should be same";
        document.getElementById("confirmpassword").style.border = "2px solid red";
        isValid = false;}
    else if (confirmpassword != "" && !/^[\S+\d]+$/.test(confirmpassword)) {document.getElementById("confirmpassworderror").innerText = "enter a valid Confirm password";
        document.getElementById("confirmpassword").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("confirmpassworderror").innerText = "";
        document.getElementById("confirmpassword").style.border = "";}
    if (gendervalue == "") {document.getElementById("gendererror").innerText = "Select your gender";
        isValid = false;}
    else {document.getElementById("gendererror").innerText = "";}
    if (presentaddress == "") {document.getElementById("presentaddresserror").innerText = "present address is required";
        document.getElementById("presentaddress").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("presentaddresserror").innerText = "";
        document.getElementById("presentaddress").style.border = "";}
    if (permanentaddress == "") {document.getElementById("permanentaddresserror").innerText = "permanent address is required";
        document.getElementById("permanentaddress").style.border = "2px solid red";
        isValid = false; }
    else {document.getElementById("permanentaddresserror").innerText = "";
        document.getElementById("permanentaddress").style.border = "";}
    if (presentpincode == "") {document.getElementById("presentpincodeerror").innerText = "present zipcode is required";
        document.getElementById("presentpincode").style.border = "2px solid red";
        isValid = false;}
    else if (presentpincode != "" && !/^[\d]{6}$/.test(presentpincode)) {document.getElementById("presentpincodeerror").innerText = "enter a valid zipcode";
        document.getElementById("presentpincode").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("presentpincodeerror").innerText = "";
        document.getElementById("presentpincode").style.border = "";}
    if (permanentpincode == "") {document.getElementById("permanentpincodeerror").innerText = "permanent zipcode is required";
        document.getElementById("permanentpincode").style.border = "2px solid red";
        isValid = false;}
    else if (permanentpincode != "" && !/^[\d]{6}$/.test(permanentpincode)) {document.getElementById("permanentpincodeerror").innerText = "enter a valid zipcode";
        document.getElementById("permanentpincode").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("permanentpincodeerror").innerText = "";
        document.getElementById("permanentpincode").style.border = "";}
    if (permanentstate == "") {document.getElementById("permanentstateerror").innerText = "permanent state is required";
        document.getElementById("permanentstate").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("permanentstateerror").innerText = "";
        document.getElementById("permanentstate").style.border = "";}
    if (presentstate == "") {document.getElementById("presentstateerror").innerText = "present state is required";
        document.getElementById("presentstate").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("presentstateerror").innerText = "";
        document.getElementById("presentstate").style.border = "";}
    if (dob == "") {document.getElementById("doberror").innerText = "dob is required";
        document.getElementById("dob").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("doberror").innerText = "";
        document.getElementById("dob").style.border = "";}
    if (time == "") {document.getElementById("timeerror").innerText = "time is required";
        document.getElementById("time").style.border = "2px solid red";
        isValid = false;}
    else {document.getElementById("timeerror").innerText = "";
        document.getElementById("time").style.border = "";}
    if (languageslist.length < 1) {document.getElementById("languageerror").innerText = "Select atleast one";
        isValid = false;}
    else {document.getElementById("languageerror").innerText = "";}
    if (interestslist.length < 1) {document.getElementById("interesterror").innerText = "Select atleast one";
        isValid = false;}
    else {document.getElementById("interesterror").innerText = ""; }
    if (!photo) {document.getElementById("photoerror").innerText = "attach your photo";
        isValid = false; }
    else {let imageextensions = ["image/jpeg", "image/jpg", "image/png"];
        if (!imageextensions.includes(photo.type)) {document.getElementById("photoerror").innerText = "Image only allowed";
            isValid = false;}
        else {document.getElementById("photoerror").innerText = "";}}
    if (!resume) {document.getElementById("resumeerror").innerText = "attach your redsume";
        isValid = false;}
    else {document.getElementById("resumeerror").innerText = "";}
    isValid = true
    if (isValid) {localStorage.setItem("firstname", firstname);
        localStorage.setItem("lastname", lastname);
        localStorage.setItem("email", email);
        localStorage.setItem("phone", phone);
        localStorage.setItem("password", password);
        localStorage.setItem("gender", gendervalue);
        localStorage.setItem("presentaddress", presentaddress + "," + presentstate + "," + presentpincode);
        localStorage.setItem("dob", dob);
        localStorage.setItem("time", time);
        localStorage.setItem("languages", languageslist.join(","));
        localStorage.setItem("interest", interestslist.join(","));
        localStorage.setItem("photo", photo.name);
        localStorage.setItem("resume", resume.name);
        window.location.href = "Details.html";}})