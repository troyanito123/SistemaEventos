//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ngMap
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIO_EVENTO
    {
        public int ID_USUARIO { get; set; }
        public int ID_EVENTO { get; set; }
        public bool CREADOR { get; set; }
    
        public virtual EVENTO EVENTO { get; set; }
        public virtual USUARIO_REGISTRADO USUARIO_REGISTRADO { get; set; }
    }
}