using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradebook : BaseGradeBook
    {
        public StandardGradebook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Standard;

        }
    }
}
