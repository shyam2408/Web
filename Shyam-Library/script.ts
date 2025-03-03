


let UserIdAutoIncrement = 3000;
let BookAutoIncrement = 1000;
let BorrowAutoIncrement = 2000;

class UserDetails {
    UserId: string;
    UserName: string;
    Gender: string;
    Department: string;
    MobileNumber: string;
    Password: string;

    Email: string;
    WalletBalance: number = 0;

    constructor(name: string, email: string, password: string, department: string, gender: string, PhoneNumber: string) {

        this.UserId = "SF" + ++UserIdAutoIncrement;
        this.UserName = name;
        this.Email = email;
        this.Password = password;
        this.Department = department;
        this.MobileNumber = PhoneNumber;
        this.Gender = gender;
    }
    WalletRecharge(amount: number) {
        this.WalletBalance += amount;
    }
    DeductBalance(amount: number) {
        this.WalletBalance -= amount;
    }
}

class BookDetails {
    BookID: string;
    BookName: string;
    AuthorName: string;
    Availability: string;
    constructor(bookName: string, authorName: string, availability: string) {
        this.BookID = "BID" + ++BookAutoIncrement;
        this.BookName = bookName;
        this.AuthorName = authorName;
        this.Availability = availability;
    }
}

class BorrowDetails {
    BorrowID: string;
    BookID: string;
    UserID: string;
    BorrowDate: Date;
    BookingStatus: string;
    PaidFineAmount: number;
    constructor(bookID: string, userID: string, borrowdate: Date, bookingStatus: string, fine: number) {
        this.BorrowID = "LB" + ++BorrowAutoIncrement;

        this.BookID = bookID;
        this.UserID = userID;
        this.BorrowDate = borrowdate;
        this.BookingStatus = bookingStatus;
        this.PaidFineAmount = fine;

    }
}

let UserArrayList: Array<UserDetails> = new Array<UserDetails>();
UserArrayList.push(new UserDetails("Ravichandran ", "ravi@gmail.com", "123", "eee", "Male", "93838833"));
UserArrayList.push(new UserDetails("Priyadharshini ", "priya@gmail.com", "123", "cse", "Female", "94444445"));
console.log(UserArrayList);

let BookDetailsList: Array<BookDetails> = new Array<BookDetails>();
BookDetailsList.push(new BookDetails("C#", "Author1", "issued"));
BookDetailsList.push(new BookDetails("C#", "Author1", "issued"));
BookDetailsList.push(new BookDetails("C#", "Author1", "issued"));
BookDetailsList.push(new BookDetails("HTML", "Author2", "available"));
BookDetailsList.push(new BookDetails("HTML", "Author2", "damaged"));
BookDetailsList.push(new BookDetails("CSS", "Author1", "available"));
BookDetailsList.push(new BookDetails("CSS", "Author1", "available"));
BookDetailsList.push(new BookDetails("JS", "Author1", "available"));
BookDetailsList.push(new BookDetails("JS", "Author1", "available"));
BookDetailsList.push(new BookDetails("TS", "Author1", "available"));
BookDetailsList.push(new BookDetails("TS", "Author2", "damaged"));
BookDetailsList.push(new BookDetails("TS", "Author2", "available"));


let BorrowDetailsList: Array<BorrowDetails> = new Array<BorrowDetails>();
BorrowDetailsList.push(new BorrowDetails("BID1001", "SF3001", new Date(2025, 1, 10), "borrowed", 0))
BorrowDetailsList.push(new BorrowDetails("BID1003", "SF3001", new Date(2025, 1, 12), "borrowed", 0))
BorrowDetailsList.push(new BorrowDetails("BID1001", "SF3001", new Date(2025, 1, 14), "returned", 15))
BorrowDetailsList.push(new BorrowDetails("BID1001", "SF3001", new Date(2025, 1, 11), "borrowed", 0))
BorrowDetailsList.push(new BorrowDetails("BID1001", "SF3001", new Date(2025, 1, 7), "borrowed", 20))

var signInForm = document.getElementById("signIn") as HTMLDivElement;
var signUpForm = document.getElementById("signUp") as HTMLDivElement;
var signInButton = document.getElementById("signInButton") as HTMLDivElement;
var signUpButton = document.getElementById("signUpButton") as HTMLDivElement;

function signIn(): void {
    signInForm.style.display = "block";
    signUpForm.style.display = "none";
    signInButton.style.background = "orange";
    signUpButton.style.background = "none";
}

function signUp(): void {
    signInForm.style.display = "none";
    signUpForm.style.display = "block";
    signInButton.style.background = "none";
    signUpButton.style.background = "orange";
}
async function signUpSubmit(e: { preventDefault: () => void; }) {
    e.preventDefault();
    var name = document.getElementById("name") as HTMLInputElement;
    var email = document.getElementById("email") as HTMLInputElement;
    var password = document.getElementById("password") as HTMLInputElement;
    var cpassword = document.getElementById("cpassword") as HTMLInputElement;
    var phone = document.getElementById("phone") as HTMLInputElement;
    var gendervalue = document.querySelector<HTMLInputElement>('input[name="gender"]:checked');
    var departmentvalue = document.querySelector<HTMLInputElement>('input[name="department"]:checked');
    var isavail: boolean = true;
    UserArrayList.forEach((val) => {
        if (val.Email.toLowerCase() == email.value.toLowerCase()) {
            alert("you already have an ID. Please Sign In");
            isavail = false;
        }
    });

    if (isavail) {
        let user: UserDetails = new UserDetails(name.value, email.value, password.value, departmentvalue ? departmentvalue.value : "cse", gendervalue ? gendervalue.value : "male", phone.value);
        UserArrayList.push(user);
        alert("Your User ID is " + user.UserId)
        isavail = false;
    }
    else {
        var i = document.getElementById("signup") as HTMLDivElement;
        i.style.border = "2px solid red";
    }
}
async function signInSubmit(e: { preventDefault: () => void; }) {
    e.preventDefault();
    var isavail: boolean = true;
    var email = document.getElementById("email1") as HTMLInputElement;
    var password = document.getElementById("password2") as HTMLInputElement;
    console.log(UserArrayList);


    UserArrayList?.forEach((val) => {
        if (val.Email.toLowerCase() == email.value.toLowerCase() && val.Password == password.value) {
            var a = document.getElementById("box") as HTMLDivElement
            a.style.display = "none";
            var b = document.getElementById("menu") as HTMLDivElement;
            b.style.display = "block";
            isavail = false;
            currentUser = val;
            home();
            email.value = "";
            password.value = "";
        }
    })
    if (isavail) {
        alert("Invalid Email or Password");
    }

}
var currentUser: UserDetails;

var homePage = document.getElementById("homePage") as HTMLDivElement;
var bookDetailsPage = document.getElementById("bookDetailsPage") as HTMLDivElement;
var borrowBookPage = document.getElementById("borrowBookPage") as HTMLDivElement;
var borrowHistoryPage = document.getElementById("borrowHistoryPage") as HTMLDivElement;
var topPage = document.getElementById("topUpPage") as HTMLDivElement;
var returnPage = document.getElementById("returnPage") as HTMLDivElement;
async function home() {
    displayNone();
    homePage.style.display = "block";
    var welcome = document.getElementById("welcome") as HTMLHeadingElement;
    welcome.innerHTML = "Welcome " + currentUser.UserName;
}
async function displayNone() {
    homePage.style.display = "none";
    bookDetailsPage.style.display = "none";
    borrowBookPage.style.display = "none";
    topPage.style.display = "none";
    borrowHistoryPage.style.display = "none";
    returnPage.style.display = "none";
    (document.getElementById("addEditBookForm") as HTMLDivElement).style.display = "none";
}
async function bookDetails() {
    displayNone();
    bookDetailsPage.style.display = "block";
    var bookDetailsTable = document.getElementById("bookDetailsTable") as HTMLTableElement;
    var len = bookDetailsTable.getElementsByTagName("tr").length;
    if (bookDetailsTable.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            bookDetailsTable.removeChild(bookDetailsTable.children[i]);
        }
    }
    BookDetailsList.forEach((book) => {
        var row = document.createElement("tr") as HTMLTableRowElement;
        row.innerHTML = `<td>${book.BookID} <td>${book.BookName}</td> <td>${book.AuthorName}</td> <td>${book.Availability}</td> 
            <td>
            <button onclick="editBook('${book.BookID}')">Edit</button>
            <button onclick="deleteBook('${book.BookID}')">Delete</button>
        </td>`;
        bookDetailsTable.appendChild(row);
    })
}
let editBookID: string;
async function deleteBook(bookID: string) {
    var index = BookDetailsList.findIndex((val) => val.BookID == bookID);
    BookDetailsList.splice(index, 1);
    bookDetails();
}
async function addBook() {
    (document.getElementById("addEditBookForm") as HTMLDivElement).style.display = "block";
    editBookID = "";
}

async function editBook(bookID: string) {
    (document.getElementById("addEditBookForm") as HTMLDivElement).style.display = "block";
    var book = BookDetailsList.find((val) => val.BookID == bookID);
    if (book) {
        var bookName = document.getElementById("bookName") as HTMLInputElement;
        var authorname = document.getElementById("authorname") as HTMLInputElement;
        var availability = document.getElementById("availability") as HTMLInputElement;
       
        bookName.value = book.BookName;
        authorname.value = book.AuthorName.toString();
        availability.value = book.Availability.toString();
      
        editBookID = book.BookID;
    }
}
async function addEditBook() {
    var bookName = document.getElementById("bookName") as HTMLInputElement;
    var authorname = document.getElementById("authorname") as HTMLInputElement;
    var availability = document.getElementById("availability") as HTMLInputElement;
 

    var bookData = BookDetailsList.find(val => val.BookID == editBookID);
    if (bookData) {
        bookData.BookName = bookName.value;
        bookData.AuthorName = authorname.value;
        bookData.Availability = availability.value;

        alert("Book details updated successfully");
        editBookID = "";
    }
    else {
        if (bookName.value.trim() != "") {
            BookDetailsList.push(new BookDetails(bookName.value, authorname.value, availability.value));
            alert("book details added successfully");
            editBookID = "";
        }
    }
    bookName.value = "";
    authorname.value = "";
    availability.value = "";
    bookDetails();
}
async function borrowBook() {
    displayNone();
    borrowBookPage.style.display = "block";
    var borrowBookTable = document.getElementById("borrowBookTable") as HTMLTableElement;
    var len = borrowBookTable.getElementsByTagName("tr").length;
    if (borrowBookTable.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            borrowBookTable.removeChild(borrowBookTable.children[i]);
        }
    }

    BookDetailsList.forEach((book) => {
        var row = document.createElement("tr") as HTMLTableRowElement;
        row.innerHTML = `<td>${book.BookID} <td>${book.BookName}</td> <td>${book.AuthorName}</td> <td>${book.Availability}</td> 
    
            <td>
           
            <button onclick="borrowselectedBook('${book.BookID}')">Borrow</button>
        </td>`;

        borrowBookTable.appendChild(row);

    })
}
async function borrowselectedBook(bookID: string) {
    BookDetailsList.forEach((book) => {
        if (book.BookID == bookID) {
            if (book.Availability == "available") {
                let countuser = 0;
                BorrowDetailsList.forEach((borrow) => {
                    if (borrow.UserID == currentUser.UserId && borrow.BookingStatus=="borrowed") {
                        countuser += 1;
                    }
                })
                if (countuser < 3) {
                    book.Availability = "issued";
             
                    let borrow: BorrowDetails = new BorrowDetails(book.BookID, currentUser.UserId, new Date(), "borrowed", 0);
                    alert("Borrowed successfuly .Your borrow ID is " + borrow.BorrowID)

                    BorrowDetailsList.push(borrow);

                }
                else {
                    alert("Already you have borrowed 3 books");

                }

            }
            else if (book.Availability == "issued")
            {
                let issueddate= new Date();
                BorrowDetailsList.forEach((borrow) => {
                    if (borrow.BookID == book.BookID ) {
                        issueddate=borrow.BorrowDate;
                    }
                })
                
                console.log(issueddate.getDate() + 15);
                
                issueddate.setDate(issueddate.getDate() + 15);
                console.log(issueddate.toISOString());
                
                
                let newDate = issueddate.toISOString().split('T')[0];
                console.log(newDate);
                
                alert(`The book is already borrowed.The book will be available on ${newDate}`);
            }
            else{
                alert("The book is damaged")
            }
        }
    })


}
async function borrowHistory() {
    displayNone();
    borrowHistoryPage.style.display = "block";
    var borrowHistoryTable = document.getElementById("borrowHistoryTable") as HTMLTableElement;
    var len = borrowHistoryTable.getElementsByTagName("tr").length;
    if (borrowHistoryTable.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            borrowHistoryTable.removeChild(borrowHistoryTable.children[i]);
        }
    }

    BorrowDetailsList.forEach((borrow) => {
        if (borrow.UserID == currentUser.UserId) {
            var row = document.createElement("tr") as HTMLTableRowElement;
            row.innerHTML = `<td>${borrow.BorrowID} <td>${borrow.BookID}</td> <td>${borrow.UserID}</td> <td>${borrow.BorrowDate.toLocaleDateString()}</td> <td>${borrow.BookingStatus}</td> 
            <td>${borrow.PaidFineAmount}</td> `;
        
            borrowHistoryTable.appendChild(row);
        }
    })
}
async function returnBook() {
    displayNone();
    returnPage.style.display = "block";
    var returnTable = document.getElementById("returnTable") as HTMLTableElement;
    var len = returnTable.getElementsByTagName("tr").length;
    if (returnTable.hasChildNodes()) {
        for (var i = len - 1; i >= 1; i--) {
            returnTable.removeChild(returnTable.children[i]);
        }
    }

    BorrowDetailsList.forEach((borrow) => {
        if (borrow.UserID == currentUser.UserId && borrow.BookingStatus=="borrowed") {
            var row = document.createElement("tr") as HTMLTableRowElement;
            row.innerHTML = `<td>${borrow.BorrowID} <td>${borrow.BookID}</td> <td>${borrow.UserID}</td> <td>${borrow.BorrowDate.toLocaleDateString()}</td> <td>${borrow.BookingStatus}</td> 
            <td>${borrow.PaidFineAmount}</td> 
            <td><button id="returnbtn" onclick="returnParticularBook('${borrow.BorrowID}')">Return</button></td>`;
            returnTable.appendChild(row);
        }
    })
}
function addDays(date:Date, days:number) {
    const newDate = new Date(date);
    newDate.setDate(date.getDate() + days);
    return newDate;
}
async function returnParticularBook(borrowid:string) {
    console.log(borrowid);
    
    BorrowDetailsList.forEach((borrow)=>{
      if (borrow.BorrowID==borrowid)
      {
        let newDate = addDays(borrow.BorrowDate, 15);
        console.log((newDate));
        let fineamount=0;
        
        if (newDate < new Date()){
            let isdamaged=prompt("Book is damaged or not")?.toLowerCase()
            if (isdamaged=="yes"){
                fineamount+=300;
                if (currentUser.WalletBalance<fineamount)
                    {
                        alert("Insufficient balance. Please recharge and proceed")
                    }
                    else{
                        currentUser.WalletBalance-=fineamount;
                        borrow.BookingStatus="Returned";
                        alert("Book returned successfully");
                    }
                }
                else{
                borrow.BookingStatus="Returned";
                
                alert("Book returned successfully");
            }

        }
        else{
            let finedays=newDate.getDate()-new Date().getDate();
             fineamount+=finedays;
             let isdamaged=prompt("Book is damaged or not")?.toLowerCase()
            if (isdamaged=="yes"){
                fineamount+=300;
                if (currentUser.WalletBalance<fineamount)
                    {
                        alert("Insufficient balance. Please recharge and proceed")
                    }
                    else{
                        currentUser.WalletBalance-=fineamount;
                        borrow.BookingStatus="Returned";
                        alert("Book returned successfully");
                    }
                }
                else{
                borrow.BookingStatus="Returned";
                
                alert("Book returned successfully");
            }
        }

      }
    })
}

async function topup() {
    displayNone();
    topPage.style.display = "block";
    (document.getElementById("currentBalance") as HTMLHeadingElement).innerHTML = `Available Balance :${currentUser.WalletBalance}`;
}

async function deposit() {
    var amount = document.getElementById("amount") as HTMLInputElement;
    currentUser.WalletBalance += Number(amount.value);
    alert("Amount Deposited Successfully");
    amount.value = "";
    (document.getElementById("currentBalance") as HTMLHeadingElement).innerHTML = `Available Balance :${currentUser.WalletBalance}`;

}


async function logout() {
    displayNone();
    (document.getElementById("menu") as HTMLDivElement).style.display = "none";
    (document.getElementById("box") as HTMLDivElement).style.display = "block";
    
}