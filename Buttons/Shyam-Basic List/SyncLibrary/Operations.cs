using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SyncLibrary
{
  public class Operations
  {
    public static CustomList<UserDetailsClass> users = new CustomList<UserDetailsClass>();
    public static CustomList<BookDetails> books = new CustomList<BookDetails>();
    public static CustomList<BorrowDetails> borrows = new CustomList<BorrowDetails>();
    UserDetailsClass currentLoggedInUser;

    public void DefaultData()
    {
      //Add the default values into the CustomList
      UserDetailsClass user1 = new UserDetailsClass("Ravichandran", GenderClassification.Male, "EEE", "ravi@gmail.com", 9938388333, 1000);
      UserDetailsClass user2 = new UserDetailsClass("Priyadharshini", GenderClassification.Female, "CSE", "priya@gmail.com", 9944444455, 2000);
      users.AddRange(new CustomList<UserDetailsClass>() { user1, user2 });

      BookDetails book1 = new BookDetails("C#", "Author1", AvailabilityStatus.Issued);
      BookDetails book2 = new BookDetails("C#", "Author1", AvailabilityStatus.Issued);
      BookDetails book3 = new BookDetails("C#", "Author1", AvailabilityStatus.Issued);
      BookDetails book4 = new BookDetails("HTML", "Author2", AvailabilityStatus.Available);
      BookDetails book5 = new BookDetails("HTML", "Author2", AvailabilityStatus.Damaged);
      BookDetails book6 = new BookDetails("CSS", "Author1", AvailabilityStatus.Available);
      BookDetails book7 = new BookDetails("CSS", "Author1", AvailabilityStatus.Available);
      BookDetails book8 = new BookDetails("JS", "Author1", AvailabilityStatus.Available);
      BookDetails book9 = new BookDetails("JS", "Author1", AvailabilityStatus.Available);
      BookDetails book10 = new BookDetails("JS", "Author1", AvailabilityStatus.Available);
      BookDetails book11 = new BookDetails("TS", "Author2", AvailabilityStatus.Available);
      BookDetails book12 = new BookDetails("TS", "Author2", AvailabilityStatus.Damaged);
      BookDetails book13 = new BookDetails("TS", "Author2", AvailabilityStatus.Available);
      books.AddRange(new CustomList<BookDetails>() { book1, book2, book3, book4, book5, book6, book7, book8, book9, book10, book11 });

      BorrowDetails borrow1 = new BorrowDetails("BID1001", "SF3001", new DateTime(2024, 09, 10), BookingStatus.Borrowed, 0);
      BorrowDetails borrow2 = new BorrowDetails("BID1003", "SF3001", new DateTime(2024, 09, 10), BookingStatus.Borrowed, 0);
      BorrowDetails borrow3 = new BorrowDetails("BID1004", "SF3001", new DateTime(2024, 08, 14), BookingStatus.Returned, 16);
      BorrowDetails borrow4 = new BorrowDetails("BID1002", "SF3002", new DateTime(2024, 09, 11), BookingStatus.Borrowed, 0);
      BorrowDetails borrow5 = new BorrowDetails("BID1005", "SF3002", new DateTime(2024, 07, 07), BookingStatus.Returned, 20);
      borrows.AddRange(new CustomList<BorrowDetails>() { borrow1, borrow2, borrow3, borrow4, borrow5 });
    }
    public void ReadFiles()
    {
      users.AddRange(Filemanager<UserDetailsClass>.ReadFromCSV());
      books.AddRange(Filemanager<BookDetails>.ReadFromCSV());
      borrows.AddRange(Filemanager<BorrowDetails>.ReadFromCSV());
    }
    public void WriteFiles()
    {
      Filemanager<UserDetailsClass>.WriteToCSV(users);
      Filemanager<BorrowDetails>.WriteToCSV(borrows);
      Filemanager<BookDetails>.WriteToCSV(books);

    }

    public void MainMenu()
    {
      bool flag = true;

      do
      {
        //ask the user whether he do registration or login or exit
        Console.WriteLine("1.registration\n2.Login\n3.Exit");
        switch (int.Parse(Console.ReadLine()))
        {
          case 1:
            {
              //call registration method
              Registration();
              break;
            }
          case 2:
            {
              //call login method
              Login();
              break;
            }
          case 3:
            {
              //exit
              Console.WriteLine("Exit from main menu");
              flag = false;
              break;
            }
        }
      } while (flag);

    }

    public void Registration()
    {
      //string userName,GenderClassification gender,string department,long mobileNumber,string mailID,double walletBalance)
      //get all details from user 
      Console.WriteLine("Enter the name:");
      string userName = Console.ReadLine();
      Console.WriteLine("Enter gender");
      GenderClassification gender = Enum.Parse<GenderClassification>(Console.ReadLine(), true);
      Console.WriteLine("Enter department");
      string department = Console.ReadLine();
      Console.WriteLine("Enter Mobile number");
      long mobileNumber = Convert.ToInt64(Console.ReadLine());
      Console.WriteLine("Enter mailID");
      string mailID = Console.ReadLine();
      Console.WriteLine("Enter walletBalance");
      double walletBalance = Convert.ToDouble(Console.ReadLine());
      UserDetailsClass user = new UserDetailsClass(userName, gender, department, mailID, mobileNumber, walletBalance);
      users.Add(user);
      Console.WriteLine("Registered successfully and your id is " + user.CustomerID);

    }

    public void Login()
    {
      //bool flag = true;
      //ask customer id
      Console.WriteLine("Enter customer id");
      string customerID = Console.ReadLine().ToUpper();
      SearchUtility<UserDetailsClass>.BinarySearch(users,customerID,"CustomerID",out UserDetailsClass user);
      currentLoggedInUser=user;
      if(currentLoggedInUser!=null)
      {
        System.Console.WriteLine($"Login Successful\n******Welcome {user.UserName} *******");
        SubMenu();
      }
      else
      {
        System.Console.WriteLine("invalid User");
      }
    }

    public void SubMenu()
    {
      bool flag1 = true;
      do
      {
        Console.WriteLine("**submenu**");
        //ask the user to choose below options
        Console.WriteLine("1.BorrowBook\n2.ShowBorrowedHistory\n3.ReturnBooks\n4.walletRecharge\n5.Exit");
        switch (int.Parse(Console.ReadLine()))
        {
          case 1:
            {
              //call BorrowBook method
              BorrowBook();
              break;
            }
          case 2:
            {
              //call showBorrowedHistory method
              ShowBorrowedHistory();
              break;
            }
          case 3:
            {
              //call Returnbooks() method
              ReturnBooks();
              break;
            }
          case 4:
            {
              //walletReacharge method
              WalletRecharge();
              break;
            }
          case 5:
            {
              //exit
              Console.WriteLine("Exit from submenu");
              flag1 = false;
              break;
            }
        }

      } while (flag1);
    }

    public void BorrowBook()
    {
      //•	Show the Books available by traversing the books CustomList.
      Grid<BookDetails>.PrintTables(books);
      //•	Then ask and get the bookID by “Enter a Book ID to borrow”.
      int count = 0;
      bool flag = true;
      Console.WriteLine("Enter a book ID to borrow");
      string bookID = Console.ReadLine().ToUpper();
      foreach (BookDetails book in books)
      {
        if (bookID.Equals(book.BookID))
        {
          flag = false;
          //check if the book status is Available.
          if (book.Status.Equals(AvailabilityStatus.Available))
          {
            //Then you need to check if the user has already borrowed any books by traversing his borrowed CustomList. Because a user is allowed to borrow a maximum of only 3 books at a time. 
            foreach (BorrowDetails borrow in borrows)
            {
              if (currentLoggedInUser.CustomerID.Equals(borrow.UserID) && borrow.BookStatus.Equals(BookingStatus.Borrowed))
              {
                count++;
              }
            }

            if (count == 3)
            {
              Console.WriteLine("You have borrowed 3 books already");
            }
            else
            {
              
              book.Status = AvailabilityStatus.Issued;

              //string bookID,string userID,DateTime borrowedDate,BookingStatus bookStatus,double paidFineAmount)
              BorrowDetails borrow1 = new BorrowDetails(book.BookID, currentLoggedInUser.CustomerID, DateTime.Now, BookingStatus.Borrowed, 0);
              borrows.Add(borrow1);
              Console.WriteLine("Borrowed successfully and BorrowID is " + borrow1.BorrowID);
            }
            

          }

          else
          {
            //If it is not available, display as “Books is {Availability Status}”.
            Console.WriteLine("Book is" + book.Status);
            //o	If a book is in an Issued status, then print the next available date of a book by retrieving its Borrowed Date from the borrowed history and adding 15 days to it.
            if (book.Status.Equals(AvailabilityStatus.Issued))
            {
              foreach (BorrowDetails borrow in borrows)
              {
                if (book.BookID.Equals(borrow.BookID))
                {
                  Console.WriteLine("The book will be available on " + borrow.BorrowedDate.AddDays(15).ToString("dd/MM/yyyy"));
                }
              }

            }
          }
        }



      }
      //•	If the bookID is not available, then display “Invalid Book ID. Please enter the valid one”.
      if (flag)
      {
        Console.WriteLine("Invalid Book ID. Please enter the valid one");

      }

    }
    public void ShowBorrowedHistory()
    {
      //show the borrow history of currentlogged in used
      bool flag = true;
      foreach (BorrowDetails borrow in borrows)
      {
        if (currentLoggedInUser.CustomerID.Equals(borrow.UserID))
        {
          flag = false;
          //string bookID,string userID,DateTime borrowedDate,BookingStatus bookStatus,double paidFineAmount)
          Console.WriteLine($"{borrow.BorrowID} | {borrow.BookID} | {borrow.UserID} | {borrow.BorrowedDate.ToString("dd/MM/yyyy")} | {borrow.BookStatus} | {borrow.PaidFineAmount}");
        }

      }
      if (flag)
      {
        Console.WriteLine("No history found");
      }

    }
    public void ReturnBooks()
    {
      //Show the borrowed book details of the current user.
      bool flag1 = true;
      foreach (BorrowDetails borrow in borrows)
      {
        if (currentLoggedInUser.CustomerID.Equals(borrow.UserID) && borrow.BookStatus.Equals(BookingStatus.Borrowed))
        {
          Console.WriteLine($"{borrow.BorrowID} | {borrow.BookID} | {borrow.UserID} | {borrow.BorrowedDate.ToString("dd/MM/yyyy")} | {borrow.BookStatus} | {borrow.PaidFineAmount}");
          flag1 = false;
        }

      }
      if (flag1)
      {
        Console.WriteLine("No history found");
        return;
      }
      Console.WriteLine("Enter a borrow ID");
      string borrowID = Console.ReadLine().ToUpper();
      bool flag = true;
      foreach (BorrowDetails borrow in borrows)
      {
        //•	If BorrowID is valid then, check the return date (15 days from borrow date), if the date has elapsed, then calculate and show the fine amount (Rs. 1 / per day) for each book.
        if (currentLoggedInUser.CustomerID.Equals(borrow.UserID) && borrowID.Equals(borrow.BorrowID) && borrow.BookStatus.Equals(BookingStatus.Borrowed))
        {

          flag = false;
          TimeSpan difference = DateTime.Now - borrow.BorrowedDate;
          double totalFineAmount = 0;
          double lateFine = 0;
          if (difference.TotalDays > 15)
          {
            int elapseDay = difference.Days - 15;
            lateFine = elapseDay * 1;
            //•	Check the book's condition, if its status is Damaged, add fine Rs. 300. 
            Console.WriteLine("is it damaged?yes/no");
            string status = Console.ReadLine().ToUpper();

            if (status.Equals("yes"))
            {
              totalFineAmount = lateFine + 300;
              //check whether the user has sufficient balance for the fine amount.
              if (totalFineAmount <= currentLoggedInUser.WalletBalance)
              {
                currentLoggedInUser.DeductBalance(totalFineAmount);
                borrow.BookStatus = BookingStatus.Returned;
                borrow.PaidFineAmount = totalFineAmount;
                foreach (BookDetails book in books)
                {
                  if (book.BookID.Equals(borrow.BookID))
                  {
                    book.Status = AvailabilityStatus.Available;
                  }
                }
              }
              else
              {
                Console.WriteLine("Insufficient balance");
              }
            }
            else
            {
              borrow.BookStatus = BookingStatus.Returned;
              borrow.PaidFineAmount = totalFineAmount;
              foreach (BookDetails book in books)
              {
                if (book.BookID.Equals(borrow.BookID))
                {
                  book.Status = AvailabilityStatus.Available;
                  Console.WriteLine("Returned successfully");
                }
              }
            }

          }
          else
          {
            Console.WriteLine("is it damaged?yes/no");
            string status = Console.ReadLine().ToUpper();

            if (status.Equals("yes"))
            {
              totalFineAmount = lateFine + 300;

              if (totalFineAmount <= currentLoggedInUser.WalletBalance)
              {
                currentLoggedInUser.DeductBalance(totalFineAmount);
                borrow.BookStatus = BookingStatus.Returned;
                borrow.PaidFineAmount = totalFineAmount;
                foreach (BookDetails book in books)
                {
                  if (book.BookID.Equals(borrow.BookID))
                  {
                    book.Status = AvailabilityStatus.Available;
                    Console.WriteLine("Returned successfully");
                  }
                }
              }
              else
              {
                Console.WriteLine("Insufficient balance");
              }
            }
            else
            {
              borrow.BookStatus = BookingStatus.Returned;
              borrow.PaidFineAmount = totalFineAmount;
              foreach (BookDetails book in books)
              {
                if (book.BookID.Equals(borrow.BookID))
                {
                  book.Status = AvailabilityStatus.Available;
                  Console.WriteLine("Returned successfully");
                }
              }
            }
            
          }
        }
      
      }


    


      //•	If the user given BorrowID is invalid, then show “Invalid BorrowID, please enter the valid one”.
      if (flag)
      {
        Console.WriteLine("Invalid Borrow ID,please enter valid id");
      }
    }




    public void WalletRecharge()
    {
      Console.WriteLine("Enter the amount to recharge:");
      double amount = Convert.ToDouble(Console.ReadLine());
      //double balance = currentLoggedInUser.WalletRecharge(amount);
      Console.WriteLine("The wallet balance is :" + currentLoggedInUser.WalletRecharge(amount));

    }
  }

}