public class MathAssignment : Assignment
{

    
    private string _textbookSection;
    private string _homeworkProblems;

    public MathAssignment(string studentName, string topic, string textbookSection, string homeworkProblems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _homeworkProblems = homeworkProblems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection}: Problems {_homeworkProblems}";
    }


}