using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChildEducationSoftwareEngine
{
    public class CESController
    {
        public ExerciseManager employeeController;
        public LessonManager customerController;
        public List<ReportInfo> reports;
        public List<PaymentInfo> payments;
    }

    public class MemberManager
    {
        public List<MemberInfo> members;
    }

    public class ExerciseManager
    {
        public List<ExerciseInfo> excercises;
        public ScoreInfo finalScore;
    }

    public class LessonManager
    {
        public List<LessonInfo> lessons;
    }

    public class DrawingEditController
    {
        public List<DrawingEditInfo> edits;
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
        public List<LessonInfo> lessonBought;
        public List<ExerciseInfo> exceciseAttempted;
        public List<DrawingInfo> drawingsMade;
        public List<PaymentInfo> payements;
    }

    public class PaymentInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string memberId { get; set; }
        public double amount { get; set; }
        public DateTime dop { get; set; }
        public string gateway;
    }
    public class LessonInfo
    {
        string name;
        int ageGroup;
        ImageInfo imageFile;
        VideoInfo videoFile;
        AudioInfo audioFile;
        TextInfo textFile;
        double size;
        DateTime datePurchased;
        List<DrawingInfo> drawings;
    }
    public class ExerciseInfo
    {
        string name;
        LessonInfo relatedLesson;
        ImageInfo imageFile;
        VideoInfo videoFile;
        AudioInfo audioFile;
        TextInfo textFile;
        double size;
        DateTime dateTaken;
        ScoreInfo score;

    }
    public class ScoreInfo
    {
        int maxNumber;
        int scoredMarks;
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
    public class TextInfo
    {
        string name;
        string txtFile;
        double size;
        DateTime dateTaken;
    }
    public class AudioInfo
    {
        string name;
        string audioFile;
        double size;
        DateTime dateTaken;
    }
    public class VideoInfo
    {
        string name;
        string videoFile;
        double size;
        DateTime dateTaken;
    }
    public class ImageInfo
    {
        string name;
        string ImageFile;
        double size;
        DateTime dateTaken;
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
