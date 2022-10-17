﻿using _1CommonInfrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Interfaces
{
    public interface IEmployeeDal
    {
        // Getters
        EmployeeModel? GetById(int Id);
        List<EmployeeModel> GetAll();

        // Actions
        int CreateEmployee(EmployeeModel employee);
        void UpdateEmployee(EmployeeModel employee); 
        void DeleteEmployee(int Id); 
    }
}
