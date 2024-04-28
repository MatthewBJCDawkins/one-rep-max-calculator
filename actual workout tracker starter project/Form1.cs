using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace actual_workout_tracker_starter_project
{
    
    public partial class Form1 : Form
    {
        

        exercise bench = new exercise("bench", 0, 0, 0);
        exercise squat = new exercise("squat", 0, 0, 0);
        exercise deadlift = new exercise("deadlift",0,0, 0);
        exercise barbellrow = new exercise("barbellrow", 0, 0, 0);
        exercise bicepcurl = new exercise("bicepcurl", 0,0, 0); 
        exercise ohp = new exercise("ohp",0,0,0);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        public void bweight_TextChanged(object sender, EventArgs e)
        {
            bench.weight = Convert.ToDouble(bweight.Text);
        }

        private void breps_TextChanged(object sender, EventArgs e)
        {
            bench.reps = Convert.ToDouble(breps.Text);
        }

        private void sweight_TextChanged(object sender, EventArgs e)
        {
            squat.weight = Convert.ToDouble(sweight.Text);
        }

        private void sreps_TextChanged(object sender, EventArgs e)
        {
            squat.reps = Convert.ToDouble(sreps.Text);
        }

        private void dweight_TextChanged(object sender, EventArgs e)
        {
            deadlift.weight = Convert.ToDouble(dweight.Text);
        }

        private void dreps_TextChanged(object sender, EventArgs e)
        {
            deadlift.reps = Convert.ToDouble(dreps.Text);
        }

        private void brweight_TextChanged(object sender, EventArgs e)
        {
            barbellrow.weight = Convert.ToDouble(brweight.Text);
        }

        private void brreps_TextChanged(object sender, EventArgs e)
        {
            barbellrow.reps = Convert.ToDouble(brreps.Text);
        }

        private void cweight_TextChanged(object sender, EventArgs e)
        {
            bicepcurl.weight = Convert.ToDouble(cweight.Text);
        }

        private void creps_TextChanged(object sender, EventArgs e)
        {
            bicepcurl.weight = Convert.ToDouble(creps.Text);
        }

        private void oweight_TextChanged(object sender, EventArgs e)
        {
            ohp.weight = Convert.ToDouble(oweight.Text);
        }

        private void oreps_TextChanged(object sender, EventArgs e)
        {
            ohp.reps = Convert.ToDouble(oreps.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bench.onerm = bench.weight + (bench.reps - 1) * 2.5;
           
            if (bench.onerm <= 0 )
            {
                bm.Text = "";
            }
            else
            {
                bm.Text = Convert.ToString(bench.onerm);
            }
            squat.onerm = squat.weight + (squat.reps - 1) * 5;
            if(squat.onerm <= 0)
            {
                sm.Text = "";
            }
            else
            {
                sm.Text = Convert.ToString(squat.onerm);
            }

            deadlift.onerm = deadlift.weight + (deadlift.reps - 1) * 5;
            if(deadlift.onerm <= 0)
            {
                dm.Text = "";
            }
            else
            {
                dm.Text = Convert.ToString(deadlift.onerm);
            }

            barbellrow.onerm = barbellrow.weight + (barbellrow.reps - 1) * 2.5;
            if(barbellrow.onerm <= 0)
            {
                brm.Text = "";
            }
            else
            {
                brm.Text = Convert.ToString(barbellrow.onerm);
            }

            bicepcurl.onerm = bicepcurl.weight + (bicepcurl.reps - 1) * 2.5;
            if(bicepcurl.onerm <= 0)
            {
                cm.Text = "";
            }
            else
            {
                cm.Text = Convert.ToString(bicepcurl.onerm);
            }

            ohp.onerm = ohp.weight + (ohp.reps - 1) * 1.25;
            if(ohp.onerm <= 0)
            {
                om.Text = "";
            }
            else
            {
                om.Text = Convert.ToString(ohp.onerm);
            }
        }
    }



    class exercise
    {
        public string name;
        public double weight;
        public double reps;

        public double onerm;


        public exercise(string pname, double preps, double pweight, double ponerm)
        {
            name = pname;
            reps = preps;
            weight = pweight;
            onerm = ponerm;



        }

        public string getname() { return name; }
        public double getreps() { return reps; }
        public double getweight() { return weight; }
        public double getonerm() { return onerm; }
    }







}
    

