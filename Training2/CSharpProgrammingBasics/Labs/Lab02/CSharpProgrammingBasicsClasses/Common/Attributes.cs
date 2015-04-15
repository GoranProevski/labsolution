using System;

[AttributeUsageAttribute(AttributeTargets.Class)]
public class AccountMetadataAttribute : System.Attribute 
{
    public string AccountDescription { get; set; }
    public string AccountLimitations { get; set; }
}

[AttributeUsageAttribute(AttributeTargets.Field | AttributeTargets.Property)]
public class FormatRestrictionAttribute : System.Attribute
{
    public string FormatString { get; set; }
    public int MaxLength { get; set; }
}