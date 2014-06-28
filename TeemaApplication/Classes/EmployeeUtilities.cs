using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeemaApplication.Datasets;
using System.Windows.Forms;

namespace TeemaApplication.Classes
{
    static class EmployeeUtilities
    {
        public static void fillDesignationComboBox(TeemaDBDataContext db, ComboBox comboBox)
        {
            comboBox.DisplayMember = "Designation1";
            comboBox.ValueMember = "DesignationID";
            comboBox.DataSource = db.Designations;
        }

        public static Branch SaveNewBranchIfNotExsists(TeemaDBDataContext db, ComboBox comboBox)
        {
            Branch branch = db.Branches.Where(br => br.BranchName.ToLower().Equals(comboBox.Text.ToLower())).SingleOrDefault();
            if (branch == null)
            {
                branch = new Branch
                {
                    BranchName = comboBox.Text,
                    CreatedBy = LoginDetails.LoggedUsedID,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = LoginDetails.LoggedUsedID,
                    ModifiedDate = DateTime.Now
                };

                db.Branches.InsertOnSubmit(branch);
                db.SubmitChanges();
            }
            return branch;
        }

        public static Department SaveNewDepartmentIfNotExsists(TeemaDBDataContext db, Branch branch, ComboBox comboBox)
        {
            Department department = branch.Departments.Where(de => de.DepartmentName.ToLower().Equals(comboBox.Text.ToLower())).SingleOrDefault();
            if (department == null)
            {
                department = new Department
                {
                    DepartmentName = comboBox.Text,
                    Branch = branch,
                    CreatedBy = LoginDetails.LoggedUsedID,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = LoginDetails.LoggedUsedID,
                    ModifiedDate = DateTime.Now
                };

                db.Departments.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            return department;
        }

        public static SubDepartment SaveNewSubDepartmentIfNotExisists(TeemaDBDataContext db, Department department, ComboBox comboBox)
        {
            SubDepartment subDepartment = department.SubDepartments.Where(sde => sde.SubDepartmentName.ToLower().Equals(comboBox.Text.ToLower())).SingleOrDefault();
            if (subDepartment == null)
            {
                subDepartment = new SubDepartment
                {
                    SubDepartmentName = comboBox.Text,
                    Department = department,
                    CreatedBy = LoginDetails.LoggedUsedID,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = LoginDetails.LoggedUsedID,
                    ModifiedDate = DateTime.Now
                };

                db.SubDepartments.InsertOnSubmit(subDepartment);
                db.SubmitChanges();
            }
            return subDepartment;
        }

        public static Designation SaveNewDesignationIfNotExists(TeemaDBDataContext db, ComboBox comboBox)
        {
            Designation designation = db.Designations.Where(de => de.Designation1.ToLower().Equals(comboBox.Text.ToLower())).SingleOrDefault();
            if (designation == null)
            {
                designation = new Designation
                {
                    Designation1 = comboBox.Text,
                    CreatedBy = LoginDetails.LoggedUsedID,
                    CreatedDate = DateTime.Now,
                    ModifiedBy = LoginDetails.LoggedUsedID,
                    ModifiedDate = DateTime.Now
                };

                db.Designations.InsertOnSubmit(designation);
                db.SubmitChanges();
            }
            return designation;
        }

        public static bool isSecurityEmployee(ComboBox comboBox)
        {
            string designation = comboBox.Text;
            if (designation.ToLower().Contains("security"))
            {
                return true;
            }
            return false;
        }

        public static VariableIncentiveAllowance createNewVariableIncentive(string incentiveType, string incentiveValue, Employee employee)
        {
            VariableIncentiveAllowance varIncentive = new VariableIncentiveAllowance
            {
                Employee = employee,
                Type = incentiveType,
                Value = Convert.ToDouble(incentiveValue),
                CreatedBy = LoginDetails.LoggedUsedID,
                CreatedDate = DateTime.Now,
                ModifiedBy = LoginDetails.LoggedUsedID,
                ModifiedDate = DateTime.Now
            };

            return varIncentive;
        }
    }
}
