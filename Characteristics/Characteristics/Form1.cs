using System;
using System.Windows.Forms;
using Characteristics.erp;
using Characteristics.erp.Util;

namespace Characteristics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var connection = new ErpConnection("IDES-041", "1student");

            
            var characteristics = new ErpCharacteristics(connection);

            var listResponse = characteristics.GetList(GetList.Sing.Inclusive, GetList.Options.GreaterEqual, "0");

            Console.Out.WriteLine(listResponse);
            
            
            
            var sapClass = new ErpClass(connection);

            var classListResponse = sapClass.GetList("001", GetList.Sing.Inclusive, GetList.Options.GreaterEqual, "0");
           
            Console.Out.WriteLine(classListResponse);
        }
    }
}