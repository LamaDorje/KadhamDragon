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
    
    public partial class cmsDocumentType
    {
        public int contentTypeNodeId { get; set; }
        public int templateNodeId { get; set; }
        public bool IsDefault { get; set; }
    
        public virtual umbracoNode umbracoNode { get; set; }
    }
}