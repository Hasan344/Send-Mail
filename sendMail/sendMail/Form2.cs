using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.IO;
namespace sendMail
{
    public partial class Form2 : Form
    {
        private List<History> historyList = new List<History>();
       

        
        private void Form2_Load(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Users\\hasan\\Downloads\\history.txt");
           
            
            for (int i = 0; i < historyList.Count; i++)
            {
                History h = historyList[i];
                string[] row = new string[] { h.id.ToString(), h.to, h.from, h.subject, h.message,  h.time.ToString() };
                dataGridView1.Rows.Add(row);
                writer.WriteLine("Id: " + h.id.ToString() + "To:" + h.to + "From:" + h.from + "Subject:" + h.subject + "Message:" + h.message + "Time:" + h.time.ToString());

            }
              writer.Close();
            
        }
        public Form2(List<History> tarixce)
        {
            
            InitializeComponent();
            historyList = tarixce;
        }
       
       
    }
}
