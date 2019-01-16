using System;
using System.Windows.Forms;
using Characteristics.erp;
using Characteristics.erp.Util;
using Characteristics.Erp.Util;

namespace Characteristics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var connection = new ErpConnection("IDES-041", "1student");


            var erpCharacteristics = new ErpCharacteristics(connection);

            var characteristics = erpCharacteristics.GetList(GetList.Sing.Inclusive, GetList.Options.GreaterEqual, "0");
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

            var classCreateResponse = sapClass.ClassCreate("001", "Neue_Klasse", "de-DE");
            Console.Out.WriteLine(classCreateResponse);

            var classGetDetailResponse = sapClass.ClassGetDetail("001", "Neue_Klasse");
            Console.Out.WriteLine(classGetDetailResponse);

            var classGetCharactetisticsResponse = sapClass.ClassGetCharacteristics("001", "Neue_Klasse");
            Console.Out.WriteLine(classGetCharactetisticsResponse);

            var classChangeResponse = sapClass.ClassChange("001", "Neue_Klasse", "Neue_Beschreibung", "de-DE");
            Console.Out.WriteLine(classChangeResponse);

            var commitClass = sapClass.CommitChanges();
            Console.Out.WriteLine(commitClass);
        }
    }
}