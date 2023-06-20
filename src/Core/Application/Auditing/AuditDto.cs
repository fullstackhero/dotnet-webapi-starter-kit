namespace FL_CRMS_ERP_WEBAPI.Application.Auditing;

public class AuditDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string? Type { get; set; }
    public string? TableName { get; set; }
    public DateTime DateTime { get; set; }
    public string? OldValues { get; set; }
    public string? NewValues { get; set; }
    public string? AffectedColumns { get; set; }
    public string? PrimaryKey { get; set; }

    //TimeLine for all modules started from here
    public Guid LeadId { get; set; }
    public string? Subject { get; set; }
    public string[]? MeetingLeadId { get; set; }
    public string? RelatedTo { get; set; }
    //
}