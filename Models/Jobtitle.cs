//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jobtitle
    {
        public Jobtitle()
        {
            this.EmployeeJobTitles = new HashSet<EmployeeJobTitle>();
        }
    
        public int JobTitleKey { get; set; }
        public string JobTitleName { get; set; }
    
        public virtual ICollection<EmployeeJobTitle> EmployeeJobTitles { get; set; }
    }
}
