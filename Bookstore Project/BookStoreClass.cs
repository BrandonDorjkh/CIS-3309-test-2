//Brandon Dorjkhand
//CIS 3309
//Lab Project 2 Bookstore
// 2/19/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookstore_Project
{
    class BookStoreClass
    {
        // Books and the EmployeeList and all the text files belong to the Bookstore
        public BookClass Book = new BookClass();
        public EmployeeListClass EmployeeList = new EmployeeListClass();

        // The Files the Bookstore Owns
        private static string currentBookFilePath = "currentBookFile.txt";
        private static string updatedBookFilePath = "updatedBookFile.txt";
        private static string currentEmployeeFilePath = "currentEmployeeFile.txt";
        private static string updatedEmployeeFilePath = "updatedEmployeeFile.txt";

        public static CurrentFileClass currentBookFile = new
            CurrentFileClass(currentBookFilePath);
        public static UpdatedFileClass updatedBookFile = new
            UpdatedFileClass(updatedBookFilePath);
        public static CurrentFileClass currentEmployeeFile = new
            CurrentFileClass(currentEmployeeFilePath);
        public static UpdatedFileClass updatedEmployeeFile = new
            UpdatedFileClass(updatedEmployeeFilePath);

        // Bookstore parameters (Named constants defined by the Bookstore)
        private int hiddenAccessIDLength = 5;   // Length of AccessNet ID
        private int hiddenISBNLeftLength = 3;   // Length of left part of ISBN
        private int hiddenISBNRightLength = 3;  // Length of right part of ISBN
        // Number of attempts BookStore allows a user before terminating an inventory 
        //    update session
        private int hiddenTryCountMax = 3;

        // Displays the list of employees (After they were written to the Employee File)
        public void writeEntireEmployeeList()
        {
           // EmployeeListClass.displayEntireList();
        }   // end writeEntireEmployeeList

    }
}
