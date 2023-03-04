using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Part4
{
    /// <summary>
    /// Implements the file writing interface
    /// </summary>
    interface INoteWriter
    {
        /// <summary>
        /// Write the list of notes in file
        /// </summary>
        /// <param name="PhoneNote"> The list of notes </param>
        /// <param name="fileName">Full file name</param>
        /// <returns>True if writing is successed else false</returns>
        bool Write(List<Note> PhoneNote, string fileName);
    }
}
