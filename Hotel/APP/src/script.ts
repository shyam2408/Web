import { CustomerRegistration, ProductDetails,BookingDetails,PurchasedItems, CartDetails } from './model';
import * as APICALLS from './apicalls.js';


const signIn = document.getElementById("signIn") as HTMLDivElement;
const signUp = document.getElementById("signUp") as HTMLDivElement;
const homePage = document.getElementById("homePage") as HTMLDivElement;
var signInButton = document.getElementById("signInButton") as HTMLDivElement;
var signUpButton = document.getElementById("signUpButton") as HTMLDivElement;

const userProfilePage = document.getElementById("UserProfilePage") as HTMLDivElement;
const productProfilePage = document.getElementById("ProductProfilePage") as HTMLDivElement;
const walletRechargePage = document.getElementById("walletRechargePage") as HTMLDivElement;
const takeOrderPage = document.getElementById("TakeOrderPage") as HTMLDivElement;
const addNewProductPage = document.getElementById("addNewProduct") as HTMLDivElement;
const editProductPage = document.getElementById("editProduct") as HTMLDivElement;


var currentCustomer: CustomerRegistration;

function displayNone(): void {
    signIn.style.display = "none";
    signUp.style.display = "none";
    homePage.style.display = "none";
    userProfilePage.style.display = "none";
    takeOrderPage.style.display="none";
    productProfilePage.style.display = "none";
    walletRechargePage.style.display = "none";
    addNewProductPage.style.display = "none";
    editProductPage.style.display = "none";
}

async function signInPage() {
    displayNone();
    alert("Sign in")
    signIn.style.display = "block";
    signUp.style.display = "none";
    signInButton.style.background = "rgb(247, 191, 113)";
    signUpButton.style.background = "none";
}

async function signUpPage() {
    displayNone();
    alert("sign up")
    signUp.style.display = "block";
    signIn.style.display = "none";
    signInButton.style.background = "none";
    signUpButton.style.background = "rgb(247, 191, 113)";
}


async function submitForm(event: Event) {
    event.preventDefault();
    var name = (document.getElementById("name") as HTMLInputElement).value;
    var fatherName = (document.getElementById("fatherName") as HTMLInputElement).value;
    var gender = (document.getElementById("gender") as HTMLSelectElement).value;
    var mobile = (document.getElementById("mobile") as HTMLInputElement).value;
    var dob = (document.getElementById("dob") as HTMLInputElement).value;
    var email = (document.getElementById("email") as HTMLInputElement).value;
    var password = (document.getElementById("password") as HTMLInputElement).value;
    var walletBalance = parseFloat((document.getElementById("walletBalance") as HTMLInputElement).value);
    var profilePhotoFile = (document.getElementById("profilePhoto") as HTMLInputElement).files?.[0];
    var isavail: boolean = await APICALLS.CheckCustomer(email);


    if (!isavail) {

        let profilePhotoBase64 = "";
        if (profilePhotoFile) {
            profilePhotoBase64 = await convertToBase64(profilePhotoFile); 
        }
        let newCustomer: string = await APICALLS.AddNewCustomer({ customerID: "", name: name, fatherName: fatherName, gender: gender, mobileNumber: mobile, dob: dob, mailID: email, password: password, walletBalance: walletBalance, profilePhoto: profilePhotoBase64 });
        (document.getElementById("name") as HTMLInputElement).value = "";
        (document.getElementById("fatherName") as HTMLInputElement).value = "";
        (document.getElementById("gender") as HTMLSelectElement).value = "";
        (document.getElementById("mobile") as HTMLInputElement).value = "";
        (document.getElementById("dob") as HTMLInputElement).value = "";
        (document.getElementById("email") as HTMLInputElement).value = "";
        (document.getElementById("password") as HTMLInputElement).value = "";
        (document.getElementById("walletBalance") as HTMLInputElement).value = "";
        (document.getElementById("profilePhoto") as HTMLInputElement).value = "";

        alert(`Registration Successful. Your Customer ID is ${newCustomer}.`);
    }
    else {
        var signInBorder = document.getElementById("signUp") as HTMLDivElement;
        signInBorder.style.border = "1px solid red";
        alert(`Already exist`)
    }
}

async function signInSubmit(e: Event) {
    e.preventDefault();
    var email = document.getElementById("email1") as HTMLInputElement;
    var password = document.getElementById("password2") as HTMLInputElement;

    if (!email.value || !password.value) {
        alert("Email and Password cannot be empty");
        return;
    }

    var customer: CustomerRegistration | null = await APICALLS.GetIndividualUser(email.value, password.value);
    if (customer == null) {
        alert("Invalid Email or Password");
        email.value = "";
        password.value = "";
    }
    else {
        var boxElement = document.getElementById("box") as HTMLDivElement
        boxElement.style.display = "none";
        var menu = document.getElementById("menu") as HTMLDivElement;
        menu.style.display = "block";
        currentCustomer = customer;
        home();
        email.value = "";
        password.value = "";
    }
}

async function home() {
    displayNone();
    homePage.style.display = "block";
}

async function CustomerDetails() {
    displayNone();
    userProfilePage.style.display = "block";
    document.getElementById('user-profile-card')!.innerHTML = `
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
}
async function NewProductPage() {
    addNewProductPage.style.display = "block";
    editProductPage.style.display = "none";
}
async function ShowProductDetails() {
    displayNone();
    productProfilePage.style.display = "block";

    var products = await APICALLS.FetchProducts();
    var productTable = document.getElementById("product-table") as HTMLTableSectionElement;
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
}
var currentProduct: ProductDetails | null;
async function editChosenProduct(productID: string) {
    editProductPage.style.display = "block";
    addNewProductPage.style.display = "none";
    currentProduct = await APICALLS.GetIndividualProduct(productID);
    if (currentProduct != null) {
        (document.getElementById("editProductName") as HTMLInputElement).value = currentProduct.productName;
        (document.getElementById("editProductQuantity") as HTMLInputElement).value = String(currentProduct.quantityAvailable);
        (document.getElementById("editProductPrice") as HTMLInputElement).value = String(currentProduct.pricePerQuantity);
    }
    else {
        alert("Room not found");
    }
}

async function addProduct(e: Event) {
    e.preventDefault();
    var productName = (document.getElementById("productName") as HTMLInputElement).value;
    var quantity = parseFloat((document.getElementById("productQuantity") as HTMLInputElement).value);
    var price = parseFloat((document.getElementById("productPrice") as HTMLInputElement).value);
    var isProductValid = await APICALLS.CheckProductExist(productName);

    var productPhotoFile = (document.getElementById("add-photo") as HTMLInputElement).files?.[0];
        let productPhotoBase64 = "";
        if (productPhotoFile) {
            productPhotoBase64 = await convertToBase64(productPhotoFile); 
        }
        let newProduct: string = await APICALLS.AddNewProduct({ productID: "", productName: productName, quantityAvailable: quantity, pricePerQuantity: price, productImage: productPhotoBase64 });
        (document.getElementById("productName") as HTMLInputElement).value = "";
        (document.getElementById("productQuantity") as HTMLInputElement).value = "";
        (document.getElementById("productPrice") as HTMLInputElement).value = "";
        (document.getElementById("add-photo") as HTMLInputElement).value = "";
        alert(`Product added successfully. Product ID is ${newProduct}`);
    ShowProductDetails();
}

async function editProduct(e: Event) {
    e.preventDefault();
    if (currentProduct != null) {

        var Name = (document.getElementById("editProductName") as HTMLInputElement).value;
        var quantity = parseFloat((document.getElementById("editProductQuantity") as HTMLInputElement).value);
        var price = parseFloat((document.getElementById("editProductPrice") as HTMLInputElement).value);
        var productPhotoFile = (document.getElementById("edit-photo") as HTMLInputElement).files?.[0];
        let productPhotoBase64 = "";
        if (productPhotoFile) {
            productPhotoBase64 = await convertToBase64(productPhotoFile); // Convert the image to Base64
        }
        await APICALLS.EditProductDetail({ productID: currentProduct.productID, productName: Name, quantityAvailable: quantity, pricePerQuantity: price, productImage: productPhotoBase64 });
        alert("Product modified successfully.");
        (document.getElementById("editProductName") as HTMLInputElement).value = "";
        (document.getElementById("editProductQuantity") as HTMLInputElement).value = "";
        (document.getElementById("editProductPrice") as HTMLInputElement).value = "";
        (document.getElementById("edit-photo") as HTMLInputElement).value = "";
        ShowProductDetails();
    }
}

async function deleteProduct(productID: string) {
    const deleteProduct = confirm('Do you want to delete this Room');
    if (deleteProduct) {
        await APICALLS.DeleteProductDetail(productID);
        alert("Room deleted successfully.");
    }
    ShowProductDetails();
}

function RechargeWallet() {
    displayNone();
    walletRechargePage.style.display = "block";
    document.getElementById("currentBalance") !.innerHTML = `Available Balance : ${currentCustomer.walletBalance}`;
}
async function TakeOrder() {
    displayNone();
    takeOrderPage.style.display = "block";
    var products = await APICALLS.FetchProducts();
    productContainer.innerHTML = '';
    displayProducts(products);

}

const productContainer = document.getElementById('product-container') as HTMLDivElement;

function displayProducts(products: ProductDetails[]) {
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
        button.textContent = 'Add to Wishlist';
        productDiv.appendChild(button);

        button.onclick = function () {
            AddToCart(product.productID);
        }
        // Append to the container
        productContainer.appendChild(productDiv);
    });
}

async function AddToCart(productID: string) {
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
        var selectedProduct: ProductDetails | null = await APICALLS.GetIndividualProduct(productID);
        if (selectedProduct != null) {
            var cartID: string = await APICALLS.AddItemToCart({ cartID: "", customerID: currentCustomer.customerID, productID: selectedProduct.productID, purchaseCount: quantityNumber, priceOfCart: quantityNumber * selectedProduct.pricePerQuantity, productImage: selectedProduct.productImage });
            alert(`${selectedProduct.productName} added to cart list with ${quantityNumber} quantity. Your OrderID is ${cartID}`);
        }
    }
    TakeOrder();
}

async function deposit() {
    var amount1 = (document.getElementById("amount") as HTMLInputElement).value;
    await APICALLS.RechargeWalletBalance(currentCustomer.customerID, Number(amount1));
    var customer: CustomerRegistration | null = await APICALLS.GetIndividualUser(currentCustomer.mailID, currentCustomer.password);
    currentCustomer = <CustomerRegistration>customer;
    (document.getElementById("amount") as HTMLInputElement).value = "";
    alert(`Recharge Successful. Your current balance is ${currentCustomer.walletBalance}`);
    RechargeWallet();
}

async function LogOut() {
    displayNone();
    (document.getElementById("menu") as HTMLDivElement).style.display = "none";
    (document.getElementById("box") as HTMLDivElement).style.display = "block";
    signIn.style.display = "block";
}
async function convertToBase64(file: File): Promise<string> {
    return new Promise((resolve, reject) => {
        const reader = new FileReader();
        reader.onloadend = () => resolve(reader.result as string);
        reader.onerror = reject;
        reader.readAsDataURL(file);
    });
}
const functions = {home, signInPage, signUpPage,LogOut, deposit,ShowProductDetails,editChosenProduct,addProduct,editProduct,TakeOrder,deleteProduct,  CustomerDetails,NewProductPage, signInSubmit, submitForm,RechargeWallet, displayNone,...APICALLS };
Object.assign(window, functions);