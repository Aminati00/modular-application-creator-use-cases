//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Siemens.Automation.ModularApplicationCreator.Tia.Openness;
using System;


namespace UseCaseBasedDoku
{
    
    
    public partial class UseCaseBasedDokuLibrary : LibraryBase
    {
        
        public UseCaseBasedDokuLibrary() : 
                this(true)
        {
        }
        
        public UseCaseBasedDokuLibrary(bool initMasterCopies) : 
                base(initMasterCopies)
        {
        }
        
        public static string TiaVersion
        {
            get
            {
                return "TIA-V18.0";
            }
        }
        
        public override System.Version Version
        {
            get
            {
                return new Version(1, 0, 0);
            }
        }
        
        protected override System.IO.Stream GetResource()
        {
            return System.Reflection.Assembly.GetAssembly(GetType()).GetManifestResourceStream("UseCaseBasedDoku.TiaImports.UseCaseBasedDokuLibrary.zip");
        }
        
        protected override System.Reflection.Assembly GetAssembly()
        {
            return System.Reflection.Assembly.GetAssembly(GetType());
        }
    }
}
