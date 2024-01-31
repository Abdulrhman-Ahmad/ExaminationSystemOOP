using ExaminationSystemOOP.Entities;

namespace ExaminationSystemOOP.Statics.GetSubject
{
    internal class GetSubject
    {
        public static Subject GetSubjectValue()
        {
            return new Subject
                (
                    SubjectDetails.GetSubjectId(),
                    SubjectDetails.GetSubjectName()
                ); 
        }
    }
}
