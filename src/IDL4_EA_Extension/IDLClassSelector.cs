/*********************************************************************************************
(c) 2005-2013 Copyright, Real-Time Innovations, Inc.  All rights reserved.    	                             
RTI grants Licensee a license to use, modify, compile, and create derivative works 
of the Software.  Licensee has the right to distribute object form only for use with RTI 
products.  The Software is provided “as is”, with no warranty of any type, including 
any warranty for fitness for any purpose. RTI is under no obligation to maintain or 
support the Software.  RTI shall not be liable for any incidental or consequential 
damages arising out of the use or inability to use the software.
**********************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IDL4_EA_Extension
{
    public partial class IDLClassSelector : Form
    {
        UserActionInterface _actionInterface = null;

        public IDLClassSelector(UserActionInterface actionInterface)
        {
            _actionInterface = actionInterface;
            InitializeComponent();
        }

        public TreeView getTreeView()
        {
            return treeViewModelElements;
        }

        public TextBox getTextBox()
        {
            return textBoxIDLOutput;
        }

        private void textBoxIDLOutput_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            _actionInterface.OnCodegenAction();
            this.buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _actionInterface.OnSaveAction(saveFileDialog1.FileName);
            }
        }

        private void treeViewModelElements_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _actionInterface.OnSelectAction(e.Node);
            this.buttonSave.Enabled = true;
        }

        private void treeViewModelElements_AfterCheck(object sender, TreeViewEventArgs e)
        {
            _actionInterface.OnCheckAction(e.Node);
        }
    }
}
