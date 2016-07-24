using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Command_Stacker
{

    public partial class Form1 : Form
    {
        private static List<Command> commandList = new List<Command>(); 

        public Form1()
        {
            InitializeComponent();
            CommandListDisplay.ColumnCount = 2;
            CommandListDisplay.Columns[0].Name = "Text";
            CommandListDisplay.Columns[1].Name = "Type";
            CommandListDisplay.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stuffMostPeopleDontCareAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was written by zero318 and AlexOSAdventurer.\n\nYou're running version 0.0.2ALPHA.");
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            CommandListDisplay.Rows.Add(); 
        }

        private void RemoveCommand_Click(object sender, EventArgs e)
        {
            if (CommandListDisplay.SelectedRows.Count == 0)
            {
                return; 
            }
            CommandListDisplay.Rows.Remove(CommandListDisplay.SelectedRows[0]); 
        }
    }

    class Command
    {
        public string Text { get; set; }
    }

}
