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
        let response = yield fetch(`http://localhost:5345/api/grocerystore/customercontroller/${mailID}`);
        if (!response.ok) {
            throw new Error("Fail to fetch data");
        }
        return yield response.json();
    });
}
export function AddNewCustomer(customer) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:5345/api/grocerystore/customercontroller/newUser/${customer}`, {
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
        let response = yield fetch(`http://localhost:5345/api/grocerystore/customercontroller/${mailID}/${password}`);
        if (!response.ok) {
            return null;
        }
        return yield response.json();
    });
}
export function FetchProducts() {
    return __awaiter(this, void 0, void 0, function* () {
        let apiURL = `http://localhost:5345/api/grocerystore/productscontroller/products`;
        let response = yield fetch(apiURL);
        if (!response.ok) {
            throw new Error("Fail to fetch data");
        }
        return yield response.json();
    });
}
export function GetIndividualProduct(productID) {
    return __awaiter(this, void 0, void 0, function* () {
        let apiURL = `http://localhost:5345/api/grocerystore/productscontroller/get/product/${productID}`;
        let response = yield fetch(apiURL);
        if (!response.ok) {
            return null;
        }
        //returns product
        return yield response.json();
    });
}
export function AddNewProduct(product) {
    return __awaiter(this, void 0, void 0, function* () {
        let apiURL = "http://localhost:5345/api/grocerystore/productscontroller/add/newProduct";
        let response = yield fetch(apiURL, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(product)
        });
        if (!response.ok) {
            throw new Error("Fail to add data");
        }
        return yield response.text();
    });
}
export function CheckProductExist(productName) {
    return __awaiter(this, void 0, void 0, function* () {
        let apiURL = `http://localhost:5345/api/grocerystore/productscontroller/product/${productName}`;
        let response = yield fetch(apiURL);
        if (!response.ok) {
            throw new Error("Fail to fetch data");
        }
        //returns true if the product is already exist
        return yield response.json();
    });
}
export function EditProductDetail(product) {
    return __awaiter(this, void 0, void 0, function* () {
        let apiURL = `http://localhost:5345/api/grocerystore/productscontroller/new/prod/edit`;
        let response = yield fetch(apiURL, {
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
export function AddItemToCart(cartItem) {
    return __awaiter(this, void 0, void 0, function* () {
        let apiURL = "http://localhost:5082/api/grocerystore/cartController/add/cartItem";
        let response = yield fetch(apiURL, {
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
export function DeleteProductDetail(productID) {
    return __awaiter(this, void 0, void 0, function* () {
        const response = yield fetch(`http://localhost:5345/api/grocerystore/productscontroller/delete/${productID}`, {
            method: 'DELETE'
        });
        if (!response.ok) {
            throw new Error('Failed to delete contact');
        }
    });
}
//  
export function RechargeWalletBalance(customerID, amount) {
    return __awaiter(this, void 0, void 0, function* () {
        let response = yield fetch(`http://localhost:5345/api/grocerystore/customercontroller/recharge/${customerID}/${amount}`, {
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
