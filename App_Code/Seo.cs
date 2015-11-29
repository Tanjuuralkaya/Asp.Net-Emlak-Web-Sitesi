using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Seo
/// </summary>
public class Seo
{
	
    public static string injection(string Metin)
    {
        string ifade = Metin;
        ifade = ifade.Replace(" ", "");
        ifade = ifade.Replace("'", "");
        ifade = ifade.Replace("%", "");
        ifade = ifade.Replace("<", "");
        ifade = ifade.Replace(">", "");
        ifade = ifade.Replace("[", "");
        ifade = ifade.Replace("]", "");
        ifade = ifade.Replace("(", "");
        ifade = ifade.Replace(")", "");
        return ifade;    
    }
}