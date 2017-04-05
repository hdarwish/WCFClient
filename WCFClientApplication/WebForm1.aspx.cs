using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFClientApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGetEmp_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeService.IEmployeeService client =
                   new EmployeeService.EmployeeServiceClient();
                EmployeeService.EmplpoyeeRequest empRequest = new EmployeeService.EmplpoyeeRequest("TFYTW2HKD", Convert.ToInt32(TextBox1.Text));
                EmployeeService.EmployeeInfo employeeInfo = client.GetEmployee(empRequest);
                if (employeeInfo.Type == EmployeeService.EmployeeType.FullTimeEmployee)
                {
                    txtannual.Text = employeeInfo.AnnualSalary.ToString();
                    trAnnualsalary.Visible = true;
                    trhrpay.Visible = false;
                    trhourworked.Visible = false;
                }
                else
                {
                    txthrpay.Text = employeeInfo.HourlyPay.ToString();
                    txthourworked.Text = employeeInfo.HoursWorked.ToString();
                    trAnnualsalary.Visible = false;
                    trhrpay.Visible = true;
                    trhourworked.Visible = true;
                }
                ddlEmployeeType.SelectedValue = ((int)employeeInfo.Type).ToString();
                TextBox2.Text = employeeInfo.Name;
                TextBox3.Text = employeeInfo.Gender;
                TextBox4.Text = employeeInfo.DOB.ToShortDateString();
                Label5.Text = "Employee Retrieved";
            }
            catch (FaultException faultException)
            {
                Label5.Text = faultException.Message;
            }
        }

        protected void btnSaveEmp_Click(object sender, EventArgs e)
        {
            EmployeeService.IEmployeeService client =
              new EmployeeService.EmployeeServiceClient();
            EmployeeService.EmployeeInfo employeeInfo = new EmployeeService.EmployeeInfo();
            employeeInfo.Id = 1;
            employeeInfo.Name = TextBox2.Text;
            employeeInfo.Gender = TextBox3.Text;
            employeeInfo.DOB = Convert.ToDateTime(TextBox4.Text);
            if (ddlEmployeeType.SelectedValue != "-1")
            {
                if ((EmployeeService.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue)
                == EmployeeService.EmployeeType.FullTimeEmployee)
                {

                    employeeInfo.Type = EmployeeService.EmployeeType.FullTimeEmployee;
                    employeeInfo.AnnualSalary = Convert.ToInt32(txtannual.Text);
                    client.SaveEmployee(employeeInfo);
                    Label5.Text = "Full Time Employee Saved";

                }
                else if ((EmployeeService.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue)
                    == EmployeeService.EmployeeType.PartTimeEmployee)
                {
                    employeeInfo.Type = EmployeeService.EmployeeType.PartTimeEmployee;
                    employeeInfo.HourlyPay = Convert.ToInt32(txthrpay.Text);
                    employeeInfo.HoursWorked = Convert.ToInt32(txthourworked.Text);
                    client.SaveEmployee(employeeInfo);
                    Label5.Text = "Part Time Employee Saved";
                }

            }

            else
            {
                Label5.Text = "Select Employee Type";
            }






        }

        protected void ddlEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlEmployeeType.SelectedValue == "-1")
            {
                trAnnualsalary.Visible = false;
                trhrpay.Visible = false;
                trhourworked.Visible = false;
            }
            else if (ddlEmployeeType.SelectedValue == "1")
            {
                trAnnualsalary.Visible = true;
                trhrpay.Visible = false;
                trhourworked.Visible = false;
            }
            else
            {
                trAnnualsalary.Visible = false;
                trhrpay.Visible = true;
                trhourworked.Visible = true;
            }
        }
    }
}