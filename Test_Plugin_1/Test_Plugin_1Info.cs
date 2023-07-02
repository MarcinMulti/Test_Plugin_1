using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace Test_Plugin_1
{
    public class Test_Plugin_1Info : GH_AssemblyInfo
    {
        public override string Name => "Test_Plugin_1";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("818E6733-5C55-4CA8-8906-25348FEF7F2B");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}