using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    partial class FigureMatrixCheckEmpty : SparseMatrix<FigureClass>
    {
        public FigureClass getEmptyElement()
        {
            return null;
        }

        public bool CheckEmptyElement(FigureClass element)
        {
            bool Result = false;
            if (element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}

