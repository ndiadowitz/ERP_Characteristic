using System;
using System.Windows.Forms;
using Characteristics.erp;
using Characteristics.erp.Util;
using Characteristics.Erp.@object;
using Characteristics.Erp.Util;
using Characteristics.Erp.@object;

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

            Disposed += Form1_Disposed;

            /*
            var data = erpCharacteristics.GetList(GetList.Sing.Inclusive, GetList.Options.GreaterEqual, "0");
            var characteristics = Characteristic.ConvertToList(data);
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
            */
        }

        private void Form1_Disposed(object sender, EventArgs e)
        {
            if (erpCharacteristics != null)
                erpCharacteristics.Close();
        }

        private void CharGetList_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();
            try
            {
                var data = erpCharacteristics.GetList(GetList.Sing.Inclusive, GetList.Options.GreaterEqual, "0");
                var characteristics = Characteristic.ConvertToList(data);
                charBox.DataSource = characteristics;
            } catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
        }

        private void charGetDetail_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();
            try
            {
                var element = charBox.SelectedItem;
                if (element == null) return;
                var detail = erpCharacteristics.GetDetail((Characteristic)element);
                charDetail.Text = Characteristic.ConvertToString(detail);
            } catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
        }

        private void getLongText_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();
            try
            {
                var element = charBox.SelectedItem;
                if (element == null) return;
                var text = erpCharacteristics.GetLongText((Characteristic)element);
                if (text.LongText.Length == 0)
                {
                    transactionStatus.Text = "No longtext avaiable.";
                    return;
                }
                getLongTextString.Text = text.LongText[0].Tdline;

                transactionStatus.Text = text.LongText[0].Tdline;
                for (int i = 1; i < text.LongText.Length; ++i)
                    transactionStatus.Text += "\r\n" + text.LongText[i].Tdline;
            } catch(Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
        }

        private void setLongText_Click(object sender, EventArgs e)
        {
            try
            {
                if (setLongTextString.Text.Length == 0) return;
                var element = charBox.SelectedItem;
                if (element == null) return;
                var data = erpCharacteristics.AddLongText((Characteristic)element, LongTextHelper.Format.Default, setLongTextString.Text);
                transactionStatus.Text = data.Return[1].Type + ": " + data.Return[1].Message;
                setLongTextString.Clear();
            } catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
        }

        private void removeLongText_Click(object sender, EventArgs e)
        {
            try
            {
                var element = charBox.SelectedItem;
                if (element == null) return;
                var data = erpCharacteristics.RemoveLongText((Characteristic)element);
                transactionStatus.Text = data.Return[1].Type + ": " + data.Return[1].Message;
            } catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
        }
    }
}