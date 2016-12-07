//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Potatotech.GestaoRestaurante.Dominio.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produto()
        {
            this.PedidosDoProduto = new HashSet<PedidosDoProduto>();
        }
    
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Nullable<decimal> Imposto { get; set; }
        public int TipoId { get; set; }
    
        public virtual TipoProduto TipoProduto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidosDoProduto> PedidosDoProduto { get; set; }
    }
}
