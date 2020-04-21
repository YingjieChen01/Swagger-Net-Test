﻿using Swagger_Test.Models;
using System.Web.Http;

namespace Swagger_Test.Controllers
{
    /// <summary>
    /// Testing enums ...
    /// </summary>
    public class TestEnumController : ApiController
    {
        public enum CustomEnum
        {
            Text = 1,
            Numeric = 2,
            Date = 4,
            Numeric_Function = 8,
            Dropdown_List = 16,
            Checkbox = 32
        }

        public enum OrderType
        {
            ASC = 0,
            DESC = 1,
            None = 2,
        }

        /// <summary>
        /// Simple GET echoing the given param
        /// </summary>
        /// <param name="value">CustomEnum</param>
        /// <returns>CustomEnum</returns>
        public CustomEnum Get(CustomEnum value)
        {
            return value;
        }

        /// <summary>
        /// Test POST lorem ipsum
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <remarks>
        /// <ul>
        /// <li><b>Item 1</b> - description 1</li>
        /// <li><b>Item 2</b> - description 2</li>
        /// </ul>
        /// </remarks>
        public CustomEnum Post(CustomEnum value)
        {
            return value;
        }

        /// <summary>
        ///  Testing a [FromUri]
        /// </summary>
        /// <param name="viewModelTest">ViewModelTest</param>
        /// <returns>ViewModelTest</returns>
        public ViewModelTest Put([FromUri] ViewModelTest viewModelTest)
        {
            return viewModelTest;
        }

        public OrderType Delete(OrderType value)
        {
            return value;
        }
    }
}
