using System.Numerics;

namespace TCPClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            //client.SendData("localhost", 8888, "Hello, World!");



            //string data = "\r\n                                 *****************\r\n                                 * O   R   C   A *\r\n                                 *****************\r\n\r\n                                            #,                                       \r\n                                            ###                                      \r\n                                            ####                                     \r\n                                            #####                                    \r\n                                            ######                                   \r\n                                           ########,                                 \r\n                                     ,,################,,,,,                         \r\n                               ,,#################################,,                 \r\n                          ,,##########################################,,             \r\n                       ,#########################################, ''#####,          \r\n                    ,#############################################,,   '####,        \r\n                  ,##################################################,,,,####,       \r\n                ,###########''''           ''''###############################       \r\n              ,#####''   ,,,,##########,,,,          '''####'''          '####       \r\n            ,##' ,,,,###########################,,,                        '##       \r\n           ' ,,###''''                  '''############,,,                           \r\n         ,,##''                                '''############,,,,        ,,,,,,###''\r\n      ,#''                                            '''#######################'''  \r\n     '                                                          ''''####''''         \r\n             ,#######,   #######,   ,#######,      ##                                \r\n            ,#'     '#,  ##    ##  ,#'     '#,    #''#        ######   ,####,        \r\n            ##       ##  ##   ,#'  ##            #'  '#       #        #'  '#        \r\n            ##       ##  #######   ##           ,######,      #####,   #    #        \r\n            '#,     ,#'  ##    ##  '#,     ,#' ,#      #,         ##   #,  ,#        \r\n             '#######'   ##     ##  '#######'  #'      '#     #####' # '####'        \r\n\r\n\r\n\r\n                  #######################################################\r\n                  #                        -***-                        #\r\n                  #          Department of theory and spectroscopy      #\r\n                  #    Directorship and core code : Frank Neese         #\r\n                  #        Max Planck Institute fuer Kohlenforschung    #\r\n                  #                Kaiser Wilhelm Platz 1               #\r\n                  #                 D-45470 Muelheim/Ruhr               #\r\n                  #                      Germany                        #\r\n                  #                                                     #\r\n                  #                  All rights reserved                #\r\n                  #                        -***-                        #\r\n                  #######################################################\r\n\r\n\r\n                         Program Version 5.0.4 -  RELEASE  -";

            //client.SendData("localhost", 8888, data);

            string[] lines = File.ReadAllLines("C:\\Users\\MrDNA\\Downloads\\porp2.out");

            string totalFile = "";

            foreach (string line in lines)
            {
                totalFile += line;
            }

            Console.WriteLine(File.ReadAllLines("C:\\Users\\MrDNA\\Downloads\\porp2.out"));

            Vector2 data = new Vector2(1, 2); 

            MessageContent message = new MessageContent(totalFile, "MrDNA", "Red");

            byte[] bytes = File.ReadAllBytes("C:\\Users\\MrDNA\\Downloads\\porp2.out");


            client.SendData("localhost", 8888, bytes);
        }
    }
}
