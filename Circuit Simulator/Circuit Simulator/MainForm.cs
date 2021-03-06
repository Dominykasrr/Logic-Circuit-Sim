﻿using System;
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
        Point pointToDrawLineFrom = new Point(0, 0);
        Point pointClicked = new Point(0, 0);
        Element toMove;
        ConnectionPoint temp_input;


        public MainForm()
        {
            InitializeComponent();

            gr = panel.CreateGraphics();
            currCircuit = new Circuit(gr);
            // Set images to left menu pictureboxes
            pbStaticSource.Image = CircuitSimLib.Properties.Resources.source;
            pbDynamicSource.Image = CircuitSimLib.Properties.Resources.clock;
            pbOr.Image = CircuitSimLib.Properties.Resources.or;
            pbAnd.Image = CircuitSimLib.Properties.Resources.and;
            pbNot.Image = CircuitSimLib.Properties.Resources.inverter;
            pbSink.Image = CircuitSimLib.Properties.Resources.lamp_on;

            ((Control)panel).AllowDrop = true; //

        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            Point pointOnForm = panel.PointToClient(new Point(e.X, e.Y));
            if (!currCircuit.AddElement(e.Data.GetData(DataFormats.Text).ToString(), pointOnForm.X, pointOnForm.Y))
            {
                MessageBox.Show("fix ur autism");
            }
            else
            {
                currCircuit.DrawAll();
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

        private void pbOr_MouseDown(object sender, MouseEventArgs e)
        {
            pbOr.DoDragDrop("OR", DragDropEffects.Copy);
        }

        private void pbNot_MouseDown(object sender, MouseEventArgs e)
        {
            pbNot.DoDragDrop("NOT", DragDropEffects.Copy);
        }

        private void pbStaticSource_MouseDown(object sender, MouseEventArgs e)
        {
            pbStaticSource.DoDragDrop("STSOURCE", DragDropEffects.Copy);
        }

        private void pbDynamicSource_MouseDown(object sender, MouseEventArgs e)
        {
            pbDynamicSource.DoDragDrop("DYSOURCE", DragDropEffects.Copy);

        }
        private void pbSink_MouseDown(object sender, MouseEventArgs e)
        {
            pbSink.DoDragDrop("SINK", DragDropEffects.Copy);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            currCircuit.DrawSinksAndConnections();
            currCircuit.DrawAll();
            Invalidate();
        }
        private void panel_MouseClick(object sender, MouseEventArgs e) { }
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            pointClicked.X = e.X;
            pointClicked.Y = e.Y;
            if (e.Button == MouseButtons.Left)
            {
                
                if(toMove!=null)
                {
                    if (currCircuit.MoveElement(toMove, e.X, e.Y))
                    {
                        toMove = null;
                    }
                    else 
                    {
                        MessageBox.Show("Click another palace");
                    }
                }
                if (pointToDrawLineFrom == new Point(0, 0) && toMove == null)
                {
                    gr.DrawRectangle(new Pen(Color.Black), new Rectangle(e.X, e.Y, 10, 10));
                    ConnectionPoint temp = currCircuit.FindConnectionPoint(e.X, e.Y);
                    if (temp != null)
                    {
                        pointToDrawLineFrom = new Point(temp.X, temp.Y);
                        timerDrawLineToCur.Interval = 100;
                        timerDrawLineToCur.Start();
                    }
                }
                else
                {
                    timerDrawLineToCur.Stop();
                    currCircuit.MakeConnection(pointToDrawLineFrom.X, pointToDrawLineFrom.Y, e.X, e.Y);
                    pointToDrawLineFrom = new Point(0, 0);
                    panel.Refresh();
                }
                panel.Refresh();
            }
            else if (e.Button == MouseButtons.Right)
            {
                Element temp = currCircuit.FindElement(e.X, e.Y);
                temp_input = currCircuit.FindConnectionPoint(e.X,e.Y);
                if (temp != null)
                {
                    ContextMenuStrip mnu = new ContextMenuStrip();
                    ToolStripMenuItem mnuRemove = new ToolStripMenuItem("Remove");
                    ToolStripMenuItem mnuToggle = new ToolStripMenuItem("Toggle");
                    ToolStripMenuItem mnuMove = new ToolStripMenuItem("Move");
                    ToolStripMenuItem mnuConnections = new ToolStripMenuItem("Remove Connection");

                    if (temp.GetType() == typeof(StaticSource))
                    {
                        mnuToggle.Click += new EventHandler(mnuToggle_Click);
                        mnu.Items.AddRange(new ToolStripItem[] { mnuToggle });
                    }
                    mnuMove.Click += new EventHandler(mnuMove_Click);
                    mnuRemove.Click += new EventHandler(mnuRemove_Click);
                    
                    mnu.Items.AddRange(new ToolStripItem[] { mnuRemove });
                    mnu.Items.AddRange(new ToolStripItem[] { mnuMove });
                    
                    mnu.Show(e.X, e.Y);
                    if (temp_input !=null && temp_input.GetType() == typeof(InputPoint) )
                    {
                        mnuConnections.Click += new EventHandler(mnuConnections_Click);
                        mnu.Items.AddRange(new ToolStripItem[] { mnuConnections });
                        
                    }
                }
            }
        }

        private void mnuRemove_Click(object sender, EventArgs e)
        {

            currCircuit.RemoveElement(pointClicked.X, pointClicked.Y);

            panel.Refresh();
        }
        private void mnuToggle_Click(object sender, EventArgs e)
        {
            Element tempel = currCircuit.FindElement(pointClicked.X, pointClicked.Y);
            if (tempel.GetType() == typeof(StaticSource))
            {
                StaticSource src = (StaticSource)tempel;
                src.Toggle();
                panel.Refresh();
            }

        }
        private void mnuConnections_Click(object sender, EventArgs e)
        {
           
            
                InputPoint p = (InputPoint)temp_input;
                p.ConnectsTo = null;
            
            
            panel.Refresh();
        }
        private void mnuMove_Click(object sender, EventArgs e)
        {
            toMove = currCircuit.FindElement(pointClicked.X, pointClicked.Y);
            

        }
        private void timerDrawLineToCur_Tick(object sender, EventArgs e)
        {
            panel.Refresh();
            Point pointOnForm = panel.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
            gr.DrawLine(new Pen(Color.Black), pointToDrawLineFrom, pointOnForm);

        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

       





    }
}
