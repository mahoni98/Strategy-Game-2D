using System.Collections.Generic;

namespace MyHelper
{
    public class Helper
    {
        /// <summary>
        /// Checks whether the grid to be added to the grid element list has already been added and adds it if not
        /// </summary>
        /// <returns></returns>
        public void GridElemetListControl(List<GridElement> List, GridElement _GridElement)
        {
            if (!List.Contains(_GridElement))
            {
                List.Add(_GridElement);
            }
            else
            {
                List.Remove(_GridElement);
            }
        }
    }
}
