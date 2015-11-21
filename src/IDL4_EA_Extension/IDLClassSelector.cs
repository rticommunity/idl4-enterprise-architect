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
            IDLVersions idlVersions = new IDLVersions();

            idlVersionComboBox.DataSource = idlVersions.getVersionList();            
            idlVersionComboBox.DisplayMember = "Name";
            idlVersionComboBox.ValueMember = "Name";

            idlMappingDetailComboBox.DataSource = idlVersions.getMappingDetailList();
            idlMappingDetailComboBox.DisplayMember = "Name";
            idlMappingDetailComboBox.ValueMember = "Name";
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

        private void idlVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            _actionInterface.OnIdlVersionAction((IDLVersion)cb.SelectedItem);
            TreeNode sel = treeViewModelElements.SelectedNode;
            if (sel != null) _actionInterface.OnSelectAction(sel);
        }

        private void mappingDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            _actionInterface.OnIdlMappingDetailAction((IDLMappingDetail)cb.SelectedItem);
            TreeNode sel = treeViewModelElements.SelectedNode;
            if (sel != null) _actionInterface.OnSelectAction(sel);
        }
    }
    
    public class IDLVersion
    {
        public const int IDL_V350_CONNEXT52 = 349;
        public const int IDL_V350_XTYPES = 350;
        public const int IDL_V400 = 400;

        public string Name { get; set; }
        public int Value { get; set; }
    }

    public class IDLMappingDetail
    {
        public const int IDL_DETAILS_NONE   = 0;
        public const int IDL_DETAILS_BASIC  = 1;
        public const int IDL_DETAILS_FULL   = 2;

        public string Name { get; set; }
        public int Value { get; set; }
    }


    public class IDLVersions 
    {
        List<IDLVersion> _versions;
        List<IDLMappingDetail> _mappingDetails;

        public static IDLVersion defaultVersion =
            new IDLVersion { Name = "IDL v3.5 (RTI Connext 5.2)", Value = IDLVersion.IDL_V350_CONNEXT52 };

        public static IDLMappingDetail defaultMappingDetails =
            new IDLMappingDetail { Name = "IDL Mapping Details - Suppressed", Value = IDLMappingDetail.IDL_DETAILS_NONE };
       
        public List<IDLVersion> getVersionList()
        {
            return _versions;
        }

        public List<IDLMappingDetail> getMappingDetailList()
        {
            return _mappingDetails;
        }


        public IDLVersions()
        {
            _versions = new List<IDLVersion>();
            _versions.Add(new IDLVersion { Name = "IDL v3.5  +  RTI Connext DDS 5.2", Value = IDLVersion.IDL_V350_CONNEXT52 });
            _versions.Add(new IDLVersion { Name = "IDL v3.5  +  DDS-XTYPES 1.0", Value = IDLVersion.IDL_V350_XTYPES });
            _versions.Add(new IDLVersion { Name = "IDL v4.0", Value = IDLVersion.IDL_V400 });

            _mappingDetails = new List<IDLMappingDetail>();
            _mappingDetails.Add(new IDLMappingDetail { Name = "IDL Mapping Details - Suppressed", Value = IDLMappingDetail.IDL_DETAILS_NONE });
            _mappingDetails.Add(new IDLMappingDetail { Name = "IDL Mapping Details - Basic", Value = IDLMappingDetail.IDL_DETAILS_BASIC });
            _mappingDetails.Add(new IDLMappingDetail { Name = "IDL Mapping Details - Full", Value = IDLMappingDetail.IDL_DETAILS_FULL });
        }
    }  
}
