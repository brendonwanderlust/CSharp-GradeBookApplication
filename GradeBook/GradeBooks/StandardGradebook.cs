using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradebook : BaseGradeBook
    {
        public StandardGradebook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Standard;

        }
    }
}
