import { CustomerRegistration, RoomDetails, BookingDetails, Wishlist, RoomSelection } from './model';
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
const customerCartItemsPage = document.getElementById("CustomerCartItemsPage") as HTMLDivElement;
const orderHistoryPage = document.getElementById("OrderHistoryPage") as HTMLDivElement;
var currentCustomer: CustomerRegistration;
async function displayNone() {
    signIn.style.display = "none";
    signUp.style.display = "none";
    homePage.style.display = "none";
    userProfilePage.style.display = "none";
    productProfilePage.style.display = "none";
    walletRechargePage.style.display = "none";
    takeOrderPage.style.display = "none";
    addNewProductPage.style.display = "none";
    editProductPage.style.display = "none";
    customerCartItemsPage.style.display = "none";
    orderHistoryPage.style.display = "none";
}
async function signInPage() {
    displayNone();
    signIn.style.display = "block";
    signUp.style.display = "none";
    signInButton.style.background = "rgba(61, 113, 193, 0.927)";
    signUpButton.style.background = "none";
}
async function signUpPage() {
    displayNone();
    signUp.style.display = "block";
    signIn.style.display = "none";
    signInButton.style.background = "none";
    signUpButton.style.background = "rgba(61, 113, 193, 0.927)";
}
async function submitForm(event: Event) {
    event.preventDefault();
    var name = (document.getElementById("name") as HTMLInputElement).value;
    var aadhar = (document.getElementById("aadhar") as HTMLInputElement).value;
    var gender = (document.getElementById("gender") as HTMLSelectElement).value;
    var mobile = (document.getElementById("mobile") as HTMLInputElement).value;
    var address = (document.getElementById("address") as HTMLInputElement).value;
    var email = (document.getElementById("email") as HTMLInputElement).value;
    var password = (document.getElementById("password") as HTMLInputElement).value;
    var walletBalance = parseFloat((document.getElementById("walletBalance") as HTMLInputElement).value);
    var profilePhotoFile = (document.getElementById("profilePhoto") as HTMLInputElement).files?.[0];
    var isavail: boolean = await APICALLS.CheckCustomer(email);
    var foodtype = (document.getElementById("foodtype") as HTMLSelectElement).value;
    console.log(isavail);
    if (!isavail) {
        let profilePhotoBase64 = "";
        if (profilePhotoFile) {
            profilePhotoBase64 = await convertToBase64(profilePhotoFile); // Convert the image to Base64
        }
        let newCustomer: string = await APICALLS.AddNewCustomer({ customerID: "", name: name, aadhar: aadhar, address: address, gender: gender, mobileNumber: mobile, foodType: foodtype, mailID: email, password: password, walletBalance: walletBalance, profilePhoto: profilePhotoBase64 });
        (document.getElementById("name") as HTMLInputElement).value = "";
        (document.getElementById("aadhar") as HTMLInputElement).value = "";
        (document.getElementById("gender") as HTMLSelectElement).value = "";
        (document.getElementById("foodtype") as HTMLSelectElement).value = "";
        (document.getElementById("mobile") as HTMLInputElement).value = "";
        (document.getElementById("email") as HTMLInputElement).value = "";
        (document.getElementById("password") as HTMLInputElement).value = "";
        (document.getElementById("walletBalance") as HTMLInputElement).value = "";
        (document.getElementById("profilePhoto") as HTMLInputElement).value = "";
        alert(`Registration Successful. Your Customer ID is ${newCustomer}.`);
    }
    else {
        var signInBorder = document.getElementById("signUp") as HTMLDivElement;
        signInBorder.style.border = "0.5px solid red";
        alert(`Already exist`)
    }
}
async function convertToBase64(file: File): Promise<string> {
    return new Promise((resolve, reject) => {
        const reader = new FileReader();
        reader.onloadend = () => resolve(reader.result as string);
        reader.onerror = reject;
        reader.readAsDataURL(file);
    });
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
//displaying customer details
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
            <th>Aadhar number</th>  <td>${currentCustomer.aadhar}</td>
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
            <th>Food Type</th>  <td>${currentCustomer.foodType}</td>    
        </tr>
        
        <tr>
            <th>Balance</th> <td>${currentCustomer.walletBalance}</td>
        </tr>
    </table>
    `;
}
//displaying room details
async function ShowRoomDetails() {
    displayNone();
    productProfilePage.style.display = "block";

    var products = await APICALLS.FetchProducts();
    var productTable = document.getElementById("product-table") as HTMLTableSectionElement;
    productTable.innerHTML = `
                <tr>
                    <th>Room Image</th> <th>Room ID</th> <th>Room Type</th> <th>NumberOfBeds</th> <th>Price</th> <th>Action</th>
                </tr>`;
    products.forEach(product => {
        const row = document.createElement('tr');
        row.innerHTML = `
                <tr>
                <td><img src="${product.roomImage}"></td> <td>${product.roomID}</td> <td>${product.roomType}</td>
                <td>${product.numberOfBeds}</td> <td>${product.pricePerDay}</td>
                <td>
                    <button onclick="editChosenProduct('${product.roomID}')">Edit</button>
                    <button onclick="deleteProduct('${product.roomID}')">Delete</button>
                </td>
                </tr> `;
        productTable.appendChild(row);
    });
}
var currentRoom: RoomDetails | null;
async function editChosenProduct(roomID: string) {
    editProductPage.style.display = "block";
    addNewProductPage.style.display = "none";
    currentRoom = await APICALLS.GetIndividualProduct(roomID);
    if (currentRoom != null) {
        (document.getElementById("editRoomType") as HTMLInputElement).value = currentRoom.roomType;
        (document.getElementById("editNumberofBeds") as HTMLInputElement).value = String(currentRoom.numberOfBeds);
        (document.getElementById("editpriceperday") as HTMLInputElement).value = String(currentRoom.pricePerDay);
    }
    else {
        alert("Room not available");
    }
}
async function editProduct(e: Event) {
    e.preventDefault();
    if (currentRoom != null) {

        var roomType = (document.getElementById("editRoomType") as HTMLInputElement).value;
        var numberOfBeds = parseFloat((document.getElementById("editNumberofBeds") as HTMLInputElement).value);
        var price = parseFloat((document.getElementById("editpriceperday") as HTMLInputElement).value);
        var productPhotoFile = (document.getElementById("edit-photo") as HTMLInputElement).files?.[0];
        let productPhotoBase64 = "";
        if (productPhotoFile) {
            productPhotoBase64 = await convertToBase64(productPhotoFile); // Convert the image to Base64
        }
        await APICALLS.EditProductDetail({ roomID: currentRoom.roomID, roomType: roomType, numberOfBeds: numberOfBeds, pricePerDay: price, roomImage: productPhotoBase64 });
        alert("Product modified successfully.");
        (document.getElementById("editRoomType") as HTMLInputElement).value = "";
        (document.getElementById("editNumberofBeds") as HTMLInputElement).value = "";
        (document.getElementById("editpriceperday") as HTMLInputElement).value = "";
        (document.getElementById("edit-photo") as HTMLInputElement).value = "";
        ShowRoomDetails();
    }
}
async function deleteProduct(roomID: string) {
    const deleteProduct = confirm('Do you want to delete this room');
    if (deleteProduct) {
        await APICALLS.DeleteProductDetail(roomID);
        alert("Room deleted successfully.");
    }
    ShowRoomDetails();
}
async function NewProductPage() {
    addNewProductPage.style.display = "block";
    editProductPage.style.display = "none";
}
async function addProduct(e: Event) {
    e.preventDefault();
    var roomType = (document.getElementById("roomType") as HTMLInputElement).value;
    var numberOfBeds = parseFloat((document.getElementById("numberOfBeds") as HTMLInputElement).value);
    var pricePerDay = parseFloat((document.getElementById("pricePerDay") as HTMLInputElement).value);
    var isProductValid = false;
    if (isProductValid) {
        //setting value to null
        (document.getElementById("roomType") as HTMLInputElement).value = "";
        (document.getElementById("numberOfBeds") as HTMLInputElement).value = "";
        (document.getElementById("pricePerDay") as HTMLInputElement).value = "";
        (document.getElementById("add-photo") as HTMLInputElement).value = "";
        alert("This Room already exists");
    }
    else {
        var productPhotoFile = (document.getElementById("add-photo") as HTMLInputElement).files?.[0];
        let productPhotoBase64 = "";
        if (productPhotoFile) {
            productPhotoBase64 = await convertToBase64(productPhotoFile); // Convert the image to Base64
        }
        let newProduct: string = await APICALLS.AddNewProduct({ roomID: "", roomType: roomType, numberOfBeds: numberOfBeds, pricePerDay: pricePerDay, roomImage: productPhotoBase64 });
        (document.getElementById("roomType") as HTMLInputElement).value = "";
        (document.getElementById("numberOfBeds") as HTMLInputElement).value = "";
        (document.getElementById("pricePerDay") as HTMLInputElement).value = "";
        (document.getElementById("add-photo") as HTMLInputElement).value = "";
        alert(`Room added successfully. Room ID is ${newProduct}`);
    }
    ShowRoomDetails();
}
function RechargeWallet() {
    displayNone();
    walletRechargePage.style.display = "block";
    (document.getElementById("currentBalance") as HTMLHeadingElement).innerHTML = `Available Balance : ${currentCustomer.walletBalance}`;
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
const productContainer = document.getElementById('product-container') as HTMLDivElement;
async function BookRoom() {
    displayNone();
    takeOrderPage.style.display = "block";
    var products = await APICALLS.FetchProducts();
    productContainer.innerHTML = '';
    displayProducts(products);

}
function displayProducts(products: RoomDetails[]) {
    products.forEach(product => {
        const productDiv = document.createElement('div');
        productDiv.className = 'product';
        // Create image
        const productImage = document.createElement('img');
        productImage.src = product.roomImage;
        productImage.alt = product.roomType;
        productDiv.appendChild(productImage);
        // Create product name
        const roomType = document.createElement('h2');
        roomType.textContent = product.roomType;
        productDiv.appendChild(roomType);
        // Create product details (quantity, price)
        const productDetails = document.createElement('p');
        productDetails.textContent = `No of beds: ${product.numberOfBeds} | Price: $${product.pricePerDay}`;
        productDiv.appendChild(productDetails);
        // Create button
        const button = document.createElement('button');
        button.textContent = 'Add to wishlist';
        if (product.numberOfBeds < 1) {
            button.disabled = true;
            button.style.backgroundColor = "grey";
        }
        productDiv.appendChild(button);

        button.onclick = function () {
            AddToCart(product.roomID);
        }
        productContainer.appendChild(productDiv);
    });
}
const inputcon = document.getElementById("inputdate-container") as HTMLDivElement
//add to wishlist
async function AddToCart(productID: string) {
    displayNone();
    takeOrderPage.style.display = "block";
    inputcon.style.display = "block";
    alert("wishlist")
    var len = inputcon.getElementsByTagName("div").length;
    if (inputcon.hasChildNodes()) {
        for (var i = len - 1; i >= 0; i--) {
            inputcon.removeChild(inputcon.children[i]);
        }
    }
    const inputdiv = document.createElement('div');
    inputdiv.className = "getdate";
    inputdiv.innerHTML = `<p style="color: green;">From-date</p> 
    <input type="Date" id ="startdate"  name="startdate" required style="background-color: lightgreen; color: white; border-color: white"> 
    <p style="color: red;">To-date</p>
    <input type="Date" id ="enddate" name="enddate" required style="background-color: lightcoral; color: white; border-color: white">
    <input type="hidden" id ="productID" value=${productID} name="quantity" required>
    <br><br>
    <button onclick="submitDate()" style="background-color: green; color: white; border-color: white">Submit</button>`;
    inputcon.appendChild(inputdiv);
    //form display
    inputcon.style.textAlign = "center";
}
//submitting date
async function submitDate() {
    const startdateele = document.getElementById("startdate") as HTMLInputElement;
    const enddateele = document.getElementById("enddate") as HTMLInputElement;
    const productIDele = document.getElementById("productID") as HTMLInputElement;
    const productID = productIDele.value;
    const startdate = startdateele.value;
    const enddate = enddateele.value;
    inputcon.style.display = "none";
    let date1 = new Date(startdate);
    let date2 = new Date(enddate);
    let Difference_In_Time = date2.getTime() - date1.getTime();
    let Difference_In_Days = Math.round(Difference_In_Time / (1000 * 3600 * 24));
    var selectedProduct: RoomDetails | null = await APICALLS.GetIndividualProduct(productID);
    if (selectedProduct != null) {
        console.log(typeof (startdate));
        var isBooked: string = await APICALLS.CheckIsBooked(selectedProduct.roomID, startdate, enddate);
        console.log(isBooked, "book");
        if (isBooked) {
            var cartID: string = await APICALLS.AddItemToCart({
                wishlistID: "", customerID: currentCustomer.customerID, roomID: selectedProduct.roomID, purchaseCount: selectedProduct.numberOfBeds, priceOfRoom: (Difference_In_Days) * selectedProduct.pricePerDay, roomImage: selectedProduct.roomImage,
                stayingFrom: startdate, stayingTo: enddate
            });
            alert(`${selectedProduct.roomID} added to cart list . Your OrderID is ${cartID}`);
        }
        else {
            alert("The room is already booked");
        }
    }
    TakeOrder();
}
async function PurchaseAllItems() {
    var bookingStatus = await APICALLS.purchaseAll(currentCustomer.customerID);
    currentCustomer = <CustomerRegistration>await APICALLS.GetIndividualUser(currentCustomer.mailID, currentCustomer.password);
    alert(bookingStatus);
    modifydate.style.display = "none";
    Wishlists();
}
async function TakeOrder() {
    displayNone();
    takeOrderPage.style.display = "block";
    var products = await APICALLS.FetchProducts();
    productContainer.innerHTML = '';
    displayProducts(products);
}
const billContentDiv = document.getElementById('bill-content') as HTMLDivElement;
async function OrderHistory() {
    displayNone();
    orderHistoryPage.style.display = "block";
    billContentDiv.innerHTML = '';
    var bookings = await APICALLS.FetchAllBookings(currentCustomer.customerID);
    var bookingTable = document.getElementById("booking-table") as HTMLTableSectionElement;
    if (bookings.length == 0) {
        bookingTable.innerHTML = '';
        const emptyCart = document.createElement('h2');
        emptyCart.textContent = 'No Bookings History Found';
        emptyCart.className = 'empty';
        billContentDiv.appendChild(emptyCart);
    }
    else {
        bookingTable.innerHTML = `
                <tr>
                    <th>Booking ID</th>  <th>Total Price</th> <th>Date Of Booking</th> <th>Booking Status</th> <th>Action</th>
                </tr>
    `;
        bookings.forEach(booking => {
            const row = document.createElement('tr');
            row.innerHTML = `
                <tr>
                    <td>${booking.bookingID}</td> <td>${booking.totalPrice}</td> <td>${booking.dateOfBooking}</td> <td>${booking.bookingStatus}</td>
                    <td>
                        <button onclick="viewBill('${booking.bookingID}')">Show Bill</button>
                    </td>
                </tr>
        `;
            bookingTable.appendChild(row);
        });
    }
}
const cartItemContainer = document.getElementById('cart-item-div') as HTMLDivElement;
const purchaseAllButton = document.getElementById("new-order-btn") as HTMLButtonElement;
const totalPriceText = document.getElementById("showTotalPrice") as HTMLHeadingElement;
const emptyCartDiv = document.getElementById("empty-cart") as HTMLDivElement;
//wishlists
async function Wishlists() {
    displayNone();
    customerCartItemsPage.style.display = "block";
    var orders = await APICALLS.FetchCarts(currentCustomer.customerID);
    cartItemContainer.innerHTML = '';
    emptyCartDiv.innerHTML = '';
    displayCartItems(orders);
}
//showing wishlists 
async function displayCartItems(wishlist: Wishlist[]) {
    const emptyCart = document.createElement('h2');
    if (wishlist.length == 0) {
        emptyCart.textContent = 'No cart list found';
        emptyCart.className = 'empty';
        purchaseAllButton.style.display = "none";
        totalPriceText.style.display = "none";
        emptyCartDiv.appendChild(emptyCart);
    }
    else {
        emptyCartDiv.innerHTML = '';    
        emptyCart.textContent = '';
        purchaseAllButton.style.display = "block";
        totalPriceText.style.display = "block";
        var totalPrice: number = 0;
        for (const cart of wishlist) {
            const cartItemDiv = document.createElement('div');
            cartItemDiv.className = 'cart';
            var product = await APICALLS.GetIndividualProduct(cart.roomID);
            if (product != null) {
                const imageDiv = document.createElement('div');
                imageDiv.className = 'cart-div';
                const productImage = document.createElement('img');
                productImage.src = product.roomImage;
                productImage.alt = product.roomType;
                imageDiv.appendChild(productImage);
                cartItemDiv.appendChild(imageDiv);
                const detailsDiv = document.createElement('div');
                detailsDiv.className = 'cart-div';
                const roomType = document.createElement('h2');
                roomType.textContent = product.roomType;
                const productPrice = document.createElement('p');
                productPrice.textContent = `Price: $${cart.priceOfRoom} | No of beds: ${cart.purchaseCount}`;
                const startdate = document.createElement('p');
                startdate.textContent = `Start date: ${new Date(cart.stayingFrom).toLocaleDateString()} | enddate : ${new Date(cart.stayingTo).toLocaleDateString()}`;
                detailsDiv.appendChild(roomType);
                detailsDiv.appendChild(productPrice);
                detailsDiv.appendChild(startdate);
                const modifyButton = document.createElement('button');
                modifyButton.textContent = 'Edit Room';
                modifyButton.style.backgroundColor = "red";
                modifyButton.onclick = () => {
                    ModifyCartCount(cart.wishlistID);
                };
                const outOfStock = document.createElement('p');
                if (product.numberOfBeds >= cart.purchaseCount) {
                    const buyButton = document.createElement('button');
                    buyButton.textContent = 'Book Room';
                    buyButton.disabled = false;
                    buyButton.style.backgroundColor = "#28a745";
                    buyButton.style.cursor = 'allowed';
                    totalPrice += cart.priceOfRoom;
                    outOfStock.textContent = '';
                    detailsDiv.appendChild(buyButton);
                    buyButton.onclick = () => {
                        BuySingleCartItem(cart.wishlistID);
                    };
                }
                else {
                    const buyButton = document.createElement('button');
                    buyButton.textContent = 'Book Room';
                    buyButton.disabled = true;
                    buyButton.style.backgroundColor = 'gray';
                    buyButton.style.cursor = 'not-allowed';
                    outOfStock.textContent = 'Out Of Stock';
                    outOfStock.style.color = 'Gray';
                    detailsDiv.appendChild(buyButton);
                }
                detailsDiv.appendChild(modifyButton);
                detailsDiv.appendChild(outOfStock);
                cartItemDiv.appendChild(detailsDiv);
                //Delete Icon 
                const cancelIcon = document.createElement('img');
                cancelIcon.src = "Images/Close Icon.svg";
                cancelIcon.alt = "Delete Icon";
                cancelIcon.className = 'cancel-icon';
                cartItemDiv.appendChild(cancelIcon);
                cancelIcon.onclick = function () {
                    DeleteTempCartDetail(cart.wishlistID);
                }
                cartItemContainer.appendChild(cartItemDiv);
            }
        }
        totalPriceText.innerHTML = `Total Price: $${Math.abs(totalPrice)}`;
    }
}
async function BuySingleCartItem(cartID: string) {
    var orderConfirmation = await APICALLS.BuySingleItem(cartID, currentCustomer.customerID);
    currentCustomer = <CustomerRegistration>await APICALLS.GetIndividualUser(currentCustomer.mailID, currentCustomer.password);
    alert(orderConfirmation);
    Wishlists();
}
async function DeleteTempCartDetail(cartID: string) {
    const deleteProduct = confirm('Do you want to delete this cart');
    if (deleteProduct) {
        await APICALLS.DeleteCartDetail(currentCustomer.customerID, cartID);
        alert("Room deleted successfully.");
        Wishlists();
    }
}
const modifydate = document.getElementById("modifydate") as HTMLDivElement;
async function ModifyCartCount(cartID: string) {
    alert("modify")
    var len = modifydate.getElementsByTagName("div").length;
    if (modifydate.hasChildNodes()) {
        for (var i = len - 1; i >= 0; i--) {
            modifydate.removeChild(modifydate.children[i]);
        }
    }
    const inputdiv = document.createElement('div');
    inputdiv.className = "getdate";
    inputdiv.innerHTML = `<p style="color: green;">From-date</p> 
    <input type="Date" id ="startdatemodify"  name="startdate" required style="background-color: lightgreen; color: white; border-color: white"> 
    <p style="color: red;">To-date</p> 
    <input type="Date" id ="enddatemodify" name="enddatemodify" required style="background-color: lightcoral; color: white; border-color: white">
    <input type="hidden" id ="productIDmodify" value=${cartID} name="quantity" required>
    <br><br>
    <button onclick="submitDatemodify()" style="background-color: green; color: white; border-color: white">SUBMIT</button>
    `;
    modifydate.appendChild(inputdiv);
    modifydate.style.display = "block";
    modifydate.style.textAlign = "center";
}
//submission of the user details
async function submitDatemodify() {
    const startdateele = document.getElementById("startdatemodify") as HTMLInputElement;
    const enddateele = document.getElementById("enddatemodify") as HTMLInputElement;
    const productIDele = document.getElementById("productIDmodify") as HTMLInputElement;
    let startdate = startdateele.value;
    let enddate = enddateele.value;
    let productid = productIDele.value;
    modifydate.style.display = "none";
    await APICALLS.UpdateCartQuantity(currentCustomer.customerID, productid, startdate, enddate);
    alert('WishList Modified Successfully.');
    Wishlists();
}
//displaying bill to the user
async function viewBill(bookingID: string) {
    let currentBooking: RoomSelection = <RoomSelection>await APICALLS.GetIndividualBooking(bookingID);
    billContentDiv.innerHTML = '';
    var purchases = await APICALLS.FetchPurchases(bookingID);
    displayBillContent(currentBooking, purchases);
}
//bill content
async function displayBillContent(booking: RoomSelection, purchases: RoomSelection[]) {
    alert("Bill")
    const billContainer = document.createElement('div');
    billContainer.className = 'bill-container';
    if (booking.bookingStatus == "Booked") {
        const cancelButton = document.createElement('button');
        cancelButton.textContent = 'Cancel Booking';
        cancelButton.disabled = false;
        cancelButton.style.backgroundColor = '#3271a5';
        cancelButton.style.cursor = 'allowed';
        billContainer.appendChild(cancelButton);
        cancelButton.onclick = () => {
            deleteSpecificBooking(booking.bookingID);
        };
    }
    else {
        const cancelButton = document.createElement('button');
        cancelButton.textContent = 'Cancel Booking';
        cancelButton.disabled = true;
        cancelButton.style.backgroundColor = 'gray';
        cancelButton.style.cursor = 'not-allowed';
        billContainer.appendChild(cancelButton);
    }
    const bookingSection = document.createElement('div');
    bookingSection.className = 'booking-details';
    bookingSection.innerHTML = `
        <h3>Booking ID: ${booking.bookingID}</h3>
        <p>Name: ${currentCustomer.name} |</p>
        <p>Status: ${booking.bookingStatus}</p>
    `;
    billContainer.appendChild(bookingSection);
    const itemsSection = document.createElement('div');
    itemsSection.className = 'purchased-items';
    const itemsTable = document.createElement('table');
    itemsTable.className = 'items-table';
    itemsTable.innerHTML = `
        <tr>
            <th>Room Type</th>
            <th>Number of days</th>
            <th>Total Price</th>
        </tr>
    `;
    for (let item of purchases) {
        let productDetail = await APICALLS.GetIndividualProduct(item.roomID);
        const row = document.createElement('tr');
        row.innerHTML = `
            <td>${productDetail?.roomType}</td>
            <td>${item.numberOfDays}</td>
            <td>$${item.price}</td>
        `;
        itemsTable.appendChild(row);
    };
    itemsSection.appendChild(itemsTable);
    billContainer.appendChild(itemsSection);
    const totalRow = document.createElement('div');//creating element 
    billContainer.appendChild(totalRow);
    billContentDiv.appendChild(billContainer);
}
//delete the specific booking 
async function deleteSpecificBooking(bookingID: string) {
    var deleteBooking = await APICALLS.cancelBooking(bookingID, currentCustomer.customerID);
    alert(deleteBooking);
    currentCustomer = <CustomerRegistration>await APICALLS.GetIndividualUser(currentCustomer.mailID, currentCustomer.password);
    OrderHistory();
}
async function LogOut() {
    displayNone();
    (document.getElementById("menu") as HTMLDivElement).style.display = "none";
    (document.getElementById("box") as HTMLDivElement).style.display = "block";
    signIn.style.display = "block";
}
const functions = { home, signInPage, signUpPage, displayNone, submitForm, signInSubmit, CustomerDetails, submitDatemodify, ShowRoomDetails, deleteProduct, editChosenProduct, editProduct, NewProductPage, addProduct, RechargeWallet, deposit, BookRoom, displayProducts, AddToCart, Wishlists, displayCartItems, ModifyCartCount, DeleteTempCartDetail, submitDate, BuySingleCartItem, viewBill, displayBillContent, deleteSpecificBooking, PurchaseAllItems, OrderHistory, LogOut }
Object.assign(window, functions)  