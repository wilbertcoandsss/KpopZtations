using KpopZtations.Handler;
using KpopZtations.Model;
using System;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtations.Controller
{
    public class CustomerController
    {
        private CustomerHandler ch = new CustomerHandler();
        private CartHandler carth = new CartHandler();

        public String checkName(String name)
        {
            String errorMsg = null;
            if (name.Length < 5 || name.Length > 50)
            {
                if (name.Length == 0)
                {
                    errorMsg = "Name must be filled!";
                }
                else
                {
                    errorMsg = "Name must be between 5 and 50 characters!";
                }
            }

            return errorMsg;
        }

        public String checkEmail(String email)
        {
            String errorMsg = null;

            if (email.Length == 0)
            {
                errorMsg = "Email must be filled!";
            }
            else if (ch.checkEmailUnique(email) != null)
            {
                errorMsg = "Email must be unique!";
            }
            return errorMsg;
        }

        public String checkGender(RadioButton rbMale, RadioButton rbFemale)
        {
            String errorMsg = null;
            if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                errorMsg = "Gender must be selected!";
            }
            return errorMsg;
        }

        public String checkAddress(String address)
        {
            String errorMsg = null;
            if (address.Length == 0)
            {
                errorMsg = "Address must be filled!";
            }
            else if (!address.EndsWith("Street"))
            {
                errorMsg = "Address must be ends with Street!";
            }
            return errorMsg;
        }

        public String checkPassword(String password)
        {
            String errorMsg = null;

            if (password.Length == 0)
            {
                errorMsg = "Password must be filled!";
            }

            return errorMsg;
        }

        public String isAlphanumeric(String password)
        {
            String errorMsg = null;
            bool isDigit = false;
            bool isLetter = false;
            bool isAlphanumeric = false;
            foreach (char c in password)
            {
                if (Char.IsDigit(c))
                {
                    isDigit = true;
                    break;
                }
            }

            if (isDigit == true)
            {
                foreach (char c in password)
                {
                    if (Char.IsLetter(c))
                    {
                        isLetter = true;
                        break;
                    }
                }
            }

            if (isDigit && isLetter)
            {
                isAlphanumeric = true;
            }

            if (!isAlphanumeric)
            {
                errorMsg = "Password must be alphanumeric!";
            }

            return errorMsg;
        }

        public String doRegister(String name, String email, String address, RadioButton maleBtn, RadioButton femaleBtn, String password)
        {
            String errorMsg = checkName(name);
            String gender = null;

            if (errorMsg == null)
            {
                errorMsg = checkEmail(email);
            }
            if (errorMsg == null)
            {
                errorMsg = checkGender(maleBtn, femaleBtn);
            }
            if (errorMsg == null)
            {
                errorMsg = checkAddress(address);
            }
            if (errorMsg == null)
            {
                errorMsg = checkPassword(password);
            }
            if (errorMsg == null)
            {
                errorMsg = isAlphanumeric(password);
            }
            if (errorMsg == null)
            {
                if (maleBtn.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                errorMsg = null;
                ch.addCustomer(name, email, password, gender, address, "Customer");
            }
            return errorMsg;
        }

        public String doLogin(String email, String password, CheckBox cb)
        {
            String errorMsg = null;

            if (email.Length == 0)
            {
                errorMsg = "Email must be filled!";
            }
            else if (password.Length == 0)
            {
                errorMsg = "Password must be filled!";
            }
            else if (ch.login(email, password) == null)
            {
                errorMsg = "Invalid Credentials!";
            }
            else if (errorMsg == null)
            {
                Customer currentCustomer = new Customer();
                currentCustomer = ch.getCustomerIdByEmail(email);

                if (cb.Checked)
                {
                    HttpCookie userCookie = new HttpCookie("UserData");
                    userCookie.Values["email"] = email;
                    userCookie.Values["password"] = password;
                    userCookie.Expires = DateTime.Now.AddMinutes(1);
                    HttpContext.Current.Response.Cookies.Add(userCookie);
                }

                HttpContext.Current.Session["userId"] = currentCustomer.CustomerID;
                HttpContext.Current.Session["userRole"] = currentCustomer.CustomerRole;
            }
            return errorMsg;
        }

        public String doUpdate(String name, String email, String address, RadioButton maleBtn, RadioButton femaleBtn, String password)
        {
            String errorMsg = checkName(name);
            String gender = null;

            if (errorMsg == null)
            {
                errorMsg = checkEmail(email);
            }
            if (errorMsg == null)
            {
                errorMsg = checkGender(maleBtn, femaleBtn);
            }
            if (errorMsg == null)
            {
                errorMsg = checkAddress(address);
            }
            if (errorMsg == null)
            {
                errorMsg = checkPassword(password);
            }
            if (errorMsg == null)
            {
                errorMsg = isAlphanumeric(password);
            }
            if (errorMsg == null)
            {
                if (maleBtn.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                errorMsg = null;
                System.Diagnostics.Debug.WriteLine(HttpContext.Current.Session["userId"]);
                int id = Convert.ToInt32(HttpContext.Current.Session["userId"].ToString());
                ch.updateCustomer(id, name, email, password, gender, address);
            }
            return errorMsg;
        }
        public bool doRemember(String email, String password)
        {
            if (ch.login(email, password) != null)
            {
                return true;
            }
            return false;
        }

        public void logout()
        {
            HttpContext.Current.Session["userId"] = null;
            HttpContext.Current.Session["userRole"] = null;

            HttpCookie userCookie = HttpContext.Current.Request.Cookies["UserData"];

            if (userCookie != null)
            {
                userCookie.Values["email"] = null;
                userCookie.Values["password"] = null;
                userCookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(userCookie);
            }
        }

        public void deleteAccount(int id)
        {
            carth.clearCart(id);
            ch.deleteAccount(id);
            HttpContext.Current.Session["userId"] = null;
            HttpContext.Current.Session["userRole"] = null;
        }
    }
}