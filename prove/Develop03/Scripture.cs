using System;

class Scripture
{
    private string referance = "Psalms 56:11";

    private List<string> scripture = new List<string> {"In", "God", "have", "I", "put", "my", "trust:", "I", "will", "not", "be", "afraid", "what", "man", "can", "do", "unto", "me."};


    public string getScripture()
    {
       string variScripture = string.Join("", scripture);
       return variScripture;
    }

    public string getReference()
    {
        string refer = referance;
        return refer;
    }


}