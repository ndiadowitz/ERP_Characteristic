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
        ErpClass erpClass = null;

        public Form1()
        {
            InitializeComponent();

            var connection = new ErpConnection("IDES-041", "1student");


            erpCharacteristics = new ErpCharacteristics(connection);
            erpClass = new ErpClass(connection);

            Disposed += Form1_Disposed;

        }

        private void Form1_Disposed(object sender, EventArgs e)
        {
            if (erpCharacteristics != null)
            {
                erpCharacteristics.RollbackChanges();
                erpCharacteristics.Close();
            }
            if (erpClass != null)
            {
                erpClass.RollbackChanges();
                erpClass.Close();
            }
        }

        private void CharGetList_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();
            try
            {
                var data = erpCharacteristics.GetList(GetList.Sign.Inclusive, GetList.Options.GreaterEqual, "0");
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

        private void classGetList_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();
            try {
                var data = erpClass.GetList("001", GetList.Sign.Inclusive, GetList.Options.GreaterEqual, "0");
                var Class = ClassMitK.ConvertToList(data);
                classBox.DataSource = Class;
            }
            catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
        }

        private void classGetDetail_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();
            try
            {
                var element = classBox.SelectedItem;
                if (element == null) return;
                var detail = erpClass.GetDetail("001", ((ClassMitK)element).Name);
                classDetail.Text = ClassMitK.ConvertToString(detail);
            }
            catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
        }

        private void CreateCharButton_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();
            try
            {
                var data = erpCharacteristics.CreateCharacteristic(new Characteristic(CharNameBox.Text, "meow", Datatypes.Datatype.CHAR, "0", "0", "noe", "RELEASE"));
                transactionStatus.Text = data.Return[1].Type + ": " + data.Return[1].Message;

            }
            catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
        }

        private void DeleteCharButton_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();

            var element = charBox.SelectedItem;
            if (element == null) return;
            try
            {
                var data = erpCharacteristics.DeleteCharacteristic((Characteristic)element);
                transactionStatus.Text = data.Return[1].Type + ": " + data.Return[1].Message;
            }
            catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }

        }

        private void CreateClassButton_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();

            if (ClassNameTextBox.Text.Length == 0) return;

            try
            {
                var data = erpClass.Create("001", ClassNameTextBox.Text, "DE", "noe");
                transactionStatus.Text = data.Return[1].Type + ": " + data.Return[1].Message;
            }
            catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
                  
        }

        private void ChangeClassButton_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();
            
            try
            {
                if (changeClassString.Text.Length == 0) return;
                var element = classBox.SelectedItem;
                if (element == null) return;

                var classMitK = (ClassMitK)element;
                var detail = erpClass.GetDetail("001", classMitK.Name);

                var data = erpClass.Change("001", classMitK.Name, detail.ClassDescriptions[0].Catchword, detail.ClassDescriptions[0].LanguIso, changeClassString.Text, "DE");
                transactionStatus.Text = data.Return[1].Type + ": " + data.Return[1].Message;
            }
            catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
        }

        private void DeleteClassButton_Click(object sender, EventArgs e)
        {
            transactionStatus.Clear();

            try
            {
                var element = classBox.SelectedItem;
                if (element == null) return;

                var data = erpClass.Delete("001", ((ClassMitK)element).Name);
                transactionStatus.Text = data.Return[1].Type + ": " + data.Return[1].Message;

            }
            catch (Exception ex)
            {
                transactionStatus.Text = ex.Message;
            }
        }
    }
}