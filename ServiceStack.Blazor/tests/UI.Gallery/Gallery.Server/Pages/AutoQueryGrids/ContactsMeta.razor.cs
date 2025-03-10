﻿namespace MyApp.Client.Pages.AutoQueryGrids
{
    public partial class ContactsMeta
    {
        public string SourceCode = @"[Icon(Svg = Icons.Contact)]
public class Contact : AuditBase
{
    [AutoIncrement]
    public int Id { get; set; }

    [Computed]
    public string DisplayName => FirstName + "" "" + LastName;
    [Format(FormatMethods.IconRounded)]
    public string ProfileUrl { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [Format(FormatMethods.Currency)]
    public int? SalaryExpectation { get; set; }

    public string JobType { get; set; }
    public int AvailabilityWeeks { get; set; }
    public EmploymentType PreferredWorkType { get; set; }
    public string PreferredLocation { get; set; }

    [Format(FormatMethods.LinkEmail, Options = 
        @""{target:'_self',subject:'New Job Opportunity',
           body:'We have an exciting new opportunity...', cls:'text-green-600'}"")]
    public string Email { get; set; }
    [Format(FormatMethods.LinkPhone)]
    public string Phone { get; set; }

    public string About { get; set; }

    [Reference]
    public List<JobApplication> Applications { get; set; }
}

// Customize Edit Forms with [Input] and [FieldCss] attributes 
public class UpdateContact : IPatchDb<Contact>, IReturn<Contact>
{
    public int Id { get; set; }

    [ValidateNotEmpty]
    public string? FirstName { get; set; }

    [ValidateNotEmpty]
    public string? LastName { get; set; }

    [Input(Type = ""file""), UploadTo(""profiles"")]
    public string? ProfileUrl { get; set; }
    
    public int? SalaryExpectation { get; set; }

    [ValidateNotEmpty]
    public string? JobType { get; set; }

    public int? AvailabilityWeeks { get; set; }
    public EmploymentType? PreferredWorkType { get; set; }
    public string? PreferredLocation { get; set; }

    [ValidateNotEmpty]
    public string? Email { get; set; }
    public string? Phone { get; set; }
 
    [Input(Type=""textarea"")]
    [FieldCss(Field=""col-span-12 text-center"", Input=""h-48"", Label=""text-xl text-indigo-700"")]
    public string? About { get; set; }
}
";

    }
}
