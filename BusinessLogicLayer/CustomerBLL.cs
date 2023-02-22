using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class CustomerBLL
    {
        CustomerDAL customerDAL = new CustomerDAL();
        public DataTable GetDataCustomerBLL()
        {
            return customerDAL.GetDataCustomerDAL();
        }
        public int CheckExistsCustomerIdBLL(CustomerDTO customerDTO)
        {
            return customerDAL.CheckExistsCustomerIdDAL(customerDTO);
        }
        public bool AddCustomerBLL(CustomerDTO customerDTO)
        {
            return customerDAL.AddCustomerDAL(customerDTO);
        }
        public bool UpdateCustomerBLL(CustomerDTO customerDTO)
        {
            return customerDAL.UpdateCustomerDAL(customerDTO);
        }
        public bool DeleteCustomerBLL(CustomerDTO customerDTO)
        {
            return customerDAL.DeleteCustomerDAL(customerDTO);
        }
        public DataTable SearchDataCustomerBLL(CustomerDTO customerDTO)
        {
            return customerDAL.SearchDataCustomerDAL(customerDTO);
        }
        public DataTable GetCustomerName(CustomerDTO customerDTO)
        {
            return customerDAL.GetCustomerNameDAL(customerDTO);
        }
        public int GetCustomerIdBLL(CustomerDTO customerDTO)
        {
            return customerDAL.GetCustomerIdDAL(customerDTO);
        }
    }
}
