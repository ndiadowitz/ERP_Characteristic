using System;
using System.Windows.Forms;
using Characteristics.erp;
using Characteristics.erp.Util;
using Characteristics.Erp.Util;
using Characteristics.Erp.@object;

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

            var characteristic = new Characteristic("Fisch","blubb", Datatypes.Datatype.CHAR, "0", "0", "a fish says blubb", "RELEASE");
            var create = erpCharacteristics.CreateCharacteristic(characteristic);
            Console.Out.WriteLine(create);

            var commit = erpCharacteristics.CommitChanges();
            Console.Out.WriteLine(commit);


            var detail = erpCharacteristics.GetDetail(characteristics[364]);
            Console.Out.WriteLine(detail);

            var longText = erpCharacteristics.GetLongText(characteristics[364]);
            Console.Out.WriteLine(longText);



            var testlong = erpCharacteristics.GetLongText(characteristics[3]);
            Console.Out.WriteLine(testlong);

            var addlongtext = erpCharacteristics.AddLongText(characteristics[3], LongTextHelper.Format.Default, "Hallo");
            Console.Out.WriteLine(addlongtext);

            commit = erpCharacteristics.CommitChanges();
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
    }
}