using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList() => new List<string>();
    public static List<string> GetExistingLanguages()
    {
        List<string> ExistingLanguages = NewList();
        ExistingLanguages.Add("C#");
        ExistingLanguages.Add("Clojure");
        ExistingLanguages.Add("Elm");
        return ExistingLanguages;
    }
    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }
    public static int CountLanguages(List<string> languages)
    {
        int _CountLanguages = 0;
        foreach (string item in languages)
        {
            _CountLanguages ++ ;
        }
        return _CountLanguages;
    }
    public static bool HasLanguage(List<string> languages, string language)
    {
        foreach (string theLanguage in languages)
        {
            if(language == theLanguage){return true;}
        }
        return false;
    }
    public static List<string> ReverseList(List<string> languages)
    {
        List<string> _ReverseList = new List<string>();
        for (int i = languages.Count - 1 ; i > -1; i--)
        {
            _ReverseList.Add(languages[i]);
        }
        return _ReverseList;
    }
    public static bool IsExciting(List<string> languages)=> languages.Count==0?false:(languages[0] == "C#" || (languages[1] == "C#" && languages.Count <= 3 ))? true: false;
    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        List<string> _RemoveLanguage = new List<string>();
        foreach (string theLanguage in languages)
        {
           if (theLanguage != language){_RemoveLanguage.Add(theLanguage);}
        }
        return _RemoveLanguage;
    }
    public static bool IsUnique(List<string> languages)
    {
        bool _IsUnique = true;
        for (int i = 0; i < languages.Count; i++)
        {
            for (int ii = i+1; ii < languages.Count; ii++)
            {
                if (languages[i]==languages[ii])
                {
                    //Console.WriteLine($"{languages[i]} duplicated");
                    _IsUnique=false;
                }
            }
        }
        return _IsUnique;
    }
}
