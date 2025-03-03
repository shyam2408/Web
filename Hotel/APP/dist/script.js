var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
import * as APICALLS from './apicalls.js';
const signIn = document.getElementById("signIn");
const signUp = document.getElementById("signUp");
const homePage = document.getElementById("homePage");
var signInButton = document.getElementById("signInButton");
var signUpButton = document.getElementById("signUpButton");
const userProfilePage = document.getElementById("UserProfilePage");
const productProfilePage = document.getElementById("ProductProfilePage");
const walletRechargePage = document.getElementById("walletRechargePage");
const takeOrderPage = document.getElementById("TakeOrderPage");
const addNewProductPage = document.getElementById("addNewProduct");
const editProductPage = document.getElementById("editProduct");
var currentCustomer;
function displayNone() {
    signIn.style.display = "none";
    signUp.style.display = "none";
    homePage.style.display = "none";
    userProfilePage.style.display = "none";
    takeOrderPage.style.display = "none";
    productProfilePage.style.display = "none";
    walletRechargePage.style.display = "none";
    addNewProductPage.style.display = "none";
    editProductPage.style.display = "none";
}
function signInPage() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        alert("Sign in");
        signIn.style.display = "block";
        signUp.style.display = "none";
        signInButton.style.background = "rgb(247, 191, 113)";
        signUpButton.style.background = "none";
    });
}
function signUpPage() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        alert("sign up");
        signUp.style.display = "block";
        signIn.style.display = "none";
        signInButton.style.background = "none";
        signUpButton.style.background = "rgb(247, 191, 113)";
    });
}
function submitForm(event) {
    return __awaiter(this, void 0, void 0, function* () {
        var _a;
        event.preventDefault();
        var name = document.getElementById("name").value;
        var fatherName = document.getElementById("fatherName").value;
        var gender = document.getElementById("gender").value;
        var mobile = document.getElementById("mobile").value;
        var dob = document.getElementById("dob").value;
        var email = document.getElementById("email").value;
        var password = document.getElementById("password").value;
        var walletBalance = parseFloat(document.getElementById("walletBalance").value);
        var profilePhotoFile = (_a = document.getElementById("profilePhoto").files) === null || _a === void 0 ? void 0 : _a[0];
        var isavail = yield APICALLS.CheckCustomer(email);
        if (!isavail) {
            let profilePhotoBase64 = "";
            if (profilePhotoFile) {
                profilePhotoBase64 = yield convertToBase64(profilePhotoFile);
            }
            let newCustomer = yield APICALLS.AddNewCustomer({ customerID: "", name: name, fatherName: fatherName, gender: gender, mobileNumber: mobile, dob: dob, mailID: email, password: password, walletBalance: walletBalance, profilePhoto: profilePhotoBase64 });
            document.getElementById("name").value = "";
            document.getElementById("fatherName").value = "";
            document.getElementById("gender").value = "";
            document.getElementById("mobile").value = "";
            document.getElementById("dob").value = "";
            document.getElementById("email").value = "";
            document.getElementById("password").value = "";
            document.getElementById("walletBalance").value = "";
            document.getElementById("profilePhoto").value = "";
            alert(`Registration Successful. Your Customer ID is ${newCustomer}.`);
        }
        else {
            var signInBorder = document.getElementById("signUp");
            signInBorder.style.border = "1px solid red";
            alert(`Already exist`);
        }
    });
}
function signInSubmit(e) {
    return __awaiter(this, void 0, void 0, function* () {
        e.preventDefault();
        var email = document.getElementById("email1");
        var password = document.getElementById("password2");
        if (!email.value || !password.value) {
            alert("Email and Password cannot be empty");
            return;
        }
        var customer = yield APICALLS.GetIndividualUser(email.value, password.value);
        if (customer == null) {
            alert("Invalid Email or Password");
            email.value = "";
            password.value = "";
        }
        else {
            var boxElement = document.getElementById("box");
            boxElement.style.display = "none";
            var menu = document.getElementById("menu");
            menu.style.display = "block";
            currentCustomer = customer;
            home();
            email.value = "";
            password.value = "";
        }
    });
}
function home() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        homePage.style.display = "block";
    });
}
function CustomerDetails() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        userProfilePage.style.display = "block";
        document.getElementById('user-profile-card').innerHTML = `
    <div class="profile-photo">
          <img src="${currentCustomer.profilePhoto}">
    </div>
    <table class="profile-table">
        <tr>
            <th>User ID</th> <td>${currentCustomer.customerID}</td>
        </tr>
        <tr>
            <th>User Name</th>  <td>${currentCustomer.name}</td>
        </tr>
        <tr>
            <th>Adhaar Number</th>  <td>${currentCustomer.fatherName}</td>
        </tr>
        <tr>
            <th>Gender</th>  <td>${currentCustomer.gender}</td>
        </tr>
        <tr>
            <th>Mobile Number</th>  <td>${currentCustomer.mobileNumber}</td>
        </tr>
        <tr>
            <th>Mail ID</th>  <td>${currentCustomer.mailID}</td>    
        </tr>
        <tr>
            <th>DOB</th> <td>${currentCustomer.dob.split('T')[0].split('-').reverse().join('/')}</td>
        </tr>
        <tr>
            <th>Balance</th> <td>${currentCustomer.walletBalance}</td>
        </tr>
    </table>
    `;
    });
}
function NewProductPage() {
    return __awaiter(this, void 0, void 0, function* () {
        addNewProductPage.style.display = "block";
        editProductPage.style.display = "none";
    });
}
function ShowProductDetails() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        productProfilePage.style.display = "block";
        var products = yield APICALLS.FetchProducts();
        var productTable = document.getElementById("product-table");
        productTable.innerHTML = `
                <tr>
                    <th>Room Image</th> <th>Room ID</th> <th>Room Type</th> <th>Number of Beds</th> <th>Price per day</th> <th>Action</th>
                </tr>`;
        products.forEach(product => {
            const row = document.createElement('tr');
            row.innerHTML = `
                <tr>
                <td><img src="${product.productImage}"></td> <td>${product.productID}</td> <td>${product.productName}</td>
                <td>${product.quantityAvailable}</td> <td>${product.pricePerQuantity}</td>
                <td>
                    <button onclick="editChosenProduct('${product.productID}')">Edit</button>
                    <button onclick="deleteProduct('${product.productID}')">Delete</button>
                </td>
                </tr> `;
            productTable.appendChild(row);
        });
    });
}
var currentProduct;
function editChosenProduct(productID) {
    return __awaiter(this, void 0, void 0, function* () {
        editProductPage.style.display = "block";
        addNewProductPage.style.display = "none";
        currentProduct = yield APICALLS.GetIndividualProduct(productID);
        if (currentProduct != null) {
            document.getElementById("editProductName").value = currentProduct.productName;
            document.getElementById("editProductQuantity").value = String(currentProduct.quantityAvailable);
            document.getElementById("editProductPrice").value = String(currentProduct.pricePerQuantity);
        }
        else {
            alert("Product not found");
        }
    });
}
function addProduct(e) {
    return __awaiter(this, void 0, void 0, function* () {
        var _a;
        e.preventDefault();
        var productName = document.getElementById("productName").value;
        var quantity = parseFloat(document.getElementById("productQuantity").value);
        var price = parseFloat(document.getElementById("productPrice").value);
        var isProductValid = yield APICALLS.CheckProductExist(productName);
        var productPhotoFile = (_a = document.getElementById("add-photo").files) === null || _a === void 0 ? void 0 : _a[0];
        let productPhotoBase64 = "";
        if (productPhotoFile) {
            productPhotoBase64 = yield convertToBase64(productPhotoFile);
        }
        let newProduct = yield APICALLS.AddNewProduct({ productID: "", productName: productName, quantityAvailable: quantity, pricePerQuantity: price, productImage: productPhotoBase64 });
        document.getElementById("productName").value = "";
        document.getElementById("productQuantity").value = "";
        document.getElementById("productPrice").value = "";
        document.getElementById("add-photo").value = "";
        alert(`Product added successfully. Product ID is ${newProduct}`);
        ShowProductDetails();
    });
}
function editProduct(e) {
    return __awaiter(this, void 0, void 0, function* () {
        var _a;
        e.preventDefault();
        if (currentProduct != null) {
            var Name = document.getElementById("editProductName").value;
            var quantity = parseFloat(document.getElementById("editProductQuantity").value);
            var price = parseFloat(document.getElementById("editProductPrice").value);
            var productPhotoFile = (_a = document.getElementById("edit-photo").files) === null || _a === void 0 ? void 0 : _a[0];
            let productPhotoBase64 = "";
            if (productPhotoFile) {
                productPhotoBase64 = yield convertToBase64(productPhotoFile); // Convert the image to Base64
            }
            yield APICALLS.EditProductDetail({ productID: currentProduct.productID, productName: Name, quantityAvailable: quantity, pricePerQuantity: price, productImage: productPhotoBase64 });
            alert("Product modified successfully.");
            document.getElementById("editProductName").value = "";
            document.getElementById("editProductQuantity").value = "";
            document.getElementById("editProductPrice").value = "";
            document.getElementById("edit-photo").value = "";
            ShowProductDetails();
        }
    });
}
function deleteProduct(productID) {
    return __awaiter(this, void 0, void 0, function* () {
        const deleteProduct = confirm('Do you want to delete this Room');
        if (deleteProduct) {
            yield APICALLS.DeleteProductDetail(productID);
            alert("Room deleted successfully.");
        }
        ShowProductDetails();
    });
}
function RechargeWallet() {
    displayNone();
    walletRechargePage.style.display = "block";
    document.getElementById("currentBalance").innerHTML = `Available Balance : ${currentCustomer.walletBalance}`;
}
function TakeOrder() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        takeOrderPage.style.display = "block";
        var products = yield APICALLS.FetchProducts();
        productContainer.innerHTML = '';
        displayProducts(products);
    });
}
const productContainer = document.getElementById('product-container');
function displayProducts(products) {
    products.forEach(product => {
        const productDiv = document.createElement('div');
        productDiv.className = 'product';
        // Create image
        const productImage = document.createElement('img');
        productImage.src = product.productImage;
        productImage.alt = product.productName;
        productDiv.appendChild(productImage);
        // Create product name
        const productName = document.createElement('h2');
        productName.textContent = product.productName;
        productDiv.appendChild(productName);
        // Create product details (quantity, price)
        const productDetails = document.createElement('p');
        productDetails.textContent = `Available: ${product.quantityAvailable} | Price: $${product.pricePerQuantity}`;
        productDiv.appendChild(productDetails);
        // Create button
        const button = document.createElement('button');
        button.textContent = 'Add to Whishlist';
        productDiv.appendChild(button);
        button.onclick = function () {
            AddToCart(product.productID);
        };
        // Append to the container
        productContainer.appendChild(productDiv);
    });
}
function AddToCart(productID) {
    return __awaiter(this, void 0, void 0, function* () {
        //Prompt for asking food count
        const quantity = prompt("Enter the date you want to Book?");
        // Convert the string input to a number
        const quantityNumber = Number(quantity);
        // Check if the quantity is a valid number and greater than 0
        if (isNaN(quantityNumber) || quantityNumber <= 0) {
            alert("Please enter a valid date.");
        }
        else {
            // Proceed with the valid quantity
            var selectedProduct = yield APICALLS.GetIndividualProduct(productID);
            if (selectedProduct != null) {
                var cartID = yield APICALLS.AddItemToCart({ cartID: "", customerID: currentCustomer.customerID, productID: selectedProduct.productID, purchaseCount: quantityNumber, priceOfCart: quantityNumber * selectedProduct.pricePerQuantity, productImage: selectedProduct.productImage });
                alert(`${selectedProduct.productName} added to cart list with ${quantityNumber} quantity. Your OrderID is ${cartID}`);
            }
        }
        TakeOrder();
    });
}
function deposit() {
    return __awaiter(this, void 0, void 0, function* () {
        var amount1 = document.getElementById("amount").value;
        yield APICALLS.RechargeWalletBalance(currentCustomer.customerID, Number(amount1));
        var customer = yield APICALLS.GetIndividualUser(currentCustomer.mailID, currentCustomer.password);
        currentCustomer = customer;
        document.getElementById("amount").value = "";
        alert(`Recharge Successful. Your current balance is ${currentCustomer.walletBalance}`);
        RechargeWallet();
    });
}
function LogOut() {
    return __awaiter(this, void 0, void 0, function* () {
        displayNone();
        document.getElementById("menu").style.display = "none";
        document.getElementById("box").style.display = "block";
        signIn.style.display = "block";
    });
}
function convertToBase64(file) {
    return __awaiter(this, void 0, void 0, function* () {
        return new Promise((resolve, reject) => {
            const reader = new FileReader();
            reader.onloadend = () => resolve(reader.result);
            reader.onerror = reject;
            reader.readAsDataURL(file);
        });
    });
}
const functions = Object.assign({ home, signInPage, signUpPage, LogOut, deposit, ShowProductDetails, editChosenProduct, addProduct, editProduct, TakeOrder, deleteProduct, CustomerDetails, NewProductPage, signInSubmit, submitForm, RechargeWallet, displayNone }, APICALLS);
Object.assign(window, functions);
