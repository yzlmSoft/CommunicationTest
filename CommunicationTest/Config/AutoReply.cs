﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace CommunicationTest
{
    public partial class AutoReply : Form
    {
        string keyStr;
        public AutoReply()
        {
            InitializeComponent();
        }

        private async void AutoReply_LoadAsync(object sender, EventArgs e)
        {
            foreach (var item in await Global.AutoReplyConfig.GetAsync())
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell key = new DataGridViewTextBoxCell();
                key.Value = item.Key;
                row.Cells.Add(key);
                DataGridViewTextBoxCell value = new DataGridViewTextBoxCell();
                value.Value = StringByteUtils.BytesToString(item.Value);
                row.Cells.Add(value);
                dataGridView1.Rows.Add(row);
            }
        }

        private async void dataGridView1_CellEndEditAsync(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dataGridView1.Rows[e.RowIndex].Cells["key"].Value?.ToString()))
            {
                try
                {
                    var key = StringByteUtils.StringToBytes(dataGridView1.Rows[e.RowIndex].Cells["key"].Value.ToString());
                    var value = StringByteUtils.StringToBytes(dataGridView1.Rows[e.RowIndex].Cells["value"].Value?.ToString() ?? "");
                    await Global.AutoReplyConfig.AddOrUpdateAsync(new KeyValuePair<byte[], byte[]>(key, value));
                }
                catch (Exception)
                {

                }
            }
        }

        private async void dataGridView1_RowsRemovedAsync(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            await Global.AutoReplyConfig.RemoveAsync(keyStr);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                keyStr = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["key"].Value?.ToString();
            }
        }

        private void AutoReply_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
                dataGridView1.EndEdit();
            }
            else if (dataGridView1.EditMode != DataGridViewEditMode.EditOnEnter)
            {
                dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
                dataGridView1.BeginEdit(false);
            }
        }
    }
}
