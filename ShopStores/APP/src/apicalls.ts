import { CustomerRegistration, ProductDetails,BookingDetails,PurchasedItems, CartDetails } from './model';

export async function CheckCustomer(mailID: string): Promise<boolean> {
    let response = await fetch(`http://localhost:5345/api/grocerystore/customercontroller/${mailID}`);
    if (!response.ok) {
        throw new Error("Fail to fetch data");
    }
  
    return await response.json();
}

export async function AddNewCustomer(customer: CustomerRegistration): Promise<string> {
    let response = await fetch(`http://localhost:5345/api/grocerystore/customercontroller/newUser/${customer}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(customer)
    });

    if (!response.ok) {
        throw new Error("Fail to add data");
    }
    return await response.text();
}

export async function GetIndividualUser(mailID: string, password: string): Promise<CustomerRegistration | null> {

    let response = await fetch(`http://localhost:5345/api/grocerystore/customercontroller/${mailID}/${password}`);
    if (!response.ok) {
        return null;
    }

    return await response.json();
}
export async function FetchProducts(): Promise<ProductDetails[]> {
    let apiURL = `http://localhost:5345/api/grocerystore/productscontroller/products`;
    let response = await fetch(apiURL);
    if (!response.ok) {
        throw new Error("Fail to fetch data");
    }
    return await response.json();
}
export async function GetIndividualProduct(productID: string): Promise<ProductDetails | null> {
    let apiURL = `http://localhost:5345/api/grocerystore/productscontroller/get/product/${productID}`;
    let response = await fetch(apiURL);
    if (!response.ok) {
        return null;
    }
    
    return await response.json();
}


export async function AddNewProduct(product: ProductDetails): Promise<string> {
    
    let response = await fetch("http://localhost:5345/api/grocerystore/productscontroller/add/newProduct", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(product)
    });

    if (!response.ok) {
        throw new Error("Fail to add data");
    }
    return await response.text();
}

export async function CheckProductExist(productName: string): Promise<boolean> {
   
    let response = await fetch(`http://localhost:5345/api/grocerystore/productscontroller/product/${productName}`);
    if (!response.ok) {
        throw new Error("Fail to fetch data");
    }
    return await response.json();
}

export async function EditProductDetail(product: ProductDetails): Promise<void> {
    let response = await fetch(`http://localhost:5345/api/grocerystore/productscontroller/new/prod/edit`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(product)
    });
    if (!response.ok) {
        throw new Error("Fail to update data");
    }
}

export async function DeleteProductDetail(productID: string): Promise<void> {

    const response = await fetch(`http://localhost:5345/api/grocerystore/productscontroller/delete/${productID}`, {
        method: 'DELETE'
    });
    if (!response.ok) {
        throw new Error('Failed to delete contact');
    }
}

export async function RechargeWalletBalance(customerID: string, amount: number): Promise<void> {
 
    let response = await fetch(`http://localhost:5345/api/grocerystore/customercontroller/recharge/${customerID}/${amount}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        }
    });
    if (!response.ok) {
        throw new Error("Fail to update data");
    }
}

export async function AddItemToCart(cartItem: CartDetails): Promise<string> {
    let response = await fetch("http://localhost:5345/api/grocerystore/cartController/add/cartItem", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(cartItem)
    });

    if (!response.ok) {
        throw new Error("Fail to add data");
    }
    return await response.text();
}

export async function UpdateCartQuantity(customerID: string, cartID: string, quantity: number): Promise<void> {
    
    let response = await fetch(`http://localhost:5345/api/grocerystore/cartController/update/cart/${customerID}/${cartID}/${quantity}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        }
    });
    if (!response.ok) {
        throw new Error("Fail to update data");
    }
}

export async function FetchCarts(customerID: string): Promise<CartDetails[]> {
    
    let response = await fetch(`http://localhost:5345/api/grocerystore/cartController/carts/${customerID}`);
    if (!response.ok) {
        throw new Error("Fail to fetch data");
    }
    return await response.json();
}

export async function DeleteCartDetail(customerID: string, cartID: string) {
    const response = await fetch(`http://localhost:5345/api/grocerystore/cartController/delete/newcart/${customerID}/${cartID}`, {
        method: 'DELETE'
    });
    if (!response.ok) {
        throw new Error('Failed to delete contact');
    }
}

export async function purchaseAll(customerID: string): Promise<string> {
    let apiURL = "http://localhost:5345/api/grocerystore/purchaseController/add/purchases";
    let response = await fetch(apiURL, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(customerID)
    });

    if (!response.ok) {
        throw new Error("Fail to add data");
    }
    return await response.text();
}

export async function FetchAllBookings(customerID: string): Promise<BookingDetails[]> {
    let apiURL = `http://localhost:5345/api/grocerystore/purchaseController/fetchbookings/${customerID}`;
    let response = await fetch(apiURL);
    if (!response.ok) {
        throw new Error("Fail to fetch data");
    }
    return await response.json();
}

export async function FetchPurchases(bookingID: string): Promise<PurchasedItems[]> {
    let apiURL = `http://localhost:5345/api/grocerystore/purchaseController/fetchpurchases/${bookingID}`;
    let response = await fetch(apiURL);
    if (!response.ok) {
        throw new Error("Fail to fetch data");
    }
    return await response.json();
}

export async function BuySingleItem(cartID: string, customerID: string): Promise<string> {
    const response = await fetch(`http://localhost:5345/api/grocerystore/purchaseController/new/singleBooking/${cartID}/${customerID}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        }
    });
    if (!response.ok) {
        throw new Error('Failed to delete contact');
    }
    return await response.text();
}

export async function cancelBooking(bookingID: string, customerID: string): Promise<string> {
    const response = await fetch(`http://localhost:5345/api/grocerystore/purchaseController/cancel/booking/${bookingID}/${customerID}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        }
    });
    if (!response.ok) {
        throw new Error('Failed to update contact');
    }
    return await response.text();
}

export async function GetIndividualBooking(bookingID: string): Promise<BookingDetails | null> {
    let apiURL = `http://localhost:5345/api/grocerystore/purchasecontroller/fetchbookings/get/${bookingID}`;
    let response = await fetch(apiURL);
    if (!response.ok) {
        return null;
    }
    
    return await response.json();
}


