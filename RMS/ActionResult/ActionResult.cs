using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.ActionResult
{
    /// <summary>
    /// Operation result type for RMS
    /// </summary>
    /// <typeparam name="T">Data of the opertion | String {e.message}</typeparam>
    public class ActionResult<T>
    {
        /// <summary>
        /// Status of the operation
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Data of the operation
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// operation result with two parameter
        /// </summary>
        /// <param name="data">data of operation</param>
        /// <param name="success">status of the operation</param>
        public ActionResult(T data, bool success)
        {
            Success = success;
            Data = data;
        }
    }
}
