// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6

using System;

#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace POS.Entities
{

    // OrderNote
    [Serializable]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class OrderNote
    {
        public string OrdernoteId { get; set; } // ordernote_id (Primary key) (length: 10)
        public string CusId { get; set; } // cus_id (length: 10)
        public string EmpId { get; set; } // emp_id (length: 10)
        public int Ordertable { get; set; } // ordertable
        public System.DateTime Ordertime { get; set; } // ordertime
        public decimal TotalPrice { get; set; } // total_price
        public decimal CustomerPay { get; set; } // customer_pay
        public decimal PayBack { get; set; } // pay_back

        // Reverse navigations

        /// <summary>
        /// Child OrderNoteDetails where [OrderNoteDetails].[ordernote_id] point to this entity (FK_dbo.OrderNoteDetails_dbo.OrderNote_ordernote_id)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<OrderNoteDetail> OrderNoteDetails { get; set; } // OrderNoteDetails.FK_dbo.OrderNoteDetails_dbo.OrderNote_ordernote_id

        // Foreign keys

        /// <summary>
        /// Parent Customer pointed by [OrderNote].([CusId]) (FK_dbo.OrderNote_dbo.Customer_cus_id)
        /// </summary>
        public virtual Customer Customer { get; set; } // FK_dbo.OrderNote_dbo.Customer_cus_id

        /// <summary>
        /// Parent Employee pointed by [OrderNote].([EmpId]) (FK_dbo.OrderNote_dbo.Employee_emp_id)
        /// </summary>
        public virtual Employee Employee { get; set; } // FK_dbo.OrderNote_dbo.Employee_emp_id

        public OrderNote()
        {
            OrderNoteDetails = new System.Collections.Generic.List<OrderNoteDetail>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
