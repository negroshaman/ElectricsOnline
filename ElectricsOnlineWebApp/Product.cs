
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ElectricsOnlineWebApp
{

using System;
    using System.Collections.Generic;
    
public partial class Product
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Product()
    {

        this.Order_Products = new HashSet<Order_Products>();

    }


    public int PID { get; set; }

    public string PName { get; set; }

    public string Brand { get; set; }

    public decimal UnitPrice { get; set; }

    public int UnitsInStock { get; set; }

    public string Category { get; set; }

    public string Description { get; set; }

    public int SID { get; set; }

    public int ROL { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Order_Products> Order_Products { get; set; }

    public virtual Supplier Supplier { get; set; }

}

}
