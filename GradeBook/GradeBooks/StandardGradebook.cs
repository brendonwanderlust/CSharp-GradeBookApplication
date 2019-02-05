using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradebook : BaseGradeBook
    {
        public StandardGradebook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Standard;

        }
    }
}
