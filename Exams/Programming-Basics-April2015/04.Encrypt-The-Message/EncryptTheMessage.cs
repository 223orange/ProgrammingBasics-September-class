using System;


class EncryptTheMessage
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        
        if (inputLine == "start" || inputLine == "START")
        {
            while (inputLine != "end" || inputLine != "END")
            {
                inputLine = Console.ReadLine();

                for (int i = 0; i < inputLine.Length; i++)
                {
                    char convertedChar = inputLine[i];
                    if(convertedChar <= 'M' && convertedChar >= 'A' || convertedChar <= 'm' && convertedChar >= 'a')
                    {
                        convertedChar += (char)13;
                    }
                    if (convertedChar <= 'N' && convertedChar >= 'Z' || convertedChar <= 'n' && convertedChar >= 'z')
                    {
                        convertedChar -= (char)13;
                    }

                    string symbol = Convert.ToString(convertedChar);

                    switch (symbol)
                    {
                        case " ":
                            symbol = "+";
                            break;
                        case ",":
                            symbol = "%";
                            break;
                        case ".":
                            symbol = "&";
                            break;
                        case "?":
                            symbol = "#";
                            break;
                        case "!":
                            symbol = "$";
                            break;
                    }
                
              
                }
                }

            }

        }


    }
}

