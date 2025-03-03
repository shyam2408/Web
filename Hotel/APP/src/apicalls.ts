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
    //returns product
    return await response.json();
}

export async function AddNewProduct(product: ProductDetails): Promise<string> {
    let apiURL = "http://localhost:5345/api/grocerystore/productscontroller/add/newProduct";
    let response = await fetch(apiURL, {
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
    let apiURL = `http://localhost:5345/api/grocerystore/productscontroller/product/${productName}`;
    let response = await fetch(apiURL);
    if (!response.ok) {
        throw new Error("Fail to fetch data");
    }
    //returns true if the product is already exist
    return await response.json();
}

export async function EditProductDetail(product: ProductDetails): Promise<void> {
    let apiURL = `http://localhost:5345/api/grocerystore/productscontroller/new/prod/edit`;
    let response = await fetch(apiURL, {
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
export async function AddItemToCart(cartItem: CartDetails): Promise<string> {
    let apiURL = "http://localhost:5082/api/grocerystore/cartController/add/cartItem";
    let response = await fetch(apiURL, {
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
export async function DeleteProductDetail(productID: string): Promise<void> {

    const response = await fetch(`http://localhost:5345/api/grocerystore/productscontroller/delete/${productID}`, {
        method: 'DELETE'
    });
    if (!response.ok) {
        throw new Error('Failed to delete contact');
    }
}
//  
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

