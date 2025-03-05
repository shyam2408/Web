var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
export function CheckCustomer(mailID) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/customercontroller/${mailID}`);
        if (!response.ok) {
            throw new Error("Fail to fetch data");
        }
        return yield response.json();
    });
}
export function AddNewCustomer(customer) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/customercontroller/newUser/${customer}`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(customer)
        });
        if (!response.ok) {
            throw new Error("Fail to add data");
        }
        return yield response.text();
    });
}
export function GetIndividualUser(mailID, password) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/customercontroller/${mailID}/${password}`);
        if (!response.ok) {
            return null;
        }
        return yield response.json();
    });
}
export function FetchProducts() {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/roomcontroller/rooms`);
        if (!response.ok) {
            throw new Error("Fail to fetch data");
        }
        return yield response.json();
    });
}
export function GetIndividualProduct(roomID) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/roomcontroller/get/room/${roomID}`);
        if (!response.ok) {
            return null;
        }
        return yield response.json();
    });
}
export function EditProductDetail(product) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/roomcontroller/new/prod/edit`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(product)
        });
        if (!response.ok) {
            throw new Error("Fail to update data");
        }
    });
}
export function DeleteProductDetail(roomID) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:51234/api/hotel/roomcontroller/delete/${roomID}`, {
            method: 'DELETE'
        });
        if (!response.ok) {
            throw new Error('Failed to delete contact');
        }
    });
}
export function AddNewProduct(product) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch("http://localhost:51234/api/hotel/roomcontroller/add/newProduct", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(product)
        });
        console.log(response);
        if (!response.ok) {
            throw new Error("Fail to add data");
        }
        return yield response.text();
    });
}
export function RechargeWalletBalance(customerID, amount) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/customercontroller/recharge/${customerID}/${amount}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        if (!response.ok) {
            throw new Error("Fail to update data");
        }
    });
}
export function FetchAllBookings(customerID) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/roomSelectionController/fetchbookings/${customerID}`);
        if (!response.ok) {
            throw new Error("Fail to fetch data");
        }
        return yield response.json();
    });
}
export function AddItemToCart(cartItem) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch("http://localhost:51234/api/hotel/wishlistcontroller/add/cartItem", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(cartItem)
        });
        if (!response.ok) {
            throw new Error("Fail to add data");
        }
        return yield response.text();
    });
}
export function FetchCarts(customerID) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/wishlistcontroller/carts/${customerID}`);
        if (!response.ok) {
            throw new Error("Fail to fetch data");
        }
        return yield response.json();
    });
}
export function UpdateCartQuantity(customerID, cartID, startdate, enddate) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/wishlistcontroller/update/cart/${customerID}/${cartID}/${startdate}/${enddate}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        if (!response.ok) {
            throw new Error("Fail to update data");
        }
    });
}
export function DeleteCartDetail(customerID, wishlistID) {
    return __awaiter(this, void 0, void 0, function* () {
        console.log(customerID, wishlistID);
        const response = yield fetch(`http://localhost:51234/api/hotel/wishlistcontroller/delete/newcart/${customerID}/${wishlistID}`, {
            method: 'DELETE'
        });
        console.log(response);
        if (!response.ok) {
            throw new Error('Failed to delete contact');
        }
    });
}
export function BuySingleItem(cartID, customerID) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:51234/api/hotel/roomSelectionController/new/singleBooking/${cartID}/${customerID}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        if (!response.ok) {
            throw new Error('Failed to delete contact');
        }
        return yield response.text();
    });
}
export function GetIndividualBooking(bookingID) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/roomSelectionController/fetchbookings/get/${bookingID}`);
        if (!response.ok) {
            return null;
        }
        return yield response.json();
    });
}
export function purchaseAll(customerID) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch("http://localhost:51234/api/hotel/roomSelectionController/add/purchases", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(customerID)
        });
        if (!response.ok) {
            throw new Error("Fail to add data");
        }
        return yield response.text();
    });
}
export function FetchPurchases(bookingID) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:51234/api/hotel/roomSelectionController/fetchpurchases/${bookingID}`);
        if (!response.ok) {
            throw new Error("Fail to fetch data");
        }
        return yield response.json();
    });
}
export function cancelBooking(bookingID, customerID) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:51234/api/hotel/roomSelectionController/cancel/booking/${bookingID}/${customerID}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        if (!response.ok) {
            throw new Error('Failed to update contact');
        }
        return yield response.text();
    });
}
export function CheckIsBooked(room, startdate, enddate) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:51234/api/hotel/roomSelectionController/checkbooking/${room}/${startdate}/${enddate}`, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            }
        });
        return yield response.text();
    });
}
