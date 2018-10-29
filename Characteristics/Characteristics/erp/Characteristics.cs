using System.Collections.Generic;

namespace Characteristics.erp
{
    public class Characteristics : Erp
    {
        public Characteristics(ErpConnection connection) : base(connection)
        {
        }

        public void AddLongText(string longText)
        {
        }

        public void RemoveLongText()
        {
        }

        public string GetLongText()
        {
            return null;
        }

        public void Change()
        {
        }

        public void Rename()
        {
        }

        public void Create()
        {
        }

        public void Delete()
        {
        }

        public bool ExistenceCheck()
        {
            return false;
        }

        public void GetDetail()
        {
        }

        public List<object> GetList()
        {
            return null;
        }

        public List<object> GetWhereUsedList()
        {
            return null;
        }

        public void TransactionRollback()
        {
        }

        public void TransactionCommit()
        {
        }
    }
}