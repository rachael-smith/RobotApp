using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace RobotApp.WebApp.Helpers
{
    public class DropdownsHelper
    {
        public IEnumerable<SelectListItem> GetSelectListItems(Dictionary<int, string> list)
        {
            // Create an empty list to hold result of the operation
            var selectList = new List<SelectListItem>();

            // For each string in the 'elements' variable, create a new SelectListItem object
            foreach (var item in list)
            {
                selectList.Add(new SelectListItem
                {
                    Value = item.Key.ToString(),
                    Text = item.Value
                });
            }

            return selectList;
        }
    }
}
