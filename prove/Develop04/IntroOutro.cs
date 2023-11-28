public class IntroOutro
{

    
    private string _intro;

    private string _discription;

    private int _usernumber;
    public IntroOutro(string intro, string discription, int usernumber)
    {
        _intro = intro;
        _discription = discription;
        
        _usernumber = usernumber;
    }

    public string getIntro()
    {
        return $"{_intro} \n{_discription}";
    }

    public string getOutro()
    {
        string _outro = "\nThank you for participating in this activity. \nEnjoy the rest of your day.";
        return _outro;
    }

    
}