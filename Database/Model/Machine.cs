//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterviewDb.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Machine
    {
        public Machine()
        {
            this.IGameUserMachineSiteAssignments = new HashSet<IGameUserMachineSiteAssignment>();
            this.MachineSessions = new HashSet<MachineSession>();
        }
    
        public int MachineID { get; set; }
        public int MachineTypeID { get; set; }
        public int ParentOrganizationID { get; set; }
        public string MachineName { get; set; }
        public string MachinePassword { get; set; }
        public string SharedSecret { get; set; }
        public string MAC { get; set; }
        public string IP { get; set; }
        public Nullable<System.DateTime> LastPoll { get; set; }
        public string TeamviewerId { get; set; }
        public bool Deleted { get; set; }
        public int CurrencyID { get; set; }
        public Nullable<System.DateTime> TimestampLocked { get; set; }
        public Nullable<int> GameNR { get; set; }
        public Nullable<int> PartnerNR { get; set; }
    
        public virtual Currency Currency { get; set; }
        public virtual Game Game { get; set; }
        public virtual ICollection<IGameUserMachineSiteAssignment> IGameUserMachineSiteAssignments { get; set; }
        public virtual MachineType MachineType { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual Partner Partner { get; set; }
        public virtual ICollection<MachineSession> MachineSessions { get; set; }
    }
}