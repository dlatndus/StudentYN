using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentYN
{
    public partial class Form1 : Form
    {
        static private List<Student> students = new List<Student>()
        {
            new Student(){ Id= 3101, Name="김신흥", Submit="yes"},
            new Student(){ Id= 3102, Name="김윤서", Submit="no"},
            new Student(){ Id= 3103, Name="김태연", Submit="yes"},
            new Student(){ Id= 3104, Name="문채영", Submit="yes"},
            new Student(){ Id= 3105, Name="박나경", Submit="no"},
            new Student(){ Id= 3106, Name="박승채", Submit="yes"},
            new Student(){ Id= 3107, Name="양지혜", Submit="yes"},
            new Student(){ Id= 3108, Name="인소리", Submit="no"},
            new Student(){ Id= 3109, Name="임수연", Submit="yes"},
            new Student(){ Id= 3110, Name="정가현", Submit="no"},
            new Student(){ Id= 3111, Name="정현진", Submit="no"},
            new Student(){ Id= 3112, Name="조예서", Submit="yes"},
            new Student(){ Id= 3113, Name="최자윤", Submit="no"},
            new Student(){ Id= 3114, Name="황유솔", Submit="yes"},
            new Student(){ Id= 3115, Name="권하은", Submit="no"},
            new Student(){ Id= 3116, Name="양다연", Submit="yes"},
            new Student(){ Id= 3117, Name="윤소희", Submit="yes"},
            new Student(){ Id= 3118, Name="곽경희", Submit="no"},
            new Student(){ Id= 3119, Name="김하늘", Submit="yes"},
            new Student(){ Id= 3120, Name="장서영", Submit="no"},
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = students;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = from item in students
                                              where item.Submit == "yes"
                                              select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = from item in students
                                              where item.Submit == "no"
                                              select item;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = from item in students
                                              orderby item.Name
                                              select item;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = from item in students
                                              orderby item.Submit descending
                                              select item;
        }

       
    }
}
