using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBG_Mouse_Helper
{
    public static class Load_Preset
    {
        private const string saveFileName = "PUBGMouse.ini";

        public static string Auto_Recoil = "XButton1";
        public static string Auto_Tap = "XButton1";
        public static string Anti_Recoil = "F7";
        public static string Active = "F6";

        public static List<int> GetPresetValuesFromName()
        {
            List<int> retval = new List<int>();

            if (File.Exists(saveFileName))
            {
                try
                {
                    var data = File.ReadAllText(saveFileName);
                    string[] datas = data.Split(new string[] { "\r\n\r\n" } , StringSplitOptions.None);

                    foreach (var line in datas)
                    {
                        if (line.Contains("CONTROL"))
                        {

                            //string[] item = line.Split(new string[] {"'"} , StringSplitOptions.None);
                           // string item = Enum.Parse(typeof(line), "")

                        }
                        if(line.Contains("PRESET"))
                        {
                            
                        }
                        if(line.Contains("SCOPE"))
                        {
                            if (line.Contains("REDOT"))
                            { }
                            else if (line.Contains("X2"))
                            { }
                            else if (line.Contains("X3"))
                            { }
                            else if (line.Contains("X4"))
                            { }
                            else if (line.Contains("X6"))
                            { }
                            else if (line.Contains("X8"))
                            { }

                        }
                    }

                }
                //    foreach (var line in File.ReadLines(datass[0]))
                //    {
                //        string[] item = { };
                //        if (line.Length == 0)
                //        {
                //           // item = data.Substring(0, line.Length);
                //        }
                //        //if (events.Contains("CONTROL"))
                //        //{
                //        //    string[] datas = line.Split(new char[] { '\n', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                //        //    string[] data = line.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                //        //    //if()
                //        //}




                //        }
                //            //string[] tokens = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                //            //if (tokens.Length == 3)
                //            //{
                //            //    retval.Add(Int32.Parse(tokens[0]));
                //            //    retval.Add(Int32.Parse(tokens[1]));
                //            //    retval.Add(Int32.Parse(tokens[2]));

                //            //}
                //            //else
                //            //{
                //            //    throw new Exception("Wrong number of preset parameters!");
                //            //}
                //            //break;
                //    //}
                //}
                catch (Exception ex)
                {
                    // Debug.Print(ex.Message);
                }

            }
            return retval;

        }

    }
}
