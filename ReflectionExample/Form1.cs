using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
namespace ReflectionExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MethodlistBox.Items.Clear();
            ProportieslistBox.Items.Clear();
            ConstructorlistBox.Items.Clear();

           
            string TypeName = InputTextBox.Text;
            Type t = Type.GetType(TypeName);
          MethodInfo[] methods=  t.GetMethods();
            foreach (MethodInfo method in methods)
            {
                MethodlistBox.Items.Add(method.ReturnType.Name);
                MethodlistBox.Items.Add(method.Module.Name);

            }

            PropertyInfo[] Proporties = t.GetProperties();
            foreach (PropertyInfo Property in Proporties)
            {
                ProportieslistBox.Items.Add(Property);
            }

            ConstructorInfo[] Constructors = t.GetConstructors();
            foreach (ConstructorInfo Constructor in Constructors)
            {
                ConstructorlistBox.Items.Add(Constructor.ToString());
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InputTextBox.Text))
                infoButton.Visible = false;
            else
                infoButton.Visible = true;
        }
    }
}
