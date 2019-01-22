using System;
using System.Windows.Forms;
using Characteristics.erp;
using Characteristics.erp.Util;
using Characteristics.Erp.@object;
using Characteristics.Erp.Util;

namespace Characteristics
{
    public partial class Form1 : Form
    {
        ErpCharacteristics erpCharacteristics = null;

        public Form1()
        {
            InitializeComponent();

            var connection = new ErpConnection("IDES-041", "1student");


            erpCharacteristics = new ErpCharacteristics(connection);
            
            var data = erpCharacteristics.GetList(GetList.Sing.Inclusive, GetList.Options.GreaterEqual, "0");
            var characteristics = Characteristic.ConvertToList(data);
            Console.Out.WriteLine(characteristics);

            var rollback =  erpCharacteristics.RollbackChanges();
            Console.Out.WriteLine(rollback);


            var detail = erpCharacteristics.GetDetail(characteristics[364]);
            Console.Out.WriteLine(detail);

            var longText = erpCharacteristics.GetLongText(characteristics[364]);
            Console.Out.WriteLine(longText);



            var testlong = erpCharacteristics.GetLongText(characteristics[3]);
            Console.Out.WriteLine(testlong);

            var addlongtext = erpCharacteristics.AddLongText(characteristics[3], LongTextHelper.Format.Default, "Hallo");
            Console.Out.WriteLine(addlongtext);

            var commit = erpCharacteristics.CommitChanges();
            Console.Out.WriteLine(commit);

            testlong = erpCharacteristics.GetLongText(characteristics[3]);
            Console.Out.WriteLine(testlong);

            var removelongtext = erpCharacteristics.RemoveLongText(characteristics[3]);
            Console.Out.WriteLine(removelongtext);

            commit = erpCharacteristics.CommitChanges();
            Console.Out.WriteLine(commit);

            testlong = erpCharacteristics.GetLongText(characteristics[3]);
            Console.Out.WriteLine(testlong);





            var sapClass = new ErpClass(connection);

            var classListResponse = sapClass.GetList("001", GetList.Sing.Inclusive, GetList.Options.GreaterEqual, "0");
            Console.Out.WriteLine(classListResponse);

            var classCreateResponse = sapClass.Create("001", "1000000", "DE", "neu");
            Console.Out.WriteLine(classCreateResponse);

            var classGetDetailResponse = sapClass.GetDetail("001", "1000000");
            Console.Out.WriteLine(classGetDetailResponse);

            var classGetCharactetisticsResponse = sapClass.GetCharacteristics("001", "1000000");
            Console.Out.WriteLine(classGetCharactetisticsResponse);

            var classChangeResponse = sapClass.Change("001", "1000000", "neu", "DE", "Neue_Beschreibung", "DE");
            Console.Out.WriteLine(classChangeResponse);

            var commitClass = sapClass.CommitChanges();
            Console.Out.WriteLine(commitClass);
            
        }

        private void CharGetList_Click(object sender, EventArgs e)
        {
            try
            {
                var data = erpCharacteristics.GetList(GetList.Sing.Inclusive, GetList.Options.GreaterEqual, "0");
                var characteristics = Characteristic.ConvertToList(data);
                charBox.DataSource = characteristics;
            } catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
                return;
            }
            
        }
    }
}