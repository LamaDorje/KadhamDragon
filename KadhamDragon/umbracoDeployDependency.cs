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
    
    public partial class umbracoDeployDependency
    {
        public int sourceId { get; set; }
        public int targetId { get; set; }
        public int mode { get; set; }
    
        public virtual umbracoDeployChecksum umbracoDeployChecksum { get; set; }
        public virtual umbracoDeployChecksum umbracoDeployChecksum1 { get; set; }
    }
}
