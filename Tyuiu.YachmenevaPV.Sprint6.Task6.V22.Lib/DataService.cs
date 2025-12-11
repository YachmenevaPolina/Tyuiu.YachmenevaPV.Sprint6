using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.YachmenevaPV.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (resStr != "")
                    {
                        resStr = resStr + " ";
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] != ' ')
                            {
                                resStr = resStr + line[i];
                            }
                            else
                            {
                                break;
                            }
                        }

                    }
                    else
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] != ' ')
                            {
                                resStr = resStr + line[i];
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                }
            }
            resStr = resStr.Trim();
            return resStr;
        }
    }
}
