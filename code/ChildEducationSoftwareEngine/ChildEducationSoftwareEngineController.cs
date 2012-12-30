using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChildEducationSoftwareEngine
{
    public class CESEngine
    {
    }

    public class OpenPDNConnector
    {
        public DrawingEditInfo editPhoto(PhotoInfo photo, DrawingEditType type)
        {
            throw new NotImplementedException();
        }
    }
    public class PSMSController
    {
        public EmployeeManager employeeController;
        public CustomerManager customerController;
        public List<ReportInfo> reports;
        public List<PaymentInfo> payments;
    }

    public class EmployeeManager
    {
        public List<EmployeeInfo> employees;
    }

    public class CustomerManager
    {
        public List<CustomerInfo> customers;
    }

    public class PhotoEditController
    {
        public List<DrawingEditInfo> edits;
        public OpenPDNConnector editAPIs;
    }

    public enum AccountType
    {
        Free,
        Basic,
        Professional
    }

    public class MemberInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public AccountType accType { get; set; }
        public List<PhotoInfo> photos;
        public List<PaymentInfo> payements;
    }

    public class PaymentInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string customerId { get; set; }
        public double amount { get; set; }
        public DateTime dop { get; set; }
    }
    public class LessonInfo
    {
        string name;
        string softwareUsedForCapture;
        string ImageFile;
        double size;
        DateTime dateTaken;
        List<DrawingEditInfo> edits;
    }
    public class ExerciseInfo
    {
        string name;
        string softwareUsedForCapture;
        string ImageFile;
        double size;
        DateTime dateTaken;
        List<DrawingEditInfo> edits;
    }
    public class DrawingInfo
    {
        string name;
        string softwareUsedForCapture;
        string ImageFile;
        double size;
        DateTime dateTaken;
        List<DrawingEditInfo> edits;
    }
    public class AudioInfo
    {
        string name;
        string softwareUsedForCapture;
        string ImageFile;
        double size;
        DateTime dateTaken;
        List<DrawingEditInfo> edits;
    }
    public class VideoInfo
    {
        string name;
        string softwareUsedForCapture;
        string ImageFile;
        double size;
        DateTime dateTaken;
        List<DrawingEditInfo> edits;
    }
    public class ImageInfo
    {
        string name;
        string softwareUsedForCapture;
        string ImageFile;
        double size;
        DateTime dateTaken;
        List<DrawingEditInfo> edits;
    }

    public enum DrawingEditType
    {
        Rotate,
        Crop,
        Stretch,
        Brighten,
        Sepia
    }

    public class DrawingEditInfo
    {
        string name;
        string softwareUsedtoEdit;
        MemberInfo memberEdited;
        string OriginalImageFile;
        string EditedImageFile;
        double size;
        DateTime dateEdited;
        DrawingEditType type;
    }

    public enum ReportType
    {
        Single,
        Daily,
        Weekly,
        Monthly,
        Quarterly,
        Yearly
    }

    public class ReportInfo
    {
        public string id { get; set; }
        public DateTime date { get; set; }
        public ReportType type { get; set; }
        public string description { get; set; }
    }

}
