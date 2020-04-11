﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NpgsqlTypes;
using System.Threading.Tasks;

namespace SalaryWorker.DBWorker.Entities
{
    class Payout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal IssuedBy { get; set; }
        public Employee Employee { get; set; }

        public Payout()
        {
            Id = 0;
            Date = DateTime.MinValue;
            IssuedBy = 0;
            Employee = new Employee();
        }

        public Payout(int id, DateTime date, decimal issuedBy, Employee employee)
        {
            Id = id;
            Date = date;
            IssuedBy = issuedBy;
            Employee = employee;
        }

        public override string ToString()
        {
            return "Employee: {" +
                "id: " + Id + ", " +
                "passport: " + Date + ", " +
                "birthday: " + IssuedBy +
                "} ";
        }
    }
}
