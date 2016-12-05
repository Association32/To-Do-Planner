using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//////////////////////////////////////////////
//
//
//Program skapat av Jens Friberg
//
//Till Högskolan i Malmö
//
//Till Kurs i c#
//
///////////////////////////////////////////////
namespace Assignement4
{
    class Task
    {
        private DateTime taskDateTime;
        private PriorityList taskPriority;
        private string taskDesciption ="";

        ///<summary>
        ///Getters och setters för dateTime
        ///</summary>
        public DateTime TaskDateTime
        {
            get { return taskDateTime; }

            set
            {
                if(value == null)
                {
                    //Ger den ett standardvärde.
                    taskDateTime = DateTime.Now;
                }
                else
                {
                    taskDateTime = value;
                }
                
            }
        }

        ///<summary>
        ///Getters och setters för taskPriority
        ///</summary>
        public PriorityList TaskPriority
        {
            get { return taskPriority; }

            set
            {
                if((value == PriorityList.lessImportant)||(value == PriorityList.mediumImpoortant) ||(value == PriorityList.veryImportant))
                {
                    taskPriority = value;
                }
                else
                {
                    //Ger den ett standardvärde.
                    taskPriority = PriorityList.lessImportant;
                }
                
            }
        }

        ///<summary>
        ///Getters och setters för taskDescription
        ///</summary>
        public string TaskDescription
        {
            get { return taskDesciption; }

            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    taskDesciption = value;
                }
                else
                {
                    //Ger den ett standardvärde.
                    taskDesciption = "No description";
                }
            }
        }


        ///<summary>
        ///Konstruktor
        ///</summary>
        public Task(DateTime taskDateTime)
        {
            this.taskDateTime = taskDateTime;

            
        }


        ///<summary>
        ///Används för att skriva ut texten till listbox
        ///</summary>
        public string ConvertTaskToString()
        {
            string convertedString = "";
            convertedString += TaskDateTime.ToString("yyyy:MM:dd\tHH:mm");
            convertedString += "\t\t";
            if(TaskPriority!=0)
            {
                if(TaskPriority == PriorityList.veryImportant)
                {
                    convertedString += "Very important";
                }
                else if(TaskPriority == PriorityList.mediumImpoortant)
                {
                    convertedString += "Important";
                    convertedString += "\t";
                }
                else
                {
                    convertedString += "Less important";
                }

            }
            else
            {
                convertedString += "No priority given";
            }
            
            convertedString += "\t";
            if(TaskDescription.Length !=0)
            {
                convertedString += TaskDescription;
            }
            else 
            {
                convertedString += "No description given";
            }

            return convertedString;
        }

        ///<summary>
        ///Skriver ut sträng till sparad fil
        ///</summary>
        public string WriteToSaveFile()
        {
            string SaveString = "";
            SaveString += TaskDateTime.ToString();
            SaveString += "\t";
            SaveString += TaskPriority.ToString();
            SaveString += "\t";
            SaveString += TaskDescription;
            SaveString += Environment.NewLine;
            return SaveString;
        }

        ///<summary>
        ///läser sträng från sparad fil till objekt
        ///</summary>
        public void ReadFromSaveFile(string saveString)
        {
            string[] saveStringArray = saveString.Split('\t');
            TaskDateTime = DateTime.Parse(saveStringArray[0]);

            if (saveStringArray[1] == "veryImportant")
            {
                TaskPriority = PriorityList.veryImportant;
            }
            else if(saveStringArray[1] =="mediumImpoortant")
            {
                TaskPriority = PriorityList.mediumImpoortant;
            }
            else if (saveStringArray[1] == "lessImportant")
            {
                TaskPriority = PriorityList.lessImportant;
            }

            TaskDescription = saveStringArray[2];
        }
    }
}
