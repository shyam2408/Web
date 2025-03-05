import { CustomerRegistration, RoomDetails,BookingDetails,Wishlist, RoomSelection } from './model';
export async function CheckCustomer(mailID:string) :Promise<boolean>
{
    
    let response =await fetch(`http://localhost:51234/api/hotel/customercontroller/${mailID}`);
   
    
    if (!response.ok)
    {
        throw new Error("Fail to fetch data");
    }
    return await response.json();

}
export async function AddNewCustomer(customer: CustomerRegistration): Promise<string> {
    let response = await fetch(`http://localhost:51234/api/hotel/customercontroller/newUser/${customer}`, {
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
export async function GetIndividualUser(mailID:string,password:string):Promise<CustomerRegistration |null> {

    let response=await fetch(`http://localhost:51234/api/hotel/customercontroller/${mailID}/${password}`);
    if (!response.ok)
    {
        return null;
    }
    return await response.json();
    
}
export async function FetchProducts():Promise <RoomDetails[]>{
    
    let response=await fetch(`http://localhost:51234/api/hotel/roomcontroller/rooms`);
    if (!response.ok)
    {
        throw new Error("Fail to fetch data");
    }
    return await response.json()
}
export async function GetIndividualProduct(roomID: string): Promise<RoomDetails | null> {

    let response = await fetch(`http://localhost:51234/api/hotel/roomcontroller/get/room/${roomID}`);
    if (!response.ok) {
        return null;
    }
    
    return await response.json();
} 
export async function EditProductDetail(product: RoomDetails): Promise<void> {

    let response = await fetch(`http://localhost:51234/api/hotel/roomcontroller/new/prod/edit`, {
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
export async function DeleteProductDetail(roomID: string): Promise<void> {

    const response = await fetch(`http://localhost:51234/api/hotel/roomcontroller/delete/${roomID}`, {
        method: 'DELETE'
    });
    if (!response.ok) {
        throw new Error('Failed to delete contact');
    }
}
export async function AddNewProduct(product: RoomDetails): Promise<string> {
    
    let response = await fetch("http://localhost:51234/api/hotel/roomcontroller/add/newProduct", {
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
    return await response.text();
}
export async function RechargeWalletBalance(customerID: string, amount: number): Promise<void> {

    let response = await fetch(`http://localhost:51234/api/hotel/customercontroller/recharge/${customerID}/${amount}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        }
    });
    if (!response.ok) {
        throw new Error("Fail to update data");
    }
}
export async function FetchAllBookings(customerID: string): Promise<BookingDetails[]> {
    
    let response = await fetch(`http://localhost:51234/api/hotel/roomSelectionController/fetchbookings/${customerID}`);
    if (!response.ok) {
        throw new Error("Fail to fetch data");
    }
    return await response.json();
}
export async function AddItemToCart(cartItem: Wishlist): Promise<string> {
   
    let response = await fetch("http://localhost:51234/api/hotel/wishlistcontroller/add/cartItem", {
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
export async function FetchCarts(customerID: string): Promise<Wishlist[]> {
   
    let response = await fetch(`http://localhost:51234/api/hotel/wishlistcontroller/carts/${customerID}`);
    if (!response.ok) {
        throw new Error("Fail to fetch data");
    }
    return await response.json();
}
export async function UpdateCartQuantity(customerID: string, cartID: string, startdate: string,enddate:string): Promise<void> {
   
    let response = await fetch(`http://localhost:51234/api/hotel/wishlistcontroller/update/cart/${customerID}/${cartID}/${startdate}/${enddate}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        }
    }); 
    if (!response.ok) {
        throw new Error("Fail to update data");
    }
}
export async function DeleteCartDetail(customerID: string, wishlistID: string) {
    console.log(customerID,wishlistID);
    
    const response = await fetch(`http://localhost:51234/api/hotel/wishlistcontroller/delete/newcart/${customerID}/${wishlistID}`, {
        method: 'DELETE'
    });
    console.log(response);
    
    if (!response.ok) {
        throw new Error('Failed to delete contact');
    }
}
export async function BuySingleItem(cartID: string, customerID: string): Promise<string> {
    const response = await fetch(`http://localhost:51234/api/hotel/roomSelectionController/new/singleBooking/${cartID}/${customerID}`, {
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
export async function GetIndividualBooking(bookingID: string): Promise<RoomSelection | null> {
    
    let response = await fetch(`http://localhost:51234/api/hotel/roomSelectionController/fetchbookings/get/${bookingID}`);
    if (!response.ok) {
        return null;
    }
   
    return await response.json();
}
export async function purchaseAll(customerID: string): Promise<string> {

    let response = await fetch("http://localhost:51234/api/hotel/roomSelectionController/add/purchases", {
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
export async function FetchPurchases(bookingID: string): Promise<RoomSelection[]> {
    let response = await fetch(`http://localhost:51234/api/hotel/roomSelectionController/fetchpurchases/${bookingID}`);
    if (!response.ok) {
        throw new Error("Fail to fetch data");
    }
    return await response.json();
}
export async function cancelBooking(bookingID: string, customerID: string): Promise<string> {
    const response = await fetch(`http://localhost:51234/api/hotel/roomSelectionController/cancel/booking/${bookingID}/${customerID}`, {
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
export async function CheckIsBooked(room:string,startdate:string,enddate:string)
{
    const response = await fetch(`http://localhost:51234/api/hotel/roomSelectionController/checkbooking/${room}/${startdate}/${enddate}`, {
        method: 'GET',
        headers: {
          'Content-Type': 'application/json'
        }
      });
  
    return await response.text();
}