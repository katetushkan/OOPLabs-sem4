using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using ZipInterface;
using System.Reflection;
//using Ionic.Zip;

using System.IO.Compression;



namespace OOP2
{
    public partial class Form1 : Form
    {
        List<InboxClass> ReadyInbox = new List<InboxClass>();
        List<EventClass> ReadyEvent = new List<EventClass>();
        Array array = new Array(null, null, null, null);
        
        List<ProjCl> ReadyProject = new List<ProjCl>();
        List<SubProj> ReadySub = new List<SubProj>();
        public Form1()
        {
            InitializeComponent();
            projBox.Visible = false;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView2.ContextMenuStrip = contextMenuStrip2;
            treeView1.ContextMenuStrip = contextMenuStrip3;
            comboBox1.Text = "Task";
            archBox.Text = "ZIP";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Task")
            {
                InboxClass inboxClass = new InboxClass(InputField.Text);
                AddInfoInboxGrid(InputField.Text);
                ReadyInbox.Add(item: inboxClass);
            }

            if (comboBox1.Text == "Today")
            {
                EventClass eventClass = new EventClass(InputField.Text, DateTime.Now.ToShortDateString(), "--");
                AddInfoTodayGrid(InputField.Text, DateTime.Now.ToShortDateString(), "--");
                ReadyEvent.Add(item: eventClass);
                

            }

            if (comboBox1.Text == "Event")
            {
                dateBx.Mask = "99-99-9999";
                EventClass eventClass = new EventClass(InputField.Text, "--", "--");
                AddInfoTodayGrid(InputField.Text,dateBx.Text.ToString(), timeBx.Text.ToString());
                ReadyEvent.Add(item: eventClass);

            }

            if (comboBox1.Text == "Project")
            {
                TaskCL taskCL = new TaskCL("none", "--", "--", "--");
                ProjCl projCl = new ProjCl(InputField.Text, 0, taskCL);
                AddInfoProject(InputField.Text);
                ReadyProject.Add(item: projCl);
         
            }
            if (comboBox1.Text == "Sub Task")
            {
                InboxClass inboxClass = new InboxClass(InputField.Text);
                SubProj subProj = new SubProj(projBox.Text, inboxClass);
                ReadySub.Add(item: subProj);
                AddSubTask(InputField.Text);
                

            }
            InputField.Clear();
            projBox.Items.Clear();

        }
        public void AddSubTask(string name)
        {
            for (int ind = 0; ind <= treeView1.Nodes.Count-1; ind++)
            {
                if (treeView1.Nodes[ind].Text == projBox.Text)
                {
                    treeView1.Nodes[ind].Nodes.Add(InputField.Text);
                }
                
            }

        }
        public void AddInfoInboxGrid (string name)
        {
            
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = name ;


        }

        public void AddInfoTodayGrid(string name, string date, string time)
        {

            dataGridView2.Rows.Add();
            dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[0].Value = name;
            dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[1].Value = time;
            dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[2].Value = date;

        }

        public void AddInfoProject(string name)
        {

            treeView1.Nodes.Add(name);
            
        }

        

        

        private void AddMen_Click(object sender, EventArgs e)
        {
            
            int ind = 0;
            for (int i =0; i < dataGridView1.RowCount ; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView1.CurrentRow.ToString())
                {
                    ind = i; 
                }
                
            }
            TaskCL taskCL = new TaskCL("none", "--", "--", "--");
            ProjCl projCl = new ProjCl(dataGridView1.CurrentRow.Cells[0].Value.ToString(), 0, taskCL);
            AddInfoProject(projCl.nameItem);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void DelMen_Click(object sender, EventArgs e)
        {

            int ind = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView1.CurrentRow.ToString())
                {
                    ind = i;
                }

            }
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        public void combo ()
        {
            for (int i = 0; i <= treeView1.Nodes.Count - 1; i++)
            {
                projBox.Items.Add(treeView1.Nodes[i].Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Event")
            {
                dateBx.Visible = true;
                timeBx.Visible = true;
               
            }
            else
            {
                dateBx.Visible = false;
                timeBx.Visible = false;
            }
           if (comboBox1.Text == "Sub Task")
            {
                projBox.Visible = true;
                combo();

            }
            else
            {
                projBox.Visible = false;
              
            }
        }

        private void applyDatebtn_Click(object sender, EventArgs e)
        {
            

            int ind = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView1.CurrentRow.ToString())
                {
                    ind = i;
                }

            }
           
            EventClass eventClass = new EventClass(dataGridView1.CurrentRow.Cells[0].Value.ToString(), Datebox.Text.ToString(), "--");

            AddInfoTodayGrid(eventClass.nameItem, eventClass.dateItem, eventClass.timeItem);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            Datebox.Clear();
        }

        private void ApllyTimebtn_Click(object sender, EventArgs e)
        {
            int ind = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView1.CurrentRow.ToString())
                {
                    ind = i;
                }

            }

            EventClass eventClass = new EventClass(dataGridView1.CurrentRow.Cells[0].Value.ToString(),"--", TimeBox.Text.ToString());

            AddInfoTodayGrid(eventClass.nameItem, eventClass.dateItem, eventClass.timeItem);
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            TimeBox.Clear();
        }

        private void EditApplBtn_Click(object sender, EventArgs e)
        {
            int ind = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == dataGridView1.CurrentRow.ToString())
                {
                    ind = i;
                }

            }

            InboxClass inboxClass = new InboxClass(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            inboxClass.nameItem = editBox.Text;
            dataGridView1.CurrentRow.Cells[0].Value = inboxClass.nameItem;
            editBox.Clear();
            
        }

        private void applBtn2_Click(object sender, EventArgs e)
        {
            int ind = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == dataGridView2.CurrentRow.ToString())
                {
                    ind = i;
                }

            }

            EventClass eventClass = new EventClass(dataGridView2.CurrentRow.Cells[0].Value.ToString(), dataGridView2.CurrentRow.Cells[2].Value.ToString(), dataGridView2.CurrentRow.Cells[1].Value.ToString());
            eventClass.nameItem = nameBx2.Text;
            eventClass.dateItem = dateBx2.Text;
            eventClass.timeItem = timeBx2.Text;
            dataGridView2.CurrentRow.Cells[0].Value = eventClass.nameItem;
            dataGridView2.CurrentRow.Cells[1].Value = eventClass.timeItem;
            dataGridView2.CurrentRow.Cells[2].Value = eventClass.dateItem;
            nameBx2.Clear();
            dateBx2.Clear();
            timeBx2.Clear();


        }

        private void editBtn2_Click(object sender, EventArgs e)
        {
           
            nameBx2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            timeBx2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            dateBx2.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void delBtn2_Click(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                    for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
                    {
                        if (treeView1.Nodes[i].Nodes[j].Text == dataGridView2.CurrentRow.Cells[0].Value.ToString())
                        {
                            treeView1.Nodes[i].Nodes[j].Remove();
                        }

                    }

            }
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
        }

        private void delbtn3_Click(object sender, EventArgs e)
        {
           
        
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {

                if (treeView1.Nodes[i].Text == treeView1.SelectedNode.Text)
                {
                    treeView1.Nodes[i].Remove();
                   
                }
                else
                {
                    for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
                    {
                        if (treeView1.Nodes[i].Nodes[j].Text == treeView1.SelectedNode.Text)
                        {
                            for (int ij = 0; ij < dataGridView2.RowCount; ij++)
                            {
                                if (dataGridView2.Rows[ij].Cells[0].Value.ToString() == treeView1.SelectedNode.Text)
                                {
                                    dataGridView2.Rows.RemoveAt(ij);
                                }

                            }

                            treeView1.Nodes[i].Nodes[j].Remove();
                        }

                    }

                }


            }
          
        }

        private void applybtnEv3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {

                for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
                {
                        if (treeView1.Nodes[i].Nodes[j].Text == treeView1.SelectedNode.Text)
                        {
                        AddInfoTodayGrid(treeView1.SelectedNode.Text, datebtnEv3.Text, timebtnEv3.Text);
                        }

                 }

            }


            
        }

        private void aplEdit3_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i < treeView1.Nodes.Count; i++)
            {
                if (treeView1.Nodes[i].Text == treeView1.SelectedNode.Text)
                {
                    InboxClass inboxClass = new InboxClass(treeView1.Nodes[i].Text);
                    inboxClass.nameItem = editFld3.Text;
                    treeView1.SelectedNode.Text = inboxClass.nameItem;
                    editFld3.Clear();

                }
                else
                { 
                for (j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
                {
                    if (treeView1.Nodes[i].Nodes[j].Text == treeView1.SelectedNode.Text)
                    {
                            InboxClass inboxClass = new InboxClass(treeView1.Nodes[i].Nodes[j].Text);
                            inboxClass.nameItem = editFld3.Text;
                            treeView1.SelectedNode.Text = inboxClass.nameItem;
                            editFld3.Clear();
                        }

                }
                }
            }
            
           
        }

        private void ditbtn3_Click(object sender, EventArgs e)
        {
            editFld3.Text = treeView1.SelectedNode.Text;
        }

        private void editItem_Click(object sender, EventArgs e)
        {
            editBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

       

        private void dateBx_Click(object sender, EventArgs e)
        {

            dateBx.Clear();
            dateBx.Mask = "00-00-0000";
        }

        private void timeBx_Click(object sender, EventArgs e)
        {
            timeBx.Clear();
            timeBx.Mask = "00:00";
        }

        private void Datebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void TimeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void nameBx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void datebtnEv3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void datebtnEv3_Click(object sender, EventArgs e)
        {
            datebtnEv3.Clear();
        }

        private void timebtnEv3_Click(object sender, EventArgs e)
        {
            timebtnEv3.Clear();
        }

        private void timebtnEv3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void dateBx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void timeBx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46 ) )
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void Datebox_Click(object sender, EventArgs e)
        {
            Datebox.Clear();
        }

        private void TimeBox_Click(object sender, EventArgs e)
        {
            TimeBox.Clear();
        }

        private void serbtn_Click(object sender, EventArgs e)
        {
            
                var serializer = new Serializer();
            string fileName = serializer.Serialize(ReadyInbox, ReadyEvent, ReadyProject, ReadySub, null);

            if (archBox.Text == "ZIP")
            {
                
                string newfile = fileName;
                
                newfile = newfile + ".zip";
             
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile()) // Создаем объект для работы с архивом
                {
                    zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression; // MAX степень сжатия
                    zip.AddFile(fileName); 
                    zip.Save(newfile);  // Создаем архив  
                }

            }
            else if (archBox.Text == "GZip")
            {
                GZarchiv gZarchiv = new GZarchiv();
                string newfile = fileName;
                newfile = newfile.Replace(Path.GetExtension(newfile), ".gzip");
                
                gZarchiv.Zip(fileName, newfile);
            }
            if (archBox.Text == "BZip2")
            {
                Bz2Arch bz2Arch = new Bz2Arch();
                string newfile = fileName;
                newfile = newfile.Replace(Path.GetExtension(newfile), ".bzip2");
                bz2Arch.Zip(fileName, newfile);
            }
        }
        

        private void Deserbtn_Click(object sender, EventArgs e)
        {
            var serializer = new Serializer();
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.DefaultExt = ".json";
            openDialog.Filter = "Text files (*.zip)|*zip| JSON files (*.json)|*json| XML files (*.xml)|*xml| DAT files (*.dat)|*dat|BIN files (*.bin)|*bin";
            openDialog.ShowDialog();
            string fileName1 = "";
            string fileName = openDialog.FileName;
            string FileExtension = Path.GetExtension(fileName);
            if (FileExtension == ".zip")
            {
                Path.GetFileNameWithoutExtension(fileName1) = Path.GetFileNameWithoutExtension(fileName1) + "new";
                fileName1 = fileName1.Replace(".zip", "");
                ZipFile.ExtractToDirectory(fileName, fileName1);


            }
            else if (FileExtension == ".gzip")
            {
                GZarchiv gZarchiv = new GZarchiv();
                string newfile = fileName;
                newfile = newfile.Replace(Path.GetExtension(newfile), ".gzip");

                gZarchiv.Zip(fileName, newfile);
            }
            if (FileExtension == ".bzip2")
            {
                Bz2Arch bz2Arch = new Bz2Arch();
                string newfile = fileName;
                newfile = newfile.Replace(Path.GetExtension(newfile), ".bzip2");
                bz2Arch.Zip(fileName, newfile);
            }
            array = serializer.Deserialize(ReadyInbox, ReadyEvent, ReadyProject, ReadySub, array, fileName1);
            
            for (int i = 0; i < array.listIn.Count; i++)
            {
                AddInfoInboxGrid(array.listIn[i].nameItem);
            }
            for (int i = 0; i < array.listEv.Count; i++)
            {
                AddInfoTodayGrid(array.listEv[i].nameItem, array.listEv[i].dateItem, array.listEv[i].timeItem);
            }
            for (int i = 0; i < array.listProj.Count; i++)
            {
                AddInfoProject(array.listProj[i].nameItem);
            }
            for (int i = 0; i < array.listSub.Count; i++)
            {
                for (int ind = 0; ind <= treeView1.Nodes.Count - 1; ind++)
                {
                    if (treeView1.Nodes[ind].Text == array.listSub[i].prname)
                    {
                        treeView1.Nodes[ind].Nodes.Add(array.listSub[i].prname);
                    }

                }
            }

            array = null;
        }

        

        private void archBox_DropDown(object sender, EventArgs e)
        {
            archBox.Items.Clear();

            string[] plugins = { "ZipArchive.dll", "GzArchive.dll", "Bz2Archive.dll" };
            string[] types = { "Zip", "GZip", "BZip2" };

            for (int i = 0; i < plugins.Length; i++)
            {
                
                    archBox.Items.Add(types[i]);
                  
            }
        }
    }
}

