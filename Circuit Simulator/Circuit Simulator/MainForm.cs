using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Circuit_Simulator
{
    public partial class MainForm : Form
    {
        Circuit currCircuit;
        Graphics gr;
        public MainForm()
        {
            InitializeComponent();
            gr = panel.CreateGraphics();
            pbSource.Image = CircuitSimLib.Properties.Resources.source;
            pbOr.Image = CircuitSimLib.Properties.Resources.or;
            pbAnd.Image = CircuitSimLib.Properties.Resources.and;
            ((Control)panel).AllowDrop = true;
            currCircuit = new Circuit(gr);
            
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
          //  if (!currCircuit.AddElement("AND", e.X - panel.Location.X, e.Y - panel.Location.Y))
            if (!currCircuit.AddElement("AND", e.X - panel.Location.X, e.Y - panel.Location.Y))
            {
                MessageBox.Show("fix ur autism");
            }
            
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void buttonAND_Click(object sender, EventArgs e)
        {
            foreach (Element ele in currCircuit.Elements)
            {
                ele.Draw(gr);
            }
        }
        public void Save(String path)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, currCircuit);
            }
            catch (SerializationException) { }
            catch (IOException) { }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        public void Load(String path)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                currCircuit = (Circuit)(bf.Deserialize(fs));
            }
            catch (SerializationException) { }
            catch (IOException) { }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        public void New()
        {
            this.currCircuit = new Circuit(gr);
        }

        private void pbAnd_MouseDown(object sender, MouseEventArgs e)
        {
            pbAnd.DoDragDrop(pbAnd.Image, DragDropEffects.Copy);
        }



    }
}
