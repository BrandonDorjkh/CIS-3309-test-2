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
    class EmployeeListClass
    {
        private EmployeeClass Employee = new EmployeeClass();
        private int index;   // holds index of element in list that contains the employee
        //     who has logged in

        private List<EmployeeClass> InternalList;
        // private EmployeeClass emp = new EmployeeClass();


        // Parameterless constructor
        public EmployeeListClass()
        {
            InternalList = new List<EmployeeClass>(4);
        }  // end parameterless constructor
           // Find an employee in the list of employees
           // Returns: A reference to the Employee object containing the Employee's AccessID or
           //      null if not found
        public bool findEmployeeInList
           (int ID)   // IN: Employee AccessID to be checked.  This is the ID entered by the Employee
        {
            index = 0;
            foreach (EmployeeClass emp in InternalList)
            {
                if (emp.checkEmployeeID(ID) == true)
                    return true;
                else
                    index++;
            }
            return false;
        }  // end findEmployeeInList
           // Verify Pin
           // Calls Employee verify pin to verify the pin in the current Employee Object
        public Boolean verifyPin(int pin)
        {
            return Employee.verifyPin(pin, InternalList[index]);
        }  // end verifyPin

        // Initialize entire employee list given data in current Book File 
        public Boolean initializeEntireList()
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;

            nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countProcessedRecords++;
                EmployeeClass emp = new EmployeeClass();
                success = emp.populateEmployeeObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                    ("Unable to create an Employee Object.  Employee list not created.",
                     "Employee List Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
                InternalList.Add(emp);
                nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            } //end While

            if (countProcessedRecords > 0)
                return true;
            else
                return false;
        }  // end initializeEntireList
    }
}
