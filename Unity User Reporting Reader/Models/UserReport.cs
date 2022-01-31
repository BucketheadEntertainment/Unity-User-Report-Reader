using Unity_User_Reporting_Reader.Models.Report;

namespace Unity_User_Reporting_Reader.Models
{
    public class UserReport
    {
        public string projectID;
        public string reportID;
        public Attachment[] attachments;
        public ClientMetric[] clientMetric;
        public DeviceMetadata[] deviceMetadata;
        public Event[] events;
        public Field[] fields;
        public Measure[] measures;
        public Screenshot[] screenshots;
        public AggregateMetric[] aggregateMetrics;
        public int appearanceHint;
        public long contentLength;
        public Dimension[] dimensions;
        public DateTime expiresOn;
        public string geoCountry;
        public string identifier;
        public string ipAddress;
        public bool isHiddenWithoutDimension;
        public bool isSilent;
        public bool isTemporary;
        public bool isTracked;
        public int licenseLevel;
        public string projectIdentifier;
        public DateTime receivedOn;
        public string summary;
        public string tags;
        public Thumbnail thumbnail;
    }
}
