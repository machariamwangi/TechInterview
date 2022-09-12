using System.Collections;

namespace EmployeeHierachy
{
    public class Employees
    {
        //To Store List of employee
        ArrayList employeeList;
        

        //Coonstructor that Takes a csv as a string 
        public Employees(string csv)
        {
            try
            {
                employeeList = FilterCSVToArray(csv);
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        public ArrayList FilterCSVToArray(string csv)
        {
            ArrayList cleanedData = new ArrayList();
            if (string.IsNullOrEmpty(csv) || !(csv is string))
            {
                throw new Exception("csv cannot be null");

            }

            //In CSV (Comma Separated Values), each line corresponds to a row, and columns are separated by a comma.
            // We first divide data into rows so that we may and save the individual row as an array.

            string[] datarows = csv.Split(
            new string[] { "\r\n", "\r", "\n" },
            StringSplitOptions.None
            );


            //After we have the rows in an array as words separated by commas, we split the words rows into arrays.
            // The purpose of doing this is to be able to validate each data separately.

            foreach (string row in datarows)
            {
                string[] data = row.Split(',');
                ArrayList filteredData = new ArrayList();

                foreach (string cell in data)
                {
                    filteredData.Add(cell);
                }
                if (filteredData.Count != 3)
                {
                    throw new Exception("CSV value must have 3 values in each row");
                }
                cleanedData.Add(filteredData);
            }

            return cleanedData;
        }






    }
}