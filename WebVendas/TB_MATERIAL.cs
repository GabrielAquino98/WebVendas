//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebVendas
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_material()
        {
            this.tb_venda = new HashSet<tb_venda>();
        }
    
        public int id { get; set; }
        public string mat_desc { get; set; }
        public System.DateTime data_ent { get; set; }
        public int id_tipo { get; set; }
        public long mat_valor { get; set; }
        public int id_forn { get; set; }
    
        public virtual tb_fornecedor tb_fornecedor { get; set; }
        public virtual tb_tipo tb_tipo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_venda> tb_venda { get; set; }
    }
}
