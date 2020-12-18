using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace TLY.ItemSystem
{
    [System.Serializable]
    public class ItemDatabase
    {
        private System.Data.DataTable _dataSet;

        private void MakeDataTables()
        {
            _dataSet = new System.Data.DataTable();

            System.Data.DataColumn column1 = new System.Data.DataColumn();
            column1.ColumnName = "ID";
            column1.DataType = System.Type.GetType("System.Int64");
            column1.ReadOnly = true;
            column1.Unique = true;
            _dataSet.Columns.Add(column1);

            System.Data.DataColumn column2 = new System.Data.DataColumn();
            column2.ColumnName = "Item Name";
            column2.DataType = System.Type.GetType("System.String");
            column2.Unique = true;
            _dataSet.Columns.Add(column2);

            System.Data.DataColumn column3 = new System.Data.DataColumn();
            column3.ColumnName = "Description";
            column2.DataType = System.Type.GetType("System.String");

            System.Data.DataColumn column4 = new System.Data.DataColumn();
            column4.ColumnName = "Sprite";
            column4.DataType = System.Type.GetType("Sprite");
        }
    }
}
