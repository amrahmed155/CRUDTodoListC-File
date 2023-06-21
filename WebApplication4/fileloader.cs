using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication4
{
    public class fileloader
    {
        protected  string filename;
        public fileloader() { }
        public fileloader(string filename) { filename = this.filename; }

        public Boolean ReadFileHandled(string filename, String u1, String p1) //authenticate
        {
            try
            {
                int lineNumber = 0;
                TextReader reader = new StreamReader(filename);
                //string line = reader.ReadToEnd();
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine($"Line {lineNumber}: {line}");


                    int spaceIndex = line.IndexOf(" ");
                    string username = line.Substring(0, spaceIndex).Trim();
                    string password = line.Substring(spaceIndex + 1).Trim();
                    if (u1.Equals(username) && p1.Equals(password))
                    {
                        // Label2.Text = "Welcome your Username and password are correct";
                        reader.Close();

                        return true;//successfully authenticated


                    }
                    line = reader.ReadLine();


                }
                reader.Close();
                return false;



            }
            catch (ArgumentException ex)
            {
                return false;
            }
            catch (FileNotFoundException ex)
            {
                return false;
            }
            catch (IOException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }


        }



        public LinkedList<String> ReadFileHandled(string filename)
        {
            try
            {
                LinkedList<String> stacklist = new LinkedList<String>();
                int lineNumber = 0;
                TextReader reader = new StreamReader(filename);
                //string line = reader.ReadToEnd();
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine($"Line {lineNumber}: {line}");

                    // Label2.Text = "Welcome your Username and password are correct";



                    stacklist.AddLast(line);

                    line = reader.ReadLine();


                }
                reader.Close();
                return stacklist;


            }
            catch (ArgumentException ex)
            {
                return null;
            }
            catch (FileNotFoundException ex)
            {
                return null;
            }
            catch (IOException ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }


        } //read todo items


        //add todo list to text file
        public Boolean writeFileHandled(string filename ,LinkedList<string> stacklist)
        {
            try
            {

                TextWriter writer = new StreamWriter(filename);
                foreach (var item in stacklist)
                {
                    writer.WriteLine(item);
                }
                writer.Close();
                return true;


            }
            catch (ArgumentException ex)
            {
                return false;
            }
            catch (FileNotFoundException ex)
            {
                return false;
            }
            catch (IOException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }


        }


        public Boolean appendCredentials(string filename,String u1, String p1)
        {
            try
            {

                TextWriter writer = new StreamWriter(filename, append: true);
                //string line = reader.ReadToEnd();
                writer.WriteLine(u1 + " " + p1);


                writer.Close();
                return true;


            }
            catch (ArgumentException ex)
            {
                return false;
            }
            catch (FileNotFoundException ex)
            {
                return false;
            }
            catch (IOException ex)
            {
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

    }
}

