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
            currCircuit = new Circuit(gr);
            // Set images to left menu pictureboxes
            pbSource.Image = CircuitSimLib.Properties.Resources.source;
            pbOr.Image = CircuitSimLib.Properties.Resources.or;
            pbAnd.Image = CircuitSimLib.Properties.Resources.and;
            pbNot.Image = CircuitSimLib.Properties.Resources.nand; // Gotta add "not" image to resources

            ((Control)panel).AllowDrop = true; //
            
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            Point pointOnForm = panel.PointToClient(new Point(e.X, e.Y));
            if (!currCircuit.AddElement(e.Data.GetData(DataFormats.Text).ToString(), pointOnForm.X, pointOnForm.Y))
            {
                MessageBox.Show("fix ur autism");
            }
            
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
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

        private void pbAnd_MouseDown(object sender, MouseEventArgs e)
        {
            pbAnd.DoDragDrop("AND", DragDropEffects.Copy);
        }

        private void pbSource_MouseDown(object sender, MouseEventArgs e)
        {
            pbSource.DoDragDrop("STSOURCE", DragDropEffects.Copy);
        }

        private void pbOr_MouseDown(object sender, MouseEventArgs e)
        {
            pbOr.DoDragDrop("OR", DragDropEffects.Copy);
        }

        private void pbNot_MouseDown(object sender, MouseEventArgs e)
        {
            pbNot.DoDragDrop("NOT", DragDropEffects.Copy);
        }



    }
}
