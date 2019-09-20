/* Title:           Department Class
 * Date:            10-3-18
 * Author:          Terrance Holmes
 * 
 * Description:     This is the class used for the Departments */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace DepartmentDLL
{
    public class DepartmentClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        DepartmentDataSet aDepartmentDataSet;
        DepartmentDataSetTableAdapters.departmentTableAdapter aDepartmentTableAdapter;

        InsertDepartmentEntryTableAdapters.QueriesTableAdapter aInsertDepartmentTableAdapter;

        FindSortedDepartmentDataSet aFindSortedDepartmentDataSet;
        FindSortedDepartmentDataSetTableAdapters.FindSortedDepartmentTableAdapter aFindSortedDepartmentTableAdapter;

        FindDepartmentByNameDataSet aFindDepartmentByNameDataSet;
        FindDepartmentByNameDataSetTableAdapters.FindDepartmentByNameTableAdapter aFindDepartmentByNameTableAdapter;

        FindDepartmentByDepartmentIDDataSet aFindDepartmentByDepartmentIDDataSet;
        FindDepartmentByDepartmentIDDataSetTableAdapters.FindDepartmentByDepartmentIDTableAdapter aFindDepartmentByDepartmentIDTableAdapter;

        FindDepartmentEmployeesDataSet aFindDepartmentEmployeesDataSet;
        FindDepartmentEmployeesDataSetTableAdapters.FindDepartmentEmployeesTableAdapter aFindDepartmentEmployeesTableAdapter;

        FindDepartmentHourlyEmployeesDataSet aFindDepartmentHourlyEmployeesDataSet;
        FindDepartmentHourlyEmployeesDataSetTableAdapters.FindDepartmentHourlyEmployeesTableAdapter aFindDepartmentHourlyEmployeesTableAdapter;

        public FindDepartmentHourlyEmployeesDataSet FindDepartmentHourlyEmployees(string strDepartment)
        {
            try
            {
                aFindDepartmentHourlyEmployeesDataSet = new FindDepartmentHourlyEmployeesDataSet();
                aFindDepartmentHourlyEmployeesTableAdapter = new FindDepartmentHourlyEmployeesDataSetTableAdapters.FindDepartmentHourlyEmployeesTableAdapter();
                aFindDepartmentHourlyEmployeesTableAdapter.Fill(aFindDepartmentHourlyEmployeesDataSet.FindDepartmentHourlyEmployees, strDepartment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Find Department Hourly Employees " + Ex.Message);
            }

            return aFindDepartmentHourlyEmployeesDataSet;
        }
        public FindDepartmentEmployeesDataSet FindDepartmedntEmployees(string strDepartment)
        {
            try
            {
                aFindDepartmentEmployeesDataSet = new FindDepartmentEmployeesDataSet();
                aFindDepartmentEmployeesTableAdapter = new FindDepartmentEmployeesDataSetTableAdapters.FindDepartmentEmployeesTableAdapter();
                aFindDepartmentEmployeesTableAdapter.Fill(aFindDepartmentEmployeesDataSet.FindDepartmentEmployees, strDepartment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Find Department Employees " + Ex.Message);
            }

            return aFindDepartmentEmployeesDataSet;
        }
        public FindDepartmentByDepartmentIDDataSet FindDepartmentByDepartmentID(int intDepartmentID)
        {
            try
            {
                aFindDepartmentByDepartmentIDDataSet = new FindDepartmentByDepartmentIDDataSet();
                aFindDepartmentByDepartmentIDTableAdapter = new FindDepartmentByDepartmentIDDataSetTableAdapters.FindDepartmentByDepartmentIDTableAdapter();
                aFindDepartmentByDepartmentIDTableAdapter.Fill(aFindDepartmentByDepartmentIDDataSet.FindDepartmentByDepartmentID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Find Department By Department ID " + Ex.Message);
            }

            return aFindDepartmentByDepartmentIDDataSet;
        }
        public FindDepartmentByNameDataSet FindDepartmentByName(string strDepartment)
        {
            try
            {
                aFindDepartmentByNameDataSet = new FindDepartmentByNameDataSet();
                aFindDepartmentByNameTableAdapter = new FindDepartmentByNameDataSetTableAdapters.FindDepartmentByNameTableAdapter();
                aFindDepartmentByNameTableAdapter.Fill(aFindDepartmentByNameDataSet.FindDepartmentByName, strDepartment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Find Department By Name " + Ex.Message);
            }

            return aFindDepartmentByNameDataSet;
        }
        public FindSortedDepartmentDataSet FindSortedDepartment()
        {
            try
            {
                aFindSortedDepartmentDataSet = new FindSortedDepartmentDataSet();
                aFindSortedDepartmentTableAdapter = new FindSortedDepartmentDataSetTableAdapters.FindSortedDepartmentTableAdapter();
                aFindSortedDepartmentTableAdapter.Fill(aFindSortedDepartmentDataSet.FindSortedDepartment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Find Sorted Department " + Ex.Message);
            }

            return aFindSortedDepartmentDataSet;
        }
        public bool InsertDepartment(string strDepartment)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDepartmentTableAdapter = new InsertDepartmentEntryTableAdapters.QueriesTableAdapter();
                aInsertDepartmentTableAdapter.InsertDepartment(strDepartment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Insert Department " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DepartmentDataSet GetDepartmentInfo()
        {
            try
            {
                aDepartmentDataSet = new DepartmentDataSet();
                aDepartmentTableAdapter = new DepartmentDataSetTableAdapters.departmentTableAdapter();
                aDepartmentTableAdapter.Fill(aDepartmentDataSet.department);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Get Department Info " + Ex.Message);
            }

            return aDepartmentDataSet;
        }
    }
}
