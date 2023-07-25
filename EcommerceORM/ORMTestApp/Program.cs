using System;
using System.Collections.Generic;

using BOL;
using DAL;
bool status = true;

IDBManager dbm = new DBManager();
while(status)
{
    Console.WriteLine("1. Display All Records\n 2. Insert\n 3. delete record\n4. Update Record\n5. Exit");

    Console.WriteLine("Enter Choice:-");

    switch (int.Parse(Console.ReadLine()))
    {
        case 1:
            
                List<Department> allDepartments = dbm.getAll();
                foreach (var dept in allDepartments)
                {
                    Console.WriteLine(" Id: {0}, Name: {1}, Location: {2}",
                                        dept.Id, dept.Name, dept.Location);
                }
            
            break;

        case 2:
            Department newDept = new Department()
            {
              Id = 22,
                 Name = "manager",
                Location = "Pune"
            };
            dbm.Insert(newDept);
            break;


        case 3:
            dbm.Delete(22);
            break;

        case 4:
            var updateDept = new Department()
            {
                Id = 22,
                 Name = "Acoountinggg",
                Location = "Banglore"
            };
            dbm.Update(updateDept);
            break;

            case 5:
            Console.WriteLine("Thanks for Visiting:");
            status= false;
            break;
    }


} 