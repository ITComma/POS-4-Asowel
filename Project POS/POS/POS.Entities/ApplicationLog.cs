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
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace POS.Entities
{

    // ApplicationLog
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class ApplicationLog
    {
        public int Id { get; set; } // id (Primary key)
        public System.DateTime DateAdded { get; set; } // date_added
        public string Comment { get; set; } // comment (length: 1073741823)
        public string ApplicationName { get; set; } // application_name (length: 100)
        public byte[] LastUpdatedOn { get; private set; } // last_updated_on (length: 8)
        public string ExtraData { get; set; } // extra_data

        public ApplicationLog()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
