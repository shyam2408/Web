"use strict";
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
exports.CheckCustomer = CheckCustomer;
exports.AddNewCustomer = AddNewCustomer;
exports.GetIndividualUser = GetIndividualUser;
exports.FetchProducts = FetchProducts;
exports.GetIndividualProduct = GetIndividualProduct;
exports.AddNewProduct = AddNewProduct;
exports.CheckProductExist = CheckProductExist;
exports.EditProductDetail = EditProductDetail;
exports.DeleteProductDetail = DeleteProductDetail;
exports.RechargeWalletBalance = RechargeWalletBalance;
exports.AddItemToCart = AddItemToCart;
exports.UpdateCartQuantity = UpdateCartQuantity;
exports.FetchCarts = FetchCarts;
exports.DeleteCartDetail = DeleteCartDetail;
exports.purchaseAll = purchaseAll;
exports.FetchAllBookings = FetchAllBookings;
exports.FetchPurchases = FetchPurchases;
exports.BuySingleItem = BuySingleItem;
exports.cancelBooking = cancelBooking;
exports.GetIndividualBooking = GetIndividualBooking;
function CheckCustomer(mailID) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/customercontroller/".concat(mailID);
                    return [4 /*yield*/, fetch(apiURL)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to fetch data");
                    }
                    return [4 /*yield*/, response.json()];
                case 2: 
                //returns true if the customer is already exist
                return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function AddNewCustomer(customer) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/customercontroller/newUser/".concat(customer);
                    return [4 /*yield*/, fetch(apiURL, {
                            method: 'POST',
                            headers: {
                                'Content-Type': 'application/json'
                            },
                            body: JSON.stringify(customer)
                        })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to add data");
                    }
                    return [4 /*yield*/, response.text()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function GetIndividualUser(mailID, password) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/customercontroller/".concat(mailID, "/").concat(password);
                    return [4 /*yield*/, fetch(apiURL)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        return [2 /*return*/, null];
                    }
                    return [4 /*yield*/, response.json()];
                case 2: 
                //returns true if the customer is already exist
                return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function FetchProducts() {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/productscontroller/products";
                    return [4 /*yield*/, fetch(apiURL)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to fetch data");
                    }
                    return [4 /*yield*/, response.json()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function GetIndividualProduct(productID) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/productscontroller/get/product/".concat(productID);
                    return [4 /*yield*/, fetch(apiURL)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        return [2 /*return*/, null];
                    }
                    return [4 /*yield*/, response.json()];
                case 2: 
                //returns product
                return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function AddNewProduct(product) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/productscontroller/add/newProduct";
                    return [4 /*yield*/, fetch(apiURL, {
                            method: 'POST',
                            headers: {
                                'Content-Type': 'application/json'
                            },
                            body: JSON.stringify(product)
                        })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to add data");
                    }
                    return [4 /*yield*/, response.text()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function CheckProductExist(productName) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/productscontroller/product/".concat(productName);
                    return [4 /*yield*/, fetch(apiURL)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to fetch data");
                    }
                    return [4 /*yield*/, response.json()];
                case 2: 
                //returns true if the product is already exist
                return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function EditProductDetail(product) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/productscontroller/new/prod/edit";
                    return [4 /*yield*/, fetch(apiURL, {
                            method: 'PUT',
                            headers: {
                                'Content-Type': 'application/json'
                            },
                            body: JSON.stringify(product)
                        })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to update data");
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function DeleteProductDetail(productID) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch("http://localhost:5082/api/grocerystore/productscontroller/delete/".concat(productID), {
                        method: 'DELETE'
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('Failed to delete contact');
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function RechargeWalletBalance(customerID, amount) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/customercontroller/recharge/".concat(customerID, "/").concat(amount);
                    return [4 /*yield*/, fetch(apiURL, {
                            method: 'PUT',
                            headers: {
                                'Content-Type': 'application/json'
                            }
                        })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to update data");
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function AddItemToCart(cartItem) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/cartController/add/cartItem";
                    return [4 /*yield*/, fetch(apiURL, {
                            method: 'POST',
                            headers: {
                                'Content-Type': 'application/json'
                            },
                            body: JSON.stringify(cartItem)
                        })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to add data");
                    }
                    return [4 /*yield*/, response.text()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function UpdateCartQuantity(customerID, cartID, quantity) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/cartController/update/cart/".concat(customerID, "/").concat(cartID, "/").concat(quantity);
                    return [4 /*yield*/, fetch(apiURL, {
                            method: 'PUT',
                            headers: {
                                'Content-Type': 'application/json'
                            }
                        })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to update data");
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function FetchCarts(customerID) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/cartController/carts/".concat(customerID);
                    return [4 /*yield*/, fetch(apiURL)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to fetch data");
                    }
                    return [4 /*yield*/, response.json()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function DeleteCartDetail(customerID, cartID) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch("http://localhost:5082/api/grocerystore/cartController/delete/newcart/".concat(customerID, "/").concat(cartID), {
                        method: 'DELETE'
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('Failed to delete contact');
                    }
                    return [2 /*return*/];
            }
        });
    });
}
function purchaseAll(customerID) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/purchaseController/add/purchases";
                    return [4 /*yield*/, fetch(apiURL, {
                            method: 'POST',
                            headers: {
                                'Content-Type': 'application/json'
                            },
                            body: JSON.stringify(customerID)
                        })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to add data");
                    }
                    return [4 /*yield*/, response.text()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function FetchAllBookings(customerID) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/purchaseController/fetchbookings/".concat(customerID);
                    return [4 /*yield*/, fetch(apiURL)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to fetch data");
                    }
                    return [4 /*yield*/, response.json()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function FetchPurchases(bookingID) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/purchaseController/fetchpurchases/".concat(bookingID);
                    return [4 /*yield*/, fetch(apiURL)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error("Fail to fetch data");
                    }
                    return [4 /*yield*/, response.json()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function BuySingleItem(cartID, customerID) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch("http://localhost:5082/api/grocerystore/purchaseController/new/singleBooking/".concat(cartID, "/").concat(customerID), {
                        method: 'PUT',
                        headers: {
                            'Content-Type': 'application/json'
                        }
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('Failed to delete contact');
                    }
                    return [4 /*yield*/, response.text()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function cancelBooking(bookingID, customerID) {
    return __awaiter(this, void 0, void 0, function () {
        var response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0: return [4 /*yield*/, fetch("http://localhost:5082/api/grocerystore/purchaseController/cancel/booking/".concat(bookingID, "/").concat(customerID), {
                        method: 'PUT',
                        headers: {
                            'Content-Type': 'application/json'
                        }
                    })];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        throw new Error('Failed to update contact');
                    }
                    return [4 /*yield*/, response.text()];
                case 2: return [2 /*return*/, _a.sent()];
            }
        });
    });
}
function GetIndividualBooking(bookingID) {
    return __awaiter(this, void 0, void 0, function () {
        var apiURL, response;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiURL = "http://localhost:5082/api/grocerystore/purchasecontroller/fetchbookings/get/".concat(bookingID);
                    return [4 /*yield*/, fetch(apiURL)];
                case 1:
                    response = _a.sent();
                    if (!response.ok) {
                        return [2 /*return*/, null];
                    }
                    return [4 /*yield*/, response.json()];
                case 2: 
                //returns product
                return [2 /*return*/, _a.sent()];
            }
        });
    });
}
