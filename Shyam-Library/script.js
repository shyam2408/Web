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
var UserIdAutoIncrement = 3000;
var BookAutoIncrement = 1000;
var BorrowAutoIncrement = 2000;
var UserDetails = /** @class */ (function () {
    function UserDetails(name, email, password, department, gender, PhoneNumber) {
        this.WalletBalance = 0;
        this.UserId = "SF" + ++UserIdAutoIncrement;
        this.UserName = name;
        this.Email = email;
        this.Password = password;
        this.Department = department;
        this.MobileNumber = PhoneNumber;
        this.Gender = gender;
    }
    UserDetails.prototype.WalletRecharge = function (amount) {
        this.WalletBalance += amount;
    };
    UserDetails.prototype.DeductBalance = function (amount) {
        this.WalletBalance -= amount;
    };
    return UserDetails;
}());
var BookDetails = /** @class */ (function () {
    function BookDetails(bookName, authorName, availability) {
        this.BookID = "BID" + ++BookAutoIncrement;
        this.BookName = bookName;
        this.AuthorName = authorName;
        this.Availability = availability;
    }
    return BookDetails;
}());
var BorrowDetails = /** @class */ (function () {
    function BorrowDetails(bookID, userID, borrowdate, bookingStatus, fine) {
        this.BorrowID = "LB" + ++BorrowAutoIncrement;
        this.BookID = bookID;
        this.UserID = userID;
        this.BorrowDate = borrowdate;
        this.BookingStatus = bookingStatus;
        this.PaidFineAmount = fine;
    }
    return BorrowDetails;
}());
var UserArrayList = new Array();
UserArrayList.push(new UserDetails("Ravichandran ", "ravi@gmail.com", "123", "eee", "Male", "93838833"));
UserArrayList.push(new UserDetails("Priyadharshini ", "priya@gmail.com", "123", "cse", "Female", "94444445"));
console.log(UserArrayList);
var BookDetailsList = new Array();
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
var BorrowDetailsList = new Array();
BorrowDetailsList.push(new BorrowDetails("BID1001", "SF3001", new Date(2025, 1, 10), "borrowed", 0));
BorrowDetailsList.push(new BorrowDetails("BID1003", "SF3001", new Date(2025, 1, 12), "borrowed", 0));
BorrowDetailsList.push(new BorrowDetails("BID1001", "SF3001", new Date(2025, 1, 14), "returned", 15));
BorrowDetailsList.push(new BorrowDetails("BID1001", "SF3001", new Date(2025, 1, 11), "borrowed", 0));
BorrowDetailsList.push(new BorrowDetails("BID1001", "SF3001", new Date(2025, 1, 7), "borrowed", 20));
var signInForm = document.getElementById("signIn");
var signUpForm = document.getElementById("signUp");
var signInButton = document.getElementById("signInButton");
var signUpButton = document.getElementById("signUpButton");
function signIn() {
    signInForm.style.display = "block";
    signUpForm.style.display = "none";
    signInButton.style.background = "orange";
    signUpButton.style.background = "none";
}
function signUp() {
    signInForm.style.display = "none";
    signUpForm.style.display = "block";
    signInButton.style.background = "none";
    signUpButton.style.background = "orange";
}
function signUpSubmit(e) {
    return __awaiter(this, void 0, void 0, function () {
        var name, email, password, cpassword, phone, gendervalue, departmentvalue, isavail, user, i;
        return __generator(this, function (_a) {
            e.preventDefault();
            name = document.getElementById("name");
            email = document.getElementById("email");
            password = document.getElementById("password");
            cpassword = document.getElementById("cpassword");
            phone = document.getElementById("phone");
            gendervalue = document.querySelector('input[name="gender"]:checked');
            departmentvalue = document.querySelector('input[name="department"]:checked');
            isavail = true;
            UserArrayList.forEach(function (val) {
                if (val.Email.toLowerCase() == email.value.toLowerCase()) {
                    alert("you already have an ID. Please Sign In");
                    isavail = false;
                }
            });
            if (isavail) {
                user = new UserDetails(name.value, email.value, password.value, departmentvalue ? departmentvalue.value : "cse", gendervalue ? gendervalue.value : "male", phone.value);
                UserArrayList.push(user);
                alert("Your User ID is " + user.UserId);
                isavail = false;
            }
            else {
                i = document.getElementById("signup");
                i.style.border = "2px solid red";
            }
            return [2 /*return*/];
        });
    });
}
function signInSubmit(e) {
    return __awaiter(this, void 0, void 0, function () {
        var isavail, email, password;
        return __generator(this, function (_a) {
            e.preventDefault();
            isavail = true;
            email = document.getElementById("email1");
            password = document.getElementById("password2");
            console.log(UserArrayList);
            UserArrayList === null || UserArrayList === void 0 ? void 0 : UserArrayList.forEach(function (val) {
                if (val.Email.toLowerCase() == email.value.toLowerCase() && val.Password == password.value) {
                    var a = document.getElementById("box");
                    a.style.display = "none";
                    var b = document.getElementById("menu");
                    b.style.display = "block";
                    isavail = false;
                    currentUser = val;
                    home();
                    email.value = "";
                    password.value = "";
                }
            });
            if (isavail) {
                alert("Invalid Email or Password");
            }
            return [2 /*return*/];
        });
    });
}
var currentUser;
var homePage = document.getElementById("homePage");
var bookDetailsPage = document.getElementById("bookDetailsPage");
var borrowBookPage = document.getElementById("borrowBookPage");
var borrowHistoryPage = document.getElementById("borrowHistoryPage");
var topPage = document.getElementById("topUpPage");
var returnPage = document.getElementById("returnPage");
function home() {
    return __awaiter(this, void 0, void 0, function () {
        var welcome;
        return __generator(this, function (_a) {
            displayNone();
            homePage.style.display = "block";
            welcome = document.getElementById("welcome");
            welcome.innerHTML = "Welcome " + currentUser.UserName;
            return [2 /*return*/];
        });
    });
}
function displayNone() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            homePage.style.display = "none";
            bookDetailsPage.style.display = "none";
            borrowBookPage.style.display = "none";
            topPage.style.display = "none";
            borrowHistoryPage.style.display = "none";
            returnPage.style.display = "none";
            document.getElementById("addEditBookForm").style.display = "none";
            return [2 /*return*/];
        });
    });
}
function bookDetails() {
    return __awaiter(this, void 0, void 0, function () {
        var bookDetailsTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            bookDetailsPage.style.display = "block";
            bookDetailsTable = document.getElementById("bookDetailsTable");
            len = bookDetailsTable.getElementsByTagName("tr").length;
            if (bookDetailsTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    bookDetailsTable.removeChild(bookDetailsTable.children[i]);
                }
            }
            BookDetailsList.forEach(function (book) {
                var row = document.createElement("tr");
                row.innerHTML = "<td>".concat(book.BookID, " <td>").concat(book.BookName, "</td> <td>").concat(book.AuthorName, "</td> <td>").concat(book.Availability, "</td> \n            <td>\n            <button onclick=\"editBook('").concat(book.BookID, "')\">Edit</button>\n            <button onclick=\"deleteBook('").concat(book.BookID, "')\">Delete</button>\n        </td>");
                bookDetailsTable.appendChild(row);
            });
            return [2 /*return*/];
        });
    });
}
var editBookID;
function deleteBook(bookID) {
    return __awaiter(this, void 0, void 0, function () {
        var index;
        return __generator(this, function (_a) {
            index = BookDetailsList.findIndex(function (val) { return val.BookID == bookID; });
            BookDetailsList.splice(index, 1);
            bookDetails();
            return [2 /*return*/];
        });
    });
}
function addBook() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            document.getElementById("addEditBookForm").style.display = "block";
            editBookID = "";
            return [2 /*return*/];
        });
    });
}
function editBook(bookID) {
    return __awaiter(this, void 0, void 0, function () {
        var book, bookName, authorname, availability;
        return __generator(this, function (_a) {
            document.getElementById("addEditBookForm").style.display = "block";
            book = BookDetailsList.find(function (val) { return val.BookID == bookID; });
            if (book) {
                bookName = document.getElementById("bookName");
                authorname = document.getElementById("authorname");
                availability = document.getElementById("availability");
                bookName.value = book.BookName;
                authorname.value = book.AuthorName.toString();
                availability.value = book.Availability.toString();
                editBookID = book.BookID;
            }
            return [2 /*return*/];
        });
    });
}
function addEditBook() {
    return __awaiter(this, void 0, void 0, function () {
        var bookName, authorname, availability, bookData;
        return __generator(this, function (_a) {
            bookName = document.getElementById("bookName");
            authorname = document.getElementById("authorname");
            availability = document.getElementById("availability");
            bookData = BookDetailsList.find(function (val) { return val.BookID == editBookID; });
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
            return [2 /*return*/];
        });
    });
}
function borrowBook() {
    return __awaiter(this, void 0, void 0, function () {
        var borrowBookTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            borrowBookPage.style.display = "block";
            borrowBookTable = document.getElementById("borrowBookTable");
            len = borrowBookTable.getElementsByTagName("tr").length;
            if (borrowBookTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    borrowBookTable.removeChild(borrowBookTable.children[i]);
                }
            }
            BookDetailsList.forEach(function (book) {
                var row = document.createElement("tr");
                row.innerHTML = "<td>".concat(book.BookID, " <td>").concat(book.BookName, "</td> <td>").concat(book.AuthorName, "</td> <td>").concat(book.Availability, "</td> \n    \n            <td>\n           \n            <button onclick=\"borrowselectedBook('").concat(book.BookID, "')\">Borrow</button>\n        </td>");
                borrowBookTable.appendChild(row);
            });
            return [2 /*return*/];
        });
    });
}
function borrowselectedBook(bookID) {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            BookDetailsList.forEach(function (book) {
                if (book.BookID == bookID) {
                    if (book.Availability == "available") {
                        var countuser_1 = 0;
                        BorrowDetailsList.forEach(function (borrow) {
                            if (borrow.UserID == currentUser.UserId && borrow.BookingStatus == "borrowed") {
                                countuser_1 += 1;
                            }
                        });
                        if (countuser_1 < 3) {
                            book.Availability = "issued";
                            var borrow = new BorrowDetails(book.BookID, currentUser.UserId, new Date(), "borrowed", 0);
                            alert("Borrowed successfuly .Your borrow ID is " + borrow.BorrowID);
                            BorrowDetailsList.push(borrow);
                        }
                        else {
                            alert("Already you have borrowed 3 books");
                        }
                    }
                    else if (book.Availability == "issued") {
                        var issueddate_1 = new Date();
                        BorrowDetailsList.forEach(function (borrow) {
                            if (borrow.BookID == book.BookID) {
                                issueddate_1 = borrow.BorrowDate;
                            }
                        });
                        console.log(issueddate_1.getDate() + 15);
                        issueddate_1.setDate(issueddate_1.getDate() + 15);
                        console.log(issueddate_1.toISOString());
                        var newDate = issueddate_1.toISOString().split('T')[0];
                        console.log(newDate);
                        alert("The book is already borrowed.The book will be available on ".concat(newDate));
                    }
                    else {
                        alert("The book is damaged");
                    }
                }
            });
            return [2 /*return*/];
        });
    });
}
function borrowHistory() {
    return __awaiter(this, void 0, void 0, function () {
        var borrowHistoryTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            borrowHistoryPage.style.display = "block";
            borrowHistoryTable = document.getElementById("borrowHistoryTable");
            len = borrowHistoryTable.getElementsByTagName("tr").length;
            if (borrowHistoryTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    borrowHistoryTable.removeChild(borrowHistoryTable.children[i]);
                }
            }
            BorrowDetailsList.forEach(function (borrow) {
                if (borrow.UserID == currentUser.UserId) {
                    var row = document.createElement("tr");
                    row.innerHTML = "<td>".concat(borrow.BorrowID, " <td>").concat(borrow.BookID, "</td> <td>").concat(borrow.UserID, "</td> <td>").concat(borrow.BorrowDate.toLocaleDateString(), "</td> <td>").concat(borrow.BookingStatus, "</td> \n            <td>").concat(borrow.PaidFineAmount, "</td> ");
                    borrowHistoryTable.appendChild(row);
                }
            });
            return [2 /*return*/];
        });
    });
}
function returnBook() {
    return __awaiter(this, void 0, void 0, function () {
        var returnTable, len, i;
        return __generator(this, function (_a) {
            displayNone();
            returnPage.style.display = "block";
            returnTable = document.getElementById("returnTable");
            len = returnTable.getElementsByTagName("tr").length;
            if (returnTable.hasChildNodes()) {
                for (i = len - 1; i >= 1; i--) {
                    returnTable.removeChild(returnTable.children[i]);
                }
            }
            BorrowDetailsList.forEach(function (borrow) {
                if (borrow.UserID == currentUser.UserId && borrow.BookingStatus == "borrowed") {
                    var row = document.createElement("tr");
                    row.innerHTML = "<td>".concat(borrow.BorrowID, " <td>").concat(borrow.BookID, "</td> <td>").concat(borrow.UserID, "</td> <td>").concat(borrow.BorrowDate.toLocaleDateString(), "</td> <td>").concat(borrow.BookingStatus, "</td> \n            <td>").concat(borrow.PaidFineAmount, "</td> \n            <td><button id=\"returnbtn\" onclick=\"returnParticularBook('").concat(borrow.BorrowID, "')\">Return</button></td>");
                    returnTable.appendChild(row);
                }
            });
            return [2 /*return*/];
        });
    });
}
function addDays(date, days) {
    var newDate = new Date(date);
    newDate.setDate(date.getDate() + days);
    return newDate;
}
function returnParticularBook(borrowid) {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            console.log(borrowid);
            BorrowDetailsList.forEach(function (borrow) {
                var _a, _b;
                if (borrow.BorrowID == borrowid) {
                    var newDate = addDays(borrow.BorrowDate, 15);
                    console.log((newDate));
                    var fineamount = 0;
                    if (newDate < new Date()) {
                        var isdamaged = (_a = prompt("Book is damaged or not")) === null || _a === void 0 ? void 0 : _a.toLowerCase();
                        if (isdamaged == "yes") {
                            fineamount += 300;
                            if (currentUser.WalletBalance < fineamount) {
                                alert("Insufficient balance. Please recharge and proceed");
                            }
                            else {
                                currentUser.WalletBalance -= fineamount;
                                borrow.BookingStatus = "Returned";
                                alert("Book returned successfully");
                            }
                        }
                        else {
                            borrow.BookingStatus = "Returned";
                            alert("Book returned successfully");
                        }
                    }
                    else {
                        var finedays = newDate.getDate() - new Date().getDate();
                        fineamount += finedays;
                        var isdamaged = (_b = prompt("Book is damaged or not")) === null || _b === void 0 ? void 0 : _b.toLowerCase();
                        if (isdamaged == "yes") {
                            fineamount += 300;
                            if (currentUser.WalletBalance < fineamount) {
                                alert("Insufficient balance. Please recharge and proceed");
                            }
                            else {
                                currentUser.WalletBalance -= fineamount;
                                borrow.BookingStatus = "Returned";
                                alert("Book returned successfully");
                            }
                        }
                        else {
                            borrow.BookingStatus = "Returned";
                            alert("Book returned successfully");
                        }
                    }
                }
            });
            return [2 /*return*/];
        });
    });
}
function topup() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            topPage.style.display = "block";
            document.getElementById("currentBalance").innerHTML = "Available Balance :".concat(currentUser.WalletBalance);
            return [2 /*return*/];
        });
    });
}
function deposit() {
    return __awaiter(this, void 0, void 0, function () {
        var amount;
        return __generator(this, function (_a) {
            amount = document.getElementById("amount");
            currentUser.WalletBalance += Number(amount.value);
            alert("Amount Deposited Successfully");
            amount.value = "";
            document.getElementById("currentBalance").innerHTML = "Available Balance :".concat(currentUser.WalletBalance);
            return [2 /*return*/];
        });
    });
}
function logout() {
    return __awaiter(this, void 0, void 0, function () {
        return __generator(this, function (_a) {
            displayNone();
            document.getElementById("menu").style.display = "none";
            document.getElementById("box").style.display = "block";
            return [2 /*return*/];
        });
    });
}
