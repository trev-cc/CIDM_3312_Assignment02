using Microsoft.AspNetCore.Mvc;
using System;

namespace MathWizard.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(string left, string right){

            int leftop = Convert.ToInt32(left);
            int rightop = Convert.ToInt32(right);
            int sum = leftop + rightop;


                ViewData["Message"] = $"{left} plus {right} equals {sum}";
            

            return View();
        }

public IActionResult Subtract(string left, string right){

            int leftop = Convert.ToInt32(left);
            int rightop = Convert.ToInt32(right);
            int sub = leftop - rightop;


                ViewData["Message"] = $"{left} minus {right} equals {sub}";

            return View();
        }
        public IActionResult Multiply(string left, string right){

            int leftop = Convert.ToInt32(left);
            int rightop = Convert.ToInt32(right);
            int multi = leftop * rightop;


                ViewData["Message"] = $"{left} Multiplied by {right} equals {multi}";

            return View();
        }
                public IActionResult Divide(string left, string right){

            int leftop = Convert.ToInt32(left);
            int rightop = Convert.ToInt32(right);
            int div = leftop / rightop;

            if(rightop == 0)
            {
                //string path = @"C:\Temp\files";
                ViewData["Message"] = @"You can't divide by zero";
            }else{
                ViewData["Message"] = $"{left} divded by {right} equals {div}";
            }

            return View();
        }
                public IActionResult Modulus(string left, string right){

            int leftop = Convert.ToInt32(left);
            int rightop = Convert.ToInt32(right);
            int mod = leftop % rightop;

            if(rightop == 0)
            {
                ViewData["Message"] = @"You can't divide by zero";
            }else{
                ViewData["Message"] = $"{left} mod {right} equals {mod}";
            }

            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    
    }
}