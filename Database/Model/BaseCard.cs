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
    
    public partial class BaseCard
    {
        public BaseCard()
        {
            this.Sessions = new HashSet<Session>();
            this.SessionLogs = new HashSet<SessionLog>();
        }
    
        public int BaseCardID { get; set; }
        public long CardBarCode { get; set; }
        public string CardPin { get; set; }
        public int CardTypeID { get; set; }
        public Nullable<int> MachineID { get; set; }
        public Nullable<System.DateTime> TimeStampLocked { get; set; }
        public Nullable<System.DateTime> RoleRightsChangedTimestamp { get; set; }
        public bool Deleted { get; set; }
        public Nullable<System.Guid> WebSessionToken { get; set; }
    
        public virtual BaseCardType BaseCardType { get; set; }
        public virtual Player Player { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<SessionLog> SessionLogs { get; set; }
        public virtual IGameUserMachineSiteAssignment IGameUserMachineSiteAssignment { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
