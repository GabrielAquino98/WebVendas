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
    
    public partial class tb_cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_cliente()
        {
            this.tb_venda = new HashSet<tb_venda>();
        }
    
        public int id { get; set; }
        public long cli_cpf { get; set; }
        public string cli_nome { get; set; }
        public string cli_fone { get; set; }
        public string cli_cidade { get; set; }
        public string cli_endereco { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_venda> tb_venda { get; set; }
    }
}
