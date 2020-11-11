using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lawyer.Extentions
{
    public static class Extentions
    {
        public static IEnumerable<string> GetTermsTitles()
        {
            IBL bl = new BL.BL();
            IEnumerable<string> result = new List<string>();
            result = bl.GetTermsTitles();
            return result;
        }
        static public MvcHtmlString DropDownListForTerms(this HtmlHelper htmlHelper, string name, int? id = null)
        {
            IBL bl = new BL.BL();
            string options = "";
            string isSelected = "";
            if (id == null || id == -1)
            {
                options += $"<option selected disable value='-1'>בחר קבוצה</option>";
            }
            foreach (var term in bl.GetTerms())
            {
                isSelected = term.ID == id ? "selected" : "";
                options += $"<option value ='{ term.ID}' {isSelected}> { term.Title } </option>";
            }
            return new MvcHtmlString($"<select class='form-control' id='{name}' name='{name}' required>{options}</select>");
        }
    }
}