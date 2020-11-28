using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace GrasshopperCISample
{
    public class GrasshopperCISampleInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "CISample";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("28bb5cc4-ed19-41d2-bfbf-fdcb598075d0");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
