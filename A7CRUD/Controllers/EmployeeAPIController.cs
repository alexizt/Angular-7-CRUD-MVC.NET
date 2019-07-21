using A7CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace A7CRUD.Controllers
{
    [RoutePrefix("Api/Employee")]
    public class EmployeeAPIController : ApiController
    {
        WebApiDbEntities objEntity = new WebApiDbEntities();


        [HttpGet]
        [Route("AllEmployeeDetails")]
        public IQueryable<EmployeeDetails> GetEmployee()
        {
            try
            {
                return objEntity.EmployeeDetails;
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet]
        [Route("GetEmployeeDetailsById/{employeeId}")]
        public IHttpActionResult GetEmployeeById(string employeeId)
        {
            EmployeeDetails objEmp = new EmployeeDetails();
            int ID = Convert.ToInt32(employeeId);
            try
            {
                objEmp = objEntity.EmployeeDetails.Find(ID);
                if (objEmp == null)
                {
                    return NotFound();
                }

            }
            catch (Exception)
            {
                throw;
            }

            return Ok(objEmp);
        }

        [HttpPost]
        [Route("InsertEmployeeDetails")]
        public IHttpActionResult PostEmployee(EmployeeDetails data)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                objEntity.EmployeeDetails.Add(data);
                objEntity.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }



            return Ok(data);
        }

        [HttpPut]
        [Route("UpdateEmployeeDetails")]
        public IHttpActionResult PutEmployeeMaster(EmployeeDetails employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                EmployeeDetails objEmp = new EmployeeDetails();
                objEmp = objEntity.EmployeeDetails.Find(employee.EmpId);
                if (objEmp != null)
                {
                    objEmp.EmpName = employee.EmpName;
                    objEmp.Address = employee.Address;
                    objEmp.EmailId = employee.EmailId;
                    objEmp.DateOfBirth = employee.DateOfBirth;
                    objEmp.Gender = employee.Gender;
                    objEmp.PinCode = employee.PinCode;

                }
                int i = this.objEntity.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
            return Ok(employee);
        }
        [HttpDelete]
        [Route("DeleteEmployeeDetails")]
        public IHttpActionResult DeleteEmployeeDelete(int id)
        {
            //int empId = Convert.ToInt32(id);  
            EmployeeDetails Employee = objEntity.EmployeeDetails.Find(id);
            if (Employee == null)
            {
                return NotFound();
            }

            objEntity.EmployeeDetails.Remove(Employee);
            objEntity.SaveChanges();

            return Ok(Employee);
        }
    }
}
