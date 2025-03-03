"use strict";
var __assign = (this && this.__assign) || function () {
    __assign = Object.assign || function(t) {
        for (var s, i = 1, n = arguments.length; i < n; i++) {
            s = arguments[i];
            for (var p in s) if (Object.prototype.hasOwnProperty.call(s, p))
                t[p] = s[p];
        }
        return t;
    };
    return __assign.apply(this, arguments);
};
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g = Object.create((typeof Iterator === "function" ? Iterator : Object).prototype);
    return g.next = verb(0), g["throw"] = verb(1), g["return"] = verb(2), typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (g && (g = 0, op[0] && (_ = 0)), _) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
Object.defineProperty(exports, "__esModule", { value: true });
var APICALLS = require("./apicalls.js");
//Getting available pages by id
var signIn = document.getElementById("signIn");
var signUp = document.getElementById("signUp");
var homePage = document.getElementById("homePage");
var signInButton = document.getElementById("signInButton");
var signUpButton = document.getElementById("signUpButton");
var userProfilePage = document.getElementById("UserProfilePage");
var productProfilePage = document.getElementById("ProductProfilePage");
var walletRechargePage = document.getElementById("walletRechargePage");
var takeOrderPage = document.getElementById("TakeOrderPage");
var addNewProductPage = document.getElementById("addNewProduct");
var editProductPage = document.getElementById("editProduct");
var customerCartItemsPage = document.getElementById("CustomerCartItemsPage");
var orderHistoryPage = document.getElementById("OrderHistoryPage");
//Storing the details of current customer
var currentCustomer;
function displayNone() {
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
function signInPage() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            signIn.style.display = "block";
            signUp.style.display = "none";
            signInButton.style.background = "rgb(247, 191, 113)";
            signUpButton.style.background = "none";
            return [2 /*return*/];
        });
    });
}
function signUpPage() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            signUp.style.display = "block";
            signIn.style.display = "none";
            signInButton.style.background = "none";
            signUpButton.style.background = "rgb(247, 191, 113)";
            return [2 /*return*/];
        });
    });
}
// Function to handle form submission
function submitForm(event) {
    return __awaiter(this, void 0, void 0, function () {
        var name, fatherName, gender, mobile, dob, email, password, walletBalance, profilePhotoFile, isavail, profilePhotoBase64, newCustomer, signInBorder;
        var _a;
        return __generator(this, function (_b) {
            switch (_b.label) {
                case 0:
                    event.preventDefault();
                    name = document.getElementById("name").value;
                    fatherName = document.getElementById("fatherName").value;
                    gender = document.getElementById("gender").value;
                    mobile = document.getElementById("mobile").value;
                    dob = document.getElementById("dob").value;
                    email = document.getElementById("email").value;
                    password = document.getElementById("password").value;
                    walletBalance = parseFloat(document.getElementById("walletBalance").value);
                    profilePhotoFile = (_a = document.getElementById("profilePhoto").files) === null || _a === void 0 ? void 0 : _a[0];
                    return [4 /*yield*/, APICALLS.CheckCustomer(email)];
                case 1:
                    isavail = _b.sent();
                    if (!!isavail) return [3 /*break*/, 5];
                    profilePhotoBase64 = "";
                    if (!profilePhotoFile) return [3 /*break*/, 3];
                    return [4 /*yield*/, convertToBase64(profilePhotoFile)];
                case 2:
                    profilePhotoBase64 = _b.sent(); // Convert the image to Base64
                    _b.label = 3;
                case 3: return [4 /*yield*/, APICALLS.AddNewCustomer({ customerID: "", name: name, fatherName: fatherName, gender: gender, mobileNumber: mobile, dob: dob, mailID: email, password: password, walletBalance: walletBalance, profilePhoto: profilePhotoBase64 })];
                case 4:
                    newCustomer = _b.sent();
                    document.getElementById("name").value = "";
                    document.getElementById("fatherName").value = "";
                    document.getElementById("gender").value = "";
                    document.getElementById("mobile").value = "";
                    document.getElementById("dob").value = "";
                    document.getElementById("email").value = "";
                    document.getElementById("password").value = "";
                    document.getElementById("walletBalance").value = "";
                    document.getElementById("profilePhoto").value = "";
                    console.log(profilePhotoBase64);
                    alert("Registration Successful. Your Customer ID is ".concat(newCustomer, "."));
                    return [3 /*break*/, 6];
                case 5:
                    signInBorder = document.getElementById("signUp");
                    signInBorder.style.border = "0.5px solid red";
                    alert("Already exist");
                    _b.label = 6;
                case 6: return [2 /*return*/];
            }
        });
    });
}
//Sign In method
function signInSubmit(e) {
    return __awaiter(this, void 0, void 0, function () {
        var email, password, customer, boxElement, menu;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    e.preventDefault();
                    email = document.getElementById("email1");
                    password = document.getElementById("password2");
                    if (!email.value || !password.value) {
                        alert("Email and Password cannot be empty");
                        return [2 /*return*/];
                    }
                    return [4 /*yield*/, APICALLS.GetIndividualUser(email.value, password.value)];
                case 1:
                    customer = _a.sent();
                    if (customer == null) {
                        alert("Invalid Email or Password");
                        email.value = "";
                        password.value = "";
                    }
                    else {
                        boxElement = document.getElementById("box");
                        boxElement.style.display = "none";
                        menu = document.getElementById("menu");
                        menu.style.display = "block";
                        currentCustomer = customer;
                        home();
                        email.value = "";
                        password.value = "";
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function home() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            homePage.style.display = "block";
            return [2 /*return*/];
        });
    });
}
function CustomerDetails() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            userProfilePage.style.display = "block";
            document.getElementById('user-profile-card').innerHTML = "\n    <div class=\"profile-photo\">\n          <img src=\"".concat(currentCustomer.profilePhoto, "\">\n    </div>\n    <table class=\"profile-table\">\n        <tr>\n            <th>User ID</th> <td>").concat(currentCustomer.customerID, "</td>\n        </tr>\n        <tr>\n            <th>User Name</th>  <td>").concat(currentCustomer.name, "</td>\n        </tr>\n        <tr>\n            <th>Father Name</th>  <td>").concat(currentCustomer.fatherName, "</td>\n        </tr>\n        <tr>\n            <th>Gender</th>  <td>").concat(currentCustomer.gender, "</td>\n        </tr>\n        <tr>\n            <th>Mobile Number</th>  <td>").concat(currentCustomer.mobileNumber, "</td>\n        </tr>\n        <tr>\n            <th>Mail ID</th>  <td>").concat(currentCustomer.mailID, "</td>    \n        </tr>\n        <tr>\n            <th>DOB</th> <td>").concat(currentCustomer.dob.split('T')[0].split('-').reverse().join('/'), "</td>\n        </tr>\n        <tr>\n            <th>Balance</th> <td>").concat(currentCustomer.walletBalance, "</td>\n        </tr>\n    </table>\n    ");
            return [2 /*return*/];
        });
    });
}
function NewProductPage() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            addNewProductPage.style.display = "block";
            editProductPage.style.display = "none";
            return [2 /*return*/];
        });
    });
}
//Showing product details
function ShowProductDetails() {
    return __awaiter(this, void 0, void 0, function () {
        var products, productTable;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    displayNone();
                    productProfilePage.style.display = "block";
                    return [4 /*yield*/, APICALLS.FetchProducts()];
                case 1:
                    products = _a.sent();
                    productTable = document.getElementById("product-table");
                    productTable.innerHTML = "\n                <tr>\n                    <th>Product Image</th> <th>Product ID</th> <th>Product Name</th> <th>Quantity</th> <th>Price</th> <th>Action</th>\n                </tr>";
                    products.forEach(function (product) {
                        var row = document.createElement('tr');
                        row.innerHTML = "\n                <tr>\n                <td><img src=\"".concat(product.productImage, "\"></td> <td>").concat(product.productID, "</td> <td>").concat(product.productName, "</td>\n                <td>").concat(product.quantityAvailable, "</td> <td>").concat(product.pricePerQuantity, "</td>\n                <td>\n                    <button onclick=\"editChosenProduct('").concat(product.productID, "')\">Edit</button>\n                    <button onclick=\"deleteProduct('").concat(product.productID, "')\">Delete</button>\n                </td>\n                </tr> ");
                        productTable.appendChild(row);
                    });
                    return [2 /*return*/];
            }
        });
    });
}
var currentProduct;
function editChosenProduct(productID) {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    editProductPage.style.display = "block";
                    addNewProductPage.style.display = "none";
                    return [4 /*yield*/, APICALLS.GetIndividualProduct(productID)];
                case 1:
                    currentProduct = _a.sent();
                    if (currentProduct != null) {
                        document.getElementById("editProductName").value = currentProduct.productName;
                        document.getElementById("editProductQuantity").value = String(currentProduct.quantityAvailable);
                        document.getElementById("editProductPrice").value = String(currentProduct.pricePerQuantity);
                    }
                    else {
                        alert("Product not found");
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function addProduct(e) {
    return __awaiter(this, void 0, void 0, function () {
        var productName, quantity, price, isProductValid, productPhotoFile, productPhotoBase64, newProduct;
        var _a;
        return __generator(this, function (_b) {
            switch (_b.label) {
                case 0:
                    e.preventDefault();
                    productName = document.getElementById("productName").value;
                    quantity = parseFloat(document.getElementById("productQuantity").value);
                    price = parseFloat(document.getElementById("productPrice").value);
                    return [4 /*yield*/, APICALLS.CheckProductExist(productName)];
                case 1:
                    isProductValid = _b.sent();
                    if (!isProductValid) return [3 /*break*/, 2];
                    document.getElementById("productName").value = "";
                    document.getElementById("productQuantity").value = "";
                    document.getElementById("productPrice").value = "";
                    document.getElementById("add-photo").value = "";
                    alert("This product already exists");
                    return [3 /*break*/, 6];
                case 2:
                    productPhotoFile = (_a = document.getElementById("add-photo").files) === null || _a === void 0 ? void 0 : _a[0];
                    productPhotoBase64 = "";
                    if (!productPhotoFile) return [3 /*break*/, 4];
                    return [4 /*yield*/, convertToBase64(productPhotoFile)];
                case 3:
                    productPhotoBase64 = _b.sent(); // Convert the image to Base64
                    _b.label = 4;
                case 4: return [4 /*yield*/, APICALLS.AddNewProduct({ productID: "", productName: productName, quantityAvailable: quantity, pricePerQuantity: price, productImage: productPhotoBase64 })];
                case 5:
                    newProduct = _b.sent();
                    document.getElementById("productName").value = "";
                    document.getElementById("productQuantity").value = "";
                    document.getElementById("productPrice").value = "";
                    document.getElementById("add-photo").value = "";
                    alert("Product added successfully. Product ID is ".concat(newProduct));
                    _b.label = 6;
                case 6:
                    ShowProductDetails();
                    return [2 /*return*/];
            }
        });
    });
}
function editProduct(e) {
    return __awaiter(this, void 0, void 0, function () {
        var Name, quantity, price, productPhotoFile, productPhotoBase64;
        var _a;
        return __generator(this, function (_b) {
            switch (_b.label) {
                case 0:
                    e.preventDefault();
                    if (!(currentProduct != null)) return [3 /*break*/, 4];
                    Name = document.getElementById("editProductName").value;
                    quantity = parseFloat(document.getElementById("editProductQuantity").value);
                    price = parseFloat(document.getElementById("editProductPrice").value);
                    productPhotoFile = (_a = document.getElementById("edit-photo").files) === null || _a === void 0 ? void 0 : _a[0];
                    productPhotoBase64 = "";
                    if (!productPhotoFile) return [3 /*break*/, 2];
                    return [4 /*yield*/, convertToBase64(productPhotoFile)];
                case 1:
                    productPhotoBase64 = _b.sent(); // Convert the image to Base64
                    _b.label = 2;
                case 2: return [4 /*yield*/, APICALLS.EditProductDetail({ productID: currentProduct.productID, productName: Name, quantityAvailable: quantity, pricePerQuantity: price, productImage: productPhotoBase64 })];
                case 3:
                    _b.sent();
                    alert("Product modified successfully.");
                    document.getElementById("editProductName").value = "";
                    document.getElementById("editProductQuantity").value = "";
                    document.getElementById("editProductPrice").value = "";
                    document.getElementById("edit-photo").value = "";
                    ShowProductDetails();
                    _b.label = 4;
                case 4: return [2 /*return*/];
            }
        });
    });
}
function deleteProduct(productID) {
    return __awaiter(this, void 0, void 0, function () {
        var deleteProduct;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    deleteProduct = confirm('Do you want to delete this product');
                    if (!deleteProduct) return [3 /*break*/, 2];
                    return [4 /*yield*/, APICALLS.DeleteProductDetail(productID)];
                case 1:
                    _a.sent();
                    alert("Product deleted successfully.");
                    _a.label = 2;
                case 2:
                    ShowProductDetails();
                    return [2 /*return*/];
            }
        });
    });
}
//Wallet Recharge Page
function RechargeWallet() {
    displayNone();
    walletRechargePage.style.display = "block";
    document.getElementById("currentBalance").innerHTML = "Available Balance : ".concat(currentCustomer.walletBalance);
}
//function for recharge
function deposit() {
    return __awaiter(this, void 0, void 0, function () {
        var amount1, customer;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    amount1 = document.getElementById("amount").value;
                    return [4 /*yield*/, APICALLS.RechargeWalletBalance(currentCustomer.customerID, Number(amount1))];
                case 1:
                    _a.sent();
                    return [4 /*yield*/, APICALLS.GetIndividualUser(currentCustomer.mailID, currentCustomer.password)];
                case 2:
                    customer = _a.sent();
                    currentCustomer = customer;
                    document.getElementById("amount").value = "";
                    alert("Recharge Successful. Your current balance is ".concat(currentCustomer.walletBalance));
                    RechargeWallet();
                    return [2 /*return*/];
            }
        });
    });
}
//function for taking order
function TakeOrder() {
    return __awaiter(this, void 0, void 0, function () {
        var products;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    displayNone();
                    takeOrderPage.style.display = "block";
                    return [4 /*yield*/, APICALLS.FetchProducts()];
                case 1:
                    products = _a.sent();
                    productContainer.innerHTML = '';
                    displayProducts(products);
                    return [2 /*return*/];
            }
        });
    });
}
var productContainer = document.getElementById('product-container');
function displayProducts(products) {
    products.forEach(function (product) {
        var productDiv = document.createElement('div');
        productDiv.className = 'product';
        // Create image
        var productImage = document.createElement('img');
        productImage.src = product.productImage;
        productImage.alt = product.productName;
        productDiv.appendChild(productImage);
        // Create product name
        var productName = document.createElement('h2');
        productName.textContent = product.productName;
        productDiv.appendChild(productName);
        // Create product details (quantity, price)
        var productDetails = document.createElement('p');
        productDetails.textContent = "Available: ".concat(product.quantityAvailable, " | Price: $").concat(product.pricePerQuantity);
        productDiv.appendChild(productDetails);
        // Create button
        var button = document.createElement('button');
        button.textContent = 'Add to Cart';
        productDiv.appendChild(button);
        button.onclick = function () {
            AddToCart(product.productID);
        };
        // Append to the container
        productContainer.appendChild(productDiv);
    });
}
function AddToCart(productID) {
    return __awaiter(this, void 0, void 0, function () {
        var quantity, quantityNumber, selectedProduct, cartID;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    quantity = prompt("Enter the quantity you want to purchase");
                    quantityNumber = Number(quantity);
                    if (!(isNaN(quantityNumber) || quantityNumber <= 0)) return [3 /*break*/, 1];
                    alert("Please enter a valid quantity greater than 0.");
                    return [3 /*break*/, 4];
                case 1: return [4 /*yield*/, APICALLS.GetIndividualProduct(productID)];
                case 2:
                    selectedProduct = _a.sent();
                    if (!(selectedProduct != null)) return [3 /*break*/, 4];
                    return [4 /*yield*/, APICALLS.AddItemToCart({ cartID: "", customerID: currentCustomer.customerID, productID: selectedProduct.productID, purchaseCount: quantityNumber, priceOfCart: quantityNumber * selectedProduct.pricePerQuantity, productImage: selectedProduct.productImage })];
                case 3:
                    cartID = _a.sent();
                    alert("".concat(selectedProduct.productName, " added to cart list with ").concat(quantityNumber, " quantity. Your OrderID is ").concat(cartID));
                    _a.label = 4;
                case 4:
                    TakeOrder();
                    return [2 /*return*/];
            }
        });
    });
}
var cartItemContainer = document.getElementById('cart-item-div');
function CartItems() {
    return __awaiter(this, void 0, void 0, function () {
        var orders;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    displayNone();
                    customerCartItemsPage.style.display = "block";
                    return [4 /*yield*/, APICALLS.FetchCarts(currentCustomer.customerID)];
                case 1:
                    orders = _a.sent();
                    cartItemContainer.innerHTML = '';
                    emptyCartDiv.innerHTML = '';
                    displayCartItems(orders);
                    return [2 /*return*/];
            }
        });
    });
}
var purchaseAllButton = document.getElementById("new-order-btn");
var totalPriceText = document.getElementById("showTotalPrice");
var emptyCartDiv = document.getElementById("empty-cart");
function displayCartItems(carts) {
    return __awaiter(this, void 0, void 0, function () {
        var emptyCart, totalPrice, _loop_1, product, _i, carts_1, cart;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    emptyCart = document.createElement('h2');
                    if (!(carts.length == 0)) return [3 /*break*/, 1];
                    emptyCart.textContent = 'Cart Wish List is Empty';
                    emptyCart.className = 'empty';
                    purchaseAllButton.style.display = "none";
                    totalPriceText.style.display = "none";
                    emptyCartDiv.appendChild(emptyCart);
                    return [3 /*break*/, 6];
                case 1:
                    emptyCartDiv.innerHTML = '';
                    emptyCart.textContent = '';
                    purchaseAllButton.style.display = "block";
                    totalPriceText.style.display = "block";
                    totalPrice = 0;
                    _loop_1 = function (cart) {
                        var cartItemDiv, imageDiv, productImage, detailsDiv, productTitle, productPrice, modifyButton, outOfStock, buyButton, buyButton, cancelIcon;
                        return __generator(this, function (_b) {
                            switch (_b.label) {
                                case 0:
                                    cartItemDiv = document.createElement('div');
                                    cartItemDiv.className = 'cart';
                                    return [4 /*yield*/, APICALLS.GetIndividualProduct(cart.productID)];
                                case 1:
                                    product = _b.sent();
                                    if (product != null) {
                                        imageDiv = document.createElement('div');
                                        imageDiv.className = 'cart-div';
                                        productImage = document.createElement('img');
                                        productImage.src = product.productImage;
                                        productImage.alt = product.productName;
                                        imageDiv.appendChild(productImage);
                                        cartItemDiv.appendChild(imageDiv);
                                        detailsDiv = document.createElement('div');
                                        detailsDiv.className = 'cart-div';
                                        productTitle = document.createElement('h2');
                                        productTitle.textContent = product.productName;
                                        productPrice = document.createElement('p');
                                        productPrice.textContent = "Price: $".concat(cart.priceOfCart, " | Quantity: ").concat(cart.purchaseCount);
                                        detailsDiv.appendChild(productTitle);
                                        detailsDiv.appendChild(productPrice);
                                        modifyButton = document.createElement('button');
                                        modifyButton.textContent = 'Modify';
                                        modifyButton.onclick = function () {
                                            ModifyCartCount(cart.cartID);
                                        };
                                        outOfStock = document.createElement('p');
                                        if (product.quantityAvailable >= cart.purchaseCount) {
                                            buyButton = document.createElement('button');
                                            buyButton.textContent = 'Buy';
                                            buyButton.disabled = false;
                                            buyButton.style.backgroundColor = "#28a745";
                                            buyButton.style.cursor = 'allowed';
                                            totalPrice += cart.priceOfCart;
                                            outOfStock.textContent = '';
                                            detailsDiv.appendChild(buyButton);
                                            buyButton.onclick = function () {
                                                BuySingleCartItem(cart.cartID);
                                            };
                                        }
                                        else {
                                            buyButton = document.createElement('button');
                                            buyButton.textContent = 'Buy';
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
                                        cancelIcon = document.createElement('img');
                                        cancelIcon.src = "Images/Close Icon.svg";
                                        cancelIcon.alt = "Delete Icon";
                                        cancelIcon.className = 'cancel-icon';
                                        cartItemDiv.appendChild(cancelIcon);
                                        cancelIcon.onclick = function () {
                                            DeleteTempCartDetail(cart.cartID);
                                        };
                                        cartItemContainer.appendChild(cartItemDiv);
                                    }
                                    return [2 /*return*/];
                            }
                        });
                    };
                    _i = 0, carts_1 = carts;
                    _a.label = 2;
                case 2:
                    if (!(_i < carts_1.length)) return [3 /*break*/, 5];
                    cart = carts_1[_i];
                    return [5 /*yield**/, _loop_1(cart)];
                case 3:
                    _a.sent();
                    _a.label = 4;
                case 4:
                    _i++;
                    return [3 /*break*/, 2];
                case 5:
                    totalPriceText.innerHTML = "Total Price: $".concat(totalPrice);
                    _a.label = 6;
                case 6: return [2 /*return*/];
            }
        });
    });
}
function DeleteTempCartDetail(cartID) {
    return __awaiter(this, void 0, void 0, function () {
        var deleteProduct;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    deleteProduct = confirm('Do you want to delete this cart');
                    if (!deleteProduct) return [3 /*break*/, 2];
                    return [4 /*yield*/, APICALLS.DeleteCartDetail(currentCustomer.customerID, cartID)];
                case 1:
                    _a.sent();
                    alert("Order deleted successfully.");
                    CartItems();
                    _a.label = 2;
                case 2: return [2 /*return*/];
            }
        });
    });
}
function ModifyCartCount(cartID) {
    return __awaiter(this, void 0, void 0, function () {
        var quantity, quantityNumber;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    quantity = prompt("Enter the quantity you want to purchase");
                    quantityNumber = Number(quantity);
                    if (!(isNaN(quantityNumber) || quantityNumber <= 0)) return [3 /*break*/, 1];
                    alert("Please enter a valid quantity greater than 0.");
                    return [3 /*break*/, 3];
                case 1: return [4 /*yield*/, APICALLS.UpdateCartQuantity(currentCustomer.customerID, cartID, quantityNumber)];
                case 2:
                    _a.sent();
                    alert('Order Modified Successfully.');
                    _a.label = 3;
                case 3:
                    CartItems();
                    return [2 /*return*/];
            }
        });
    });
}
function PurchaseAllItems() {
    return __awaiter(this, void 0, void 0, function () {
        var bookingStatus;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, APICALLS.purchaseAll(currentCustomer.customerID)];
                case 1:
                    bookingStatus = _a.sent();
                    return [4 /*yield*/, APICALLS.GetIndividualUser(currentCustomer.mailID, currentCustomer.password)];
                case 2:
                    currentCustomer = (_a.sent());
                    alert(bookingStatus);
                    CartItems();
                    return [2 /*return*/];
            }
        });
    });
}
var billContentDiv = document.getElementById('bill-content');
function displayBillContent(booking, purchases) {
    return __awaiter(this, void 0, void 0, function () {
        var billContainer, downloadButton, cancelButton, cancelButton, bookingSection, itemsSection, itemsTable, _i, purchases_1, item, productDetail, row, totalRow, totalAmount;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    billContainer = document.createElement('div');
                    billContainer.className = 'bill-container';
                    downloadButton = document.createElement('span');
                    downloadButton.textContent = 'Download Bill';
                    downloadButton.style.backgroundColor = '#3271a5';
                    downloadButton.style.cursor = 'allowed';
                    billContainer.appendChild(downloadButton);
                    if (booking.bookingStatus == "Booked") {
                        cancelButton = document.createElement('button');
                        cancelButton.textContent = 'Cancel Booking';
                        cancelButton.disabled = false;
                        cancelButton.style.backgroundColor = '#3271a5';
                        cancelButton.style.cursor = 'allowed';
                        billContainer.appendChild(cancelButton);
                        cancelButton.onclick = function () {
                            deleteSpecificBooking(booking.bookingID);
                        };
                    }
                    else {
                        cancelButton = document.createElement('button');
                        cancelButton.textContent = 'Cancel Booking';
                        cancelButton.disabled = true;
                        cancelButton.style.backgroundColor = 'gray';
                        cancelButton.style.cursor = 'not-allowed';
                        billContainer.appendChild(cancelButton);
                    }
                    bookingSection = document.createElement('div');
                    bookingSection.className = 'booking-details';
                    bookingSection.innerHTML = "\n        <h3>Booking ID: ".concat(booking.bookingID, "</h3>\n        <p>Name: ").concat(currentCustomer.name, " |</p>\n        <p>Booking Date: ").concat(booking.dateOfBooking, " |</p>\n        <p>Status: ").concat(booking.bookingStatus, "</p>\n    ");
                    billContainer.appendChild(bookingSection);
                    itemsSection = document.createElement('div');
                    itemsSection.className = 'purchased-items';
                    itemsTable = document.createElement('table');
                    itemsTable.className = 'items-table';
                    itemsTable.innerHTML = "\n        <tr>\n            <th>Name</th>\n            <th>Quantity</th>\n            <th>Price</th>\n        </tr>\n    ";
                    _i = 0, purchases_1 = purchases;
                    _a.label = 1;
                case 1:
                    if (!(_i < purchases_1.length)) return [3 /*break*/, 4];
                    item = purchases_1[_i];
                    return [4 /*yield*/, APICALLS.GetIndividualProduct(item.productID)];
                case 2:
                    productDetail = _a.sent();
                    row = document.createElement('tr');
                    row.innerHTML = "\n            <td>".concat(productDetail === null || productDetail === void 0 ? void 0 : productDetail.productName, "</td>\n            <td>").concat(item.purchaseCount, "</td>\n            <td>$").concat(item.priceOfPurchase, "</td>\n        ");
                    itemsTable.appendChild(row);
                    _a.label = 3;
                case 3:
                    _i++;
                    return [3 /*break*/, 1];
                case 4:
                    ;
                    itemsSection.appendChild(itemsTable);
                    billContainer.appendChild(itemsSection);
                    totalRow = document.createElement('div');
                    totalRow.className = 'total-price';
                    totalAmount = booking.totalPrice;
                    totalRow.innerHTML = "<h3>Total: $".concat(totalAmount, "</h3>");
                    billContainer.appendChild(totalRow);
                    billContentDiv.appendChild(billContainer);
                    return [2 /*return*/];
            }
        });
    });
}
function OrderHistory() {
    return __awaiter(this, void 0, void 0, function () {
        var bookings, bookingTable, emptyCart;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    displayNone();
                    orderHistoryPage.style.display = "block";
                    billContentDiv.innerHTML = '';
                    return [4 /*yield*/, APICALLS.FetchAllBookings(currentCustomer.customerID)];
                case 1:
                    bookings = _a.sent();
                    bookingTable = document.getElementById("booking-table");
                    if (bookings.length == 0) {
                        bookingTable.innerHTML = '';
                        emptyCart = document.createElement('h2');
                        emptyCart.textContent = 'No Bookings Found';
                        emptyCart.className = 'empty';
                        billContentDiv.appendChild(emptyCart);
                    }
                    else {
                        bookingTable.innerHTML = "\n                <tr>\n                    <th>Booking ID</th>  <th>Total Price</th> <th>Date Of Booking</th> <th>Booking Status</th> <th>Action</th>\n                </tr>\n    ";
                        bookings.forEach(function (booking) {
                            var row = document.createElement('tr');
                            row.innerHTML = "\n                <tr>\n                    <td>".concat(booking.bookingID, "</td> <td>").concat(booking.totalPrice, "</td> <td>").concat(booking.dateOfBooking, "</td> <td>").concat(booking.bookingStatus, "</td>\n                    <td>\n                        <button onclick=\"viewBill('").concat(booking.bookingID, "')\">View Bill</button>\n                    </td>\n                </tr>\n        ");
                            bookingTable.appendChild(row);
                        });
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function viewBill(bookingID) {
    return __awaiter(this, void 0, void 0, function () {
        var currentBooking, purchases;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, APICALLS.GetIndividualBooking(bookingID)];
                case 1:
                    currentBooking = _a.sent();
                    billContentDiv.innerHTML = '';
                    return [4 /*yield*/, APICALLS.FetchPurchases(bookingID)];
                case 2:
                    purchases = _a.sent();
                    displayBillContent(currentBooking, purchases);
                    return [2 /*return*/];
            }
        });
    });
}
function BuySingleCartItem(cartID) {
    return __awaiter(this, void 0, void 0, function () {
        var orderConfirmation;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, APICALLS.BuySingleItem(cartID, currentCustomer.customerID)];
                case 1:
                    orderConfirmation = _a.sent();
                    return [4 /*yield*/, APICALLS.GetIndividualUser(currentCustomer.mailID, currentCustomer.password)];
                case 2:
                    currentCustomer = (_a.sent());
                    alert(orderConfirmation);
                    CartItems();
                    return [2 /*return*/];
            }
        });
    });
}
function deleteSpecificBooking(bookingID) {
    return __awaiter(this, void 0, void 0, function () {
        var deleteBooking;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, APICALLS.cancelBooking(bookingID, currentCustomer.customerID)];
                case 1:
                    deleteBooking = _a.sent();
                    alert(deleteBooking);
                    return [4 /*yield*/, APICALLS.GetIndividualUser(currentCustomer.mailID, currentCustomer.password)];
                case 2:
                    currentCustomer = (_a.sent());
                    OrderHistory();
                    return [2 /*return*/];
            }
        });
    });
}
//Function for log out
function LogOut() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            document.getElementById("menu").style.display = "none";
            document.getElementById("box").style.display = "block";
            signIn.style.display = "block";
            return [2 /*return*/];
        });
    });
}
// Function to convert file to Base64 string
function convertToBase64(file) {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            return [2 /*return*/, new Promise(function (resolve, reject) {
                    var reader = new FileReader();
                    reader.onloadend = function () { return resolve(reader.result); };
                    reader.onerror = reject;
                    reader.readAsDataURL(file);
                })];
        });
    });
}
var functions = __assign({ home: home, signInPage: signInPage, signUpPage: signUpPage, LogOut: LogOut, viewBill: viewBill, deleteSpecificBooking: deleteSpecificBooking, BuySingleCartItem: BuySingleCartItem, OrderHistory: OrderHistory, CartItems: CartItems, AddToCart: AddToCart, addProduct: addProduct, deposit: deposit, deleteProduct: deleteProduct, editProduct: editProduct, editChosenProduct: editChosenProduct, PurchaseAllItems: PurchaseAllItems, NewProductPage: NewProductPage, CustomerDetails: CustomerDetails, signInSubmit: signInSubmit, submitForm: submitForm, displayProducts: displayProducts, TakeOrder: TakeOrder, displayBillContent: displayBillContent, ShowProductDetails: ShowProductDetails, RechargeWallet: RechargeWallet, displayNone: displayNone }, APICALLS);
Object.assign(window, functions);
