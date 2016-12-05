using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public partial class MainForm : Form
    {
        Task myTask = new Task(DateTime.Now);
        Task[] taskArray;
        Timer labelTimer = new Timer();

        ///<summary>
        ///Återställer Programmet till startläge
        ///</summary>
        private void InitializeGUI()
        {
            comboBoxPriority.SelectedIndex = 2;
            listboxToDo.Items.Clear();
            labelTimer.Interval = 100;
            labelTimer.Tick += LabelTimer_Tick;
            labelTimer.Start();
            txtBoxToDo.Text = "";
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            taskArray = new Task[20];
        }
        ///<summary>
        ///Här startar programmet
        ///</summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            
        }

        ///<summary>
        ///Visar klockan på label
        ///</summary>
        private void LabelTimer_Tick(object sender, EventArgs e)
        {
            lblCurTime.Text = "";
            DateTime currentTime = DateTime.Now;
            lblCurTime.Text += currentTime.ToString("HH : mm : ss");
        }
        ///<summary>
        ///Nollställer programmet om man väljer New
        ///</summary>
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }


        ///<summary>
        ///Hämtar sparade to-do-listor
        ///</summary>
        private void OpenDataFromFile()
        {
            string fileName = "";


            FileDialog myFileDialog = new OpenFileDialog();
            myFileDialog.ShowDialog();
            fileName = myFileDialog.FileName;
            
            ReadDataFromSaveFile(fileName);
        }

        ///<summary>
        ///Läser data från sparad fil
        ///</summary>
        private void ReadDataFromSaveFile(string fileLocation)
        {
            Task[] savedTaskArray = new Task[taskArray.Length];
            string[] saveStringArray =  File.ReadAllLines(fileLocation);
            for (int i = 0; i< saveStringArray.Length; i++)
            {
                savedTaskArray[i] = new Task(DateTime.Now);
                savedTaskArray[i].ReadFromSaveFile(saveStringArray[i]);
            }
            taskArray = savedTaskArray;

            btnChange.Enabled = false;
            btnDelete.Enabled = false;

        }


        ///<summary>
        ///Avslutar programmet
        ///</summary>
        private void EndProgram()
        {
            String warningSign = "Are you sure you want to close the program?";
            string information = "Press ok to close";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(warningSign, information , buttons);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }


        ///<summary>
        ///Lägger till nytt objekt i listan
        ///</summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToArray();
            WriteArrayToListbox();
            txtBoxToDo.Text = "";
        }

        ///<summary>
        ///Ändrar objekt i listan
        ///</summary>
        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeItem();
            WriteArrayToListbox();
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
            txtBoxToDo.Text = "";

        }
        ///<summary>
        ///Metoden för att ändra objekt
        ///</summary>
        
        private void ChangeItem()
        {
            int indexOfItem = listboxToDo.SelectedIndex;
            
            DateTime newDateTIme = dateTimePickerToDo.Value.Date;
            newDateTIme += dateTimePickerToDo.Value.TimeOfDay;
            taskArray[indexOfItem].TaskDateTime=newDateTIme;

            taskArray[indexOfItem].TaskPriority=GetPrioFromComboBox();
            taskArray[indexOfItem].TaskDescription = txtBoxToDo.Text;
        }

        ///<summary>
        ///Knapp för att radera objekt i listan
        ///</summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemoveFromArray();
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
        }

        ///<summary>
        ///Hämtar data från kombobox
        ///</summary>

        private PriorityList GetPrioFromComboBox()
        {
            PriorityList newPriority;

            if(comboBoxPriority.SelectedItem != null)
            {
                if (comboBoxPriority.SelectedItem.ToString() == "Very important")
                {
                    newPriority = PriorityList.veryImportant;
                }
                else if (comboBoxPriority.SelectedItem.ToString() == "Important")
                {
                    newPriority = PriorityList.mediumImpoortant;
                }
                else if (comboBoxPriority.SelectedItem.ToString() == "Less important")
                {
                    newPriority = PriorityList.lessImportant;
                }
                else
                {
                    newPriority = PriorityList.lessImportant;
                }
            }
            else
            {
                newPriority = PriorityList.lessImportant;
            }
            return newPriority;
        }

        ///<summary>
        ///Lägger till objekt i användarens todo-list
        ///</summary>
        private void AddToArray()
        {
            Task newTask = new Task(DateTime.Now);

            DateTime newDateTIme = dateTimePickerToDo.Value.Date;
            newDateTIme += dateTimePickerToDo.Value.TimeOfDay;
            newTask.TaskDateTime=newDateTIme;

            newTask.TaskPriority=GetPrioFromComboBox();
            newTask.TaskDescription= txtBoxToDo.Text;

            int nrOfTasks = listboxToDo.Items.Count;
            if(nrOfTasks<=18)
            {
                taskArray[nrOfTasks] = newTask;
                
            }
            else
            {
                MessageBox.Show("Maximum nr of tasks reached.");
            }
        }

        ///<summary>
        ///Skriver från array till listbox
        ///</summary>
        private void WriteArrayToListbox()
        {
            listboxToDo.Items.Clear();
            for (int i =0; i<taskArray.Length;i++)
            {
                if(taskArray[i]!=null)
                {
                    string taskFromList = taskArray[i].ConvertTaskToString();
                    listboxToDo.Items.Add(taskFromList);
                }
            }
        }

        ///<summary>
        ///Tar bort objekt ur listan
        ///</summary>
        private void RemoveFromArray()
        {
            int indexOfItem = listboxToDo.SelectedIndex;
            

            Task[] newArray = new Task[taskArray.Length];

            int indexCounter = 0;
            //Sorterar först min array så att den inte innehåller tomma poster som
            //kan trassla till min index
            for (int i = 0; i < taskArray.Length; i++)
            {
                if (taskArray[i] != null)
                {

                    newArray[indexCounter] = taskArray[i];
                    indexCounter++;
                }
            }

            taskArray = newArray;

            //Nollställer min counter och tar bort valt element.
            indexCounter = 0;

            for (int i=0; i<taskArray.Length; i++)
            {
                if (i!=indexOfItem)
                {
                    newArray[indexCounter] = taskArray[i];
                    indexCounter++;
                }
            }
            taskArray = newArray;
            WriteArrayToListbox();
        }


        ///<summary>
        /// visar valt alternativ ur listbox
        ///</summary>
        private void listboxToDo_SelectedIndexChanged(object sender, EventArgs e)
        {

            int itemsInList = listboxToDo.Items.Count;
            if(itemsInList>0)
            {
                btnChange.Enabled = true;
                btnDelete.Enabled = true;
                dateTimePickerToDo.Value = taskArray[itemsInList - 1].TaskDateTime;
                txtBoxToDo.Text = taskArray[itemsInList - 1].TaskDescription;
            }
        }


        ///<summary>
        ///nollställer programmet om man väljer new
        ///</summary>
        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        ///<summary>
        ///öppnar sparad fil
        ///</summary>
        private void openDatafileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenDataFromFile();
            WriteArrayToListbox();
        }

        ///<summary>
        ///öppnar about-box
        ///</summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDoAboutBox aboutBox = new ToDoAboutBox();
            aboutBox.Show();
        }

        ///<summary>
        ///sparar lista i fil
        ///</summary>
        private void saveDatafileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string fileLocation = "";
            string fileName = "";
            string saveContentString = "";
            for (int i = 0; i < taskArray.Length; i++)
            {
                if (taskArray[i] != null)
                {
                    saveContentString += taskArray[i].WriteToSaveFile();
                }

            }

            FileDialog myFileDialog = new SaveFileDialog();

            myFileDialog.ShowDialog();
            fileName = myFileDialog.FileName;
            fileLocation = myFileDialog.InitialDirectory;

            fileLocation += fileName;
            fileLocation += ".txt";
            File.WriteAllText(fileLocation, saveContentString);
        }
        ///<summary>
        ///avslutar programmet
        ///</summary>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EndProgram();
        }
    }
}
