//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KadhamDragon
{
    using System;
    using System.Collections.Generic;
    
    public partial class cmsTemplate
    {
        public int pk { get; set; }
        public int nodeId { get; set; }
        public string alias { get; set; }
        public string design { get; set; }
    
        public virtual umbracoNode umbracoNode { get; set; }
    }
}
