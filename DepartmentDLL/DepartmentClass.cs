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

        DepartmentProductionEmailDataSet aDepartmentProductionEmailDataSet;
        DepartmentProductionEmailDataSetTableAdapters.departmentproductionemailTableAdapter aDepartmentProductionEmailTableAdatper;

        InsertDepartmentProductionEmailEntryTableAdapters.QueriesTableAdapter aInsertDepartmedntProudctionEmailTableAdapter;

        RemoveDepartmentProductionEmailEntryTableAdapters.QueriesTableAdapter aRemoveDepartmentProductionEmailTableAdapter;

        FindDepartmentProductionEmailByDepartmentIDDataSet aFindDepartmentProductionEmailByDepartmentIDDataSet;
        FindDepartmentProductionEmailByDepartmentIDDataSetTableAdapters.FindDepartmentProductionEmailByDepartmentIDTableAdapter aFindDepartmentProductionEmailByDepartmentIDTableAdapter;

        DepartmentProductionEmailProjectsDataSet aDepartmentProductionEmailProjectsDataSet;
        DepartmentProductionEmailProjectsDataSetTableAdapters.departmentproductionemailprojectsTableAdapter aDepartmentProductionEmailProjectsTableAdapter;

        InsertDepartmentProductionEmailProjectEntryTableAdapters.QueriesTableAdapter aInsertDepartmentProductionEmailProjectTableAdapter;

        UpdateDepartmentProductionEmailProjectEntryTableAdapters.QueriesTableAdapter aUpdateDeparmentProductionEmailProjectTableAdapter;

        FindActiveDepartmentProductionEmailProjectsByDepartmentIDDataSet aFindActiveDepartmentProductionEmailProjectsByDepartmentIDDataSet;
        FindActiveDepartmentProductionEmailProjectsByDepartmentIDDataSetTableAdapters.FindActiveDepartmentProductionEmailProjectsByDepartmentIDTableAdapter aFindActiveDepartmentProductionEmailProjectsByDepartmentIDTableAdapter;

        public FindActiveDepartmentProductionEmailProjectsByDepartmentIDDataSet FindActiveDepartmentProductionEmailProjectsByDepartmentID(int intDepartmentID)
        {
            try
            {
                aFindActiveDepartmentProductionEmailProjectsByDepartmentIDDataSet = new FindActiveDepartmentProductionEmailProjectsByDepartmentIDDataSet();
                aFindActiveDepartmentProductionEmailProjectsByDepartmentIDTableAdapter = new FindActiveDepartmentProductionEmailProjectsByDepartmentIDDataSetTableAdapters.FindActiveDepartmentProductionEmailProjectsByDepartmentIDTableAdapter();
                aFindActiveDepartmentProductionEmailProjectsByDepartmentIDTableAdapter.Fill(aFindActiveDepartmentProductionEmailProjectsByDepartmentIDDataSet.FindActiveDepartmentProductionEmailProjectsByDepartmentID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Deparment Class // Find Active Department Production Email Projects By Department ID " + Ex.Message); 
            }

            return aFindActiveDepartmentProductionEmailProjectsByDepartmentIDDataSet;
        }
        public bool UpdateDepartmentProductionEmailProject(int intTransactionID, bool blnProjectActive)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateDeparmentProductionEmailProjectTableAdapter = new UpdateDepartmentProductionEmailProjectEntryTableAdapters.QueriesTableAdapter();
                aUpdateDeparmentProductionEmailProjectTableAdapter.UpdateDepartmentProductionEmailProject(intTransactionID, blnProjectActive);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Update Department Production Email Project " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertDepartmentProductionEmailProject(int intDepartmentID, string strProjectSuffix)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDepartmentProductionEmailProjectTableAdapter = new InsertDepartmentProductionEmailProjectEntryTableAdapters.QueriesTableAdapter();
                aInsertDepartmentProductionEmailProjectTableAdapter.InsertDepartmentProductionEmailProject(intDepartmentID, strProjectSuffix);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Insert Department Production Email Project " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DepartmentProductionEmailProjectsDataSet GetDepartmentProductionEmailProjectsInfo()
        {
            try
            {
                aDepartmentProductionEmailProjectsDataSet = new DepartmentProductionEmailProjectsDataSet();
                aDepartmentProductionEmailProjectsTableAdapter = new DepartmentProductionEmailProjectsDataSetTableAdapters.departmentproductionemailprojectsTableAdapter();
                aDepartmentProductionEmailProjectsTableAdapter.Fill(aDepartmentProductionEmailProjectsDataSet.departmentproductionemailprojects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Get Department Production Email Projects Info " + Ex.Message);
            }

            return aDepartmentProductionEmailProjectsDataSet;
        }
        public void UpdateDepartProductionEmailProjectsDB(DepartmentProductionEmailProjectsDataSet aDepartmentProductionEmailProjectsDataSet)
        {
            try
            {
                aDepartmentProductionEmailProjectsTableAdapter = new DepartmentProductionEmailProjectsDataSetTableAdapters.departmentproductionemailprojectsTableAdapter();
                aDepartmentProductionEmailProjectsTableAdapter.Update(aDepartmentProductionEmailProjectsDataSet.departmentproductionemailprojects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Update Department Production Email Projects DB " + Ex.Message);
            }
        }
        public FindDepartmentProductionEmailByDepartmentIDDataSet FindDepartmentProductionEmailByDepartmentID(int intDepartmentID)
        {
            try
            {
                aFindDepartmentProductionEmailByDepartmentIDDataSet = new FindDepartmentProductionEmailByDepartmentIDDataSet();
                aFindDepartmentProductionEmailByDepartmentIDTableAdapter = new FindDepartmentProductionEmailByDepartmentIDDataSetTableAdapters.FindDepartmentProductionEmailByDepartmentIDTableAdapter();
                aFindDepartmentProductionEmailByDepartmentIDTableAdapter.Fill(aFindDepartmentProductionEmailByDepartmentIDDataSet.FindDepartmentProductionEmailByDepartmentID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Find Department Production Email By Department ID " + Ex.Message);
            }

            return aFindDepartmentProductionEmailByDepartmentIDDataSet;
        }
        public bool RemoveDepartmentProuctionEmail(int intTransactionID)
        {
            bool blnFatalError = false;

            try
            {
                aRemoveDepartmentProductionEmailTableAdapter = new RemoveDepartmentProductionEmailEntryTableAdapters.QueriesTableAdapter();
                aRemoveDepartmentProductionEmailTableAdapter.RemoveDepartmentProductionEmail(intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Remove Department Production Email " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertDepartmentProductionEmail(int intEmployeeID, int intDepartmentID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertDepartmedntProudctionEmailTableAdapter = new InsertDepartmentProductionEmailEntryTableAdapters.QueriesTableAdapter();
                aInsertDepartmedntProudctionEmailTableAdapter.InsertDepartmentProductionEmail(intEmployeeID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Insert Department Production Email " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public DepartmentProductionEmailDataSet GetDepartmentProductionEmailInfo()
        {
            try
            {
                aDepartmentProductionEmailDataSet = new DepartmentProductionEmailDataSet();
                aDepartmentProductionEmailTableAdatper = new DepartmentProductionEmailDataSetTableAdapters.departmentproductionemailTableAdapter();
                aDepartmentProductionEmailTableAdatper.Fill(aDepartmentProductionEmailDataSet.departmentproductionemail);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Get Department Production Email Info " + Ex.Message);
            }

            return aDepartmentProductionEmailDataSet;
        }
        public void UpdateDepartmentProductionEmailDB(DepartmentProductionEmailDataSet aDepartmentProductionEmailDataSet)
        {
            try
            {
                aDepartmentProductionEmailTableAdatper = new DepartmentProductionEmailDataSetTableAdapters.departmentproductionemailTableAdapter();
                aDepartmentProductionEmailTableAdatper.Update(aDepartmentProductionEmailDataSet.departmentproductionemail);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Department Class // Get Department Production Email Info " + Ex.Message);
            }
        }
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
