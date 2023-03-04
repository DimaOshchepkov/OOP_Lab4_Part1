using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Part4
{
    /// <summary>
    /// Implements the file reading interface
    /// </summary>
    interface INoteReader
    {
        /// <summary>
        /// Read notes from file
        /// </summary>
        /// <param name="fileName">Full file name</param>
        /// <param name="PhoneNote">List of notes</param>
        /// <returns>True if reading is success else false</returns>
        List<Note> Read(string fileName);
    }
}
